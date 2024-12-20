using shared;

namespace day20;

internal record Thing(bool Data);

public static class D20P1
{
    public static object Part1Answer(this string input, int minCheatValue = 100)
    {
        var map = input.ParseMap();
        var start = map.FindAll('S').Single();
        var end = map.FindAll('E').Single();
        var blocks = map.Convert(ch => ch == '#' ? 1 : 0);
        _ = blocks.FillDistanceFromStartMap(start, end, out var fromStart);
        var allBlocks = blocks.FindAll(1);
        var n = 0;
        foreach (var blockPos in allBlocks)
        {
            var availableStartDistances = blockPos.FourAround().Where(fromStart.Contains).Select(fromStart.Get).OfType<int>()
                .ToList();
            if (!availableStartDistances.Any())
                continue;
            var availableEndDistances = blockPos.FourAround().Where(fromStart.Contains).Select(fromStart.Get).OfType<int>()
                .ToList();
            var lowestStart = availableStartDistances.Min();
            var cheatEnd = lowestStart + 2;
            var highestEnd =  + availableEndDistances.Max();
            var saved = highestEnd - cheatEnd;
            if (saved >= minCheatValue)
                n++;
        }

        return n;
    }

    internal static int FillDistanceFromStartMap(this Map<int> mapWithBlocks, Pos start, Pos end, out Map<int?> fromStart)
    {
        fromStart = mapWithBlocks.Convert(_ => (int?)null);
        fromStart.Set(start, 0);
        Queue<Pos> startQueue = [];
        startQueue.Enqueue(start);
        var lowest = int.MaxValue;
        while (startQueue.Any())
        {
            if (startQueue.TryDequeue(out var s))
            {
                var dist = fromStart.Get(s)!.Value;
                var nextDist = dist + 1;
                foreach (var s2 in s.FourAround().Where(mapWithBlocks.Contains))
                {
                    if (mapWithBlocks.Get(s2) > 0)
                        continue;
                    if ((fromStart.Get(s2) ?? int.MaxValue) <= nextDist)
                        continue;
                    if (s2 == end)
                        lowest = Math.Min(lowest, nextDist);
                    fromStart.Set(s2, nextDist);
                    startQueue.Enqueue(s2);
                }
            }
        }

        return lowest;
    }
}