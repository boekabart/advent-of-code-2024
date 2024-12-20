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
        var shortest = blocks.FindShortestPathLength(start, end, out var fromStart, out var fromEnd);
        // Find all (start,end) combinations where Distance + start + end + minCheatValue < shortest
        var posByDistanceFromStart = fromStart.AllPositions().Select(p => (p, fromStart.Get(p))).Where(pr => pr.Item2.HasValue)
            .Select(pr => (pr.p, pr.Item2.Value))
            .GroupBy(pr => pr.Value).ToDictionary(gr => gr.Key, gr => gr.Select(pr => pr.p).ToList());

        List<(Pos Start, Pos End, int CheatValue)> cheats = [];
        int maxUsefulDistanceFromStartToLookForStartOfCheat = shortest - (minCheatValue+2);
        foreach (var dfs in posByDistanceFromStart.Keys.Where(dfs => dfs<=maxUsefulDistanceFromStartToLookForStartOfCheat))
        {
            var minOther = dfs + minCheatValue + 2;
            var allOthers = posByDistanceFromStart
                .Where(pr => pr.Key >= minOther)
                .SelectMany(pr => pr.Value).ToList();
            foreach (var aStartPos in posByDistanceFromStart[dfs])
            {
                foreach (var other in allOthers)
                {
                    var dist = other.ManhattanDist(aStartPos);
                    if (dist > 20)
                        continue;
                    var cheatValue = fromStart.Get(other)!.Value - dfs - dist;
                    if (cheatValue < minCheatValue)
                        continue;
                    /*var blocked = false;
                    var factors = dir.Decompose().Select(p => p.Sign()).ToList();
                    var oneWayHasBlocks = blocks.Get(aStartPos.Add(factors[0])) == 1 &&
                                          blocks.Get(other.Subtract(factors[^1])) == 1;
                    var otherWayHasBlocks = blocks.Get(aStartPos.Add(factors[^1])) == 1 &&
                                          blocks.Get(other.Subtract(factors[0])) == 1;
                    if (oneWayHasBlocks || otherWayHasBlocks)*/
                        cheats.Add((aStartPos, other, cheatValue));
                }

            }
        }
        return cheats.Count;
    }
}
