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
        var shortestPath = map.FindCheapestPath(start, dir, end);
        return shortestPath;
    }

    internal record Situation(Pos Pos, Pos Dir, int Cost);

    internal static Situation TurnRight(this Situation situation) =>
        situation with { Dir = situation.Dir.RotateRight(), Cost = situation.Cost + 1000 };
    internal static Situation TurnLeft(this Situation situation) =>
        situation with { Dir = situation.Dir.RotateLeft(), Cost = situation.Cost + 1000 };
    internal static Situation Forward(this Situation situation) =>
        situation with { Pos = situation.Pos.Add(situation.Dir), Cost = situation.Cost + 1 };

    internal static long FindCheapestPath(this Map map, Pos pos, Pos dir, Pos goal)
    {
        int cheapestScore = int.MaxValue;
        Queue<Situation> todo= [];
            todo.Enqueue(new Situation(pos, dir, 0));
            var cheapestAtPos = map.Convert(_ => int.MaxValue);
        while (todo.Any())
        {
            var sit = todo.Dequeue();
            if (sit.Cost >= cheapestScore)
                continue;

            if (sit.Cost - 2000 > cheapestAtPos.Get(sit.Pos))
                continue;

            if (sit.Cost < cheapestAtPos.Get(sit.Pos))
                cheapestAtPos.Set(sit.Pos, sit.Cost);

            if (sit.Pos == goal)
            {
                cheapestScore = sit.Cost;
                continue;
            }
            if (map.Get(sit.Pos)=='#')
                continue;

            todo.Enqueue(sit.Forward());
            todo.Enqueue(sit.TurnRight());
            todo.Enqueue(sit.TurnLeft());
        }
        return cheapestScore;
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