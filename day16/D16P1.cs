using shared;

namespace day16;

internal record Thing(bool Data);

public static class D16P1
{
    public static object Part1Answer(this string input)
    {
        var map = input.ParseMap();
        var start = map.FindAll('S').First();
        var end = map.FindAll('E').First();
        var dir = Dir.Right;
        var shortestPath = map.FindCheapestPath(start, dir, end, out _);
        return shortestPath;
    }

    internal record Situation(Pos Pos, Pos Dir, int Cost, Situation? Prev = null);

    internal static Situation TurnRight(this Situation situation) =>
        situation with { Dir = situation.Dir.RotateRight(), Cost = situation.Cost + 1000, Prev = situation };
    internal static Situation TurnLeft(this Situation situation) =>
        situation with { Dir = situation.Dir.RotateLeft(), Cost = situation.Cost + 1000, Prev = situation };
    internal static Situation Forward(this Situation situation) =>
        situation with { Pos = situation.Pos.Add(situation.Dir), Cost = situation.Cost + 1, Prev = situation };

    internal static long FindCheapestPath(this Map map, Pos pos, Pos dir, Pos goal, out int goodPositions)
    {
        int cheapestScore = int.MaxValue;
        Queue<Situation> todo= [];
            todo.Enqueue(new Situation(pos, dir, 0));
            var cheapestAtPos = map.Convert(_ => int.MaxValue);
        List<Situation> winningPath = [];
        while (todo.Any())
        {
            var sit = todo.Dequeue();
            if (sit.Cost > cheapestScore)
                continue;

            if (sit.Cost - 2000 > cheapestAtPos.Get(sit.Pos))
                continue;

            if (sit.Pos == goal)
            {
                cheapestScore = sit.Cost;
                winningPath.Add(sit);
                continue;
            }
            if (map.Get(sit.Pos) == '#')
                continue;

            if (sit.Cost < cheapestAtPos.Get(sit.Pos))
                cheapestAtPos.Set(sit.Pos, sit.Cost);

            todo.Enqueue(sit.Forward());
            todo.Enqueue(sit.TurnRight());
            todo.Enqueue(sit.TurnLeft());
        }

        HashSet<Pos> goodPositionList = [];
        foreach (var ws in winningPath.Where(s => s.Cost == cheapestScore))
            ws.CollectGoodPositions(goodPositionList);

        if (false)
        {
            foreach (var p in goodPositionList)
                map.Set(p, 'O');

            Console.WriteLine(map.Dump());
        }

        goodPositions = goodPositionList.Count;
        return cheapestScore;
    }

    internal static void CollectGoodPositions(this Situation sit, HashSet<Pos> positions)
    {
        positions.Add(sit.Pos);
        sit.Prev?.CollectGoodPositions(positions);
    }

    internal static IEnumerable<Thing> ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<Thing>();

    internal static Thing? TryParseAsThing(this string line)
    {
        return null;
    }

    internal static int GetResult(this IEnumerable<Thing> things) => things.Select(AsResult).Sum();
    internal static int AsResult(this Thing thing) => 0;
}