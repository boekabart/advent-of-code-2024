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
        var shortest = blocks.FindShortestPathLength(start, end, out var fromStart, out var fromEnd);
        var allBlocks = blocks.FindAll(1);
        var n = 0;
        foreach (var blockPos in allBlocks)
        {
            var availableStartDistances = blockPos.FourAround().Where(fromStart.Contains).Select(fromStart.Get).OfType<int>()
                .ToList();
            if (!availableStartDistances.Any())
                continue;
            var availableEndDistances = blockPos.FourAround().Where(fromEnd.Contains).Select(fromEnd.Get).OfType<int>()
                .ToList();
            if (!availableEndDistances.Any())
                continue;
            var dist = availableStartDistances.Min() + availableEndDistances.Min() + 2;
            var saved = shortest - dist;
            if (saved >= minCheatValue)
                n++;
        }

        return n;
    }

    internal static int FindShortestPathLength(this Map<int> mapWithBlocks, Pos start, Pos end, out Map<int?> fromStart, out Map<int?> fromEnd)
    {
        fromStart = mapWithBlocks.Convert(_ => (int?)null);
        fromStart.Set(start, 0);
        fromEnd = mapWithBlocks.Convert(_ => (int?)null);
        fromEnd.Set(end, 0);
        Queue<Pos> startQueue = [];
        startQueue.Enqueue(start);
        Queue<Pos> endQueue = [];
        endQueue.Enqueue(end);
        var lowest = int.MaxValue;
        while (startQueue.Any() || endQueue.Any())
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
                    if (fromEnd.Get(s2).HasValue)
                        lowest= Math.Min(lowest, nextDist + fromEnd.Get(s2)!.Value);
                    fromStart.Set(s2, nextDist);
                    startQueue.Enqueue(s2);
                }
            }
            if (endQueue.TryDequeue(out var e))
            {
                var dist = fromEnd.Get(e)!.Value;
                var nextDist = dist + 1;
                foreach (var e2 in e.FourAround().Where(mapWithBlocks.Contains))
                {
                    if (mapWithBlocks.Get(e2) > 0)
                        continue;
                    if ((fromEnd.Get(e2) ?? int.MaxValue) <= nextDist)
                        continue;
                    if (fromStart.Get(e2).HasValue)
                        lowest = Math.Min(lowest, nextDist + fromStart.Get(e2)!.Value);
                    fromEnd.Set(e2, nextDist);
                    endQueue.Enqueue(e2);
                }
            }
        }

        return lowest;
    }
}