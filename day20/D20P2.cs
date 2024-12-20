using shared;

namespace day20;

public static class D20P2
{
    public static object Part2Answer(this string input, int minCheatValue = 100)
    {
        var map = input.ParseMap();
        var start = map.FindAll('S').Single();
        var end = map.FindAll('E').Single();
        var blocks = map.Convert(ch => ch == '#' ? 1 : 0);
        var shortest = blocks.FillDistanceFromStartMap(start, end, out var fromStart);
        // Find all (start,end) combinations where Distance + start + end + minCheatValue < shortest
        var allPopulated = fromStart.AllPositions().Where(pr => fromStart.Get(pr).HasValue).ToHashSet();
        var posByDistanceFromStart = allPopulated
            .GroupBy(pr => fromStart.Get(pr)!.Value).ToDictionary(gr => gr.Key, gr => gr.ToList());

        List<(Pos Start, Pos End, int CheatValue)> cheats = [];
        int maxUsefulDistanceFromStartToLookForStartOfCheat = shortest - (minCheatValue+2);
        int cheatCount = 0;
        foreach (var dfs in posByDistanceFromStart.Keys.Where(dfs => dfs<=maxUsefulDistanceFromStartToLookForStartOfCheat))
        {
            foreach (var aStartPos in posByDistanceFromStart[dfs])
            {
                var others = aStartPos
                    .WithManhattanDistance(2, 20)
                    .Where(allPopulated.Contains)
                    ;

                foreach (var other in others)
                {
                    var dist = other.ManhattanDist(aStartPos);
                    var cheatValue = fromStart.Get(other)!.Value - dfs - dist;
                    if (cheatValue < minCheatValue)
                        continue;
                    //cheats.Add((aStartPos, other, cheatValue));
                    cheatCount++;
                }

            }
        }

        return cheatCount;
        //return cheats.Count;
    }
}
