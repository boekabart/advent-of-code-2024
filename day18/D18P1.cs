using shared;

namespace day18;


public static class D18P1
{
    public static int Part1Answer(this string input, int n = 1024)
    { 
        var damageList = input.ParseThings().ToList();

        return CalculateShortestPath(damageList, n);
    }

    public static int CalculateShortestPath(this List<Pos> damageList, int n)
    {
        var sx = damageList.Max(p => p.X) + 1;
        var sy = damageList.Max(p => p.Y) + 1;
        Console.WriteLine(damageList.Take(n).Last());
        var blockMap = new Map<int>(sx, sy);
        foreach (var (damage, moment) in damageList.WithIndex().Take(n))
            blockMap.Set(damage, moment + 1);
        var m = new Map(blockMap.Convert(a => a == 0 ? '.' : '#').Grid);
        Console.WriteLine(m.Dump());
        return blockMap.FindShortestPathLength(new Pos(0, 0), new Pos(sx - 1, sy - 1));
    }

    internal static int FindShortestPathLength(this Map<int> mapWithBlocks, Pos start, Pos end)
    {
        var fromStart = mapWithBlocks.Convert(_ => (int?)null);
        fromStart.Set(start, 0);
        var fromEnd = mapWithBlocks.Convert(_ => (int?)null);
        fromEnd.Set(end, 0);
        Queue<Pos> startQueue = [];
        startQueue.Enqueue(start);
        Queue<Pos> endQueue = [];
        endQueue.Enqueue(end);
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
                    if ((fromStart.Get(s2)??int.MaxValue) <= nextDist)
                        continue;
                    if (fromEnd.Get(s2).HasValue)
                        return nextDist + fromEnd.Get(s2)!.Value;
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
                    if ((fromEnd.Get(e2)??int.MaxValue) <= nextDist)
                        continue;
                    if (fromStart.Get(e2).HasValue)
                        return nextDist + fromStart.Get(e2)!.Value;
                    fromEnd.Set(e2, nextDist);
                    endQueue.Enqueue(e2);
                }
            }
        }

        return -1;
    }

    internal static IEnumerable<Pos> ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<Pos>();

    internal static Pos? TryParseAsThing(this string line)
    {
        var s = line.Split(',');
        if (s.Length == 2)
            return new Pos(int.Parse(s[0]), int.Parse(s[1]));
        return null;
    }
}