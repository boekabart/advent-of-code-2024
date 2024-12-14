using shared;

namespace day14;

internal record Thing(Pos Pos, Pos Speed);

public static class D14P1
{
    public static object Part1Answer(this string input, Pos? mapSize = null) =>
        input.ParseThings().GetResult(100, mapSize ?? new Pos(101, 103));

    internal static IEnumerable<Thing> ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<Thing>();

    internal static Thing? TryParseAsThing(this string line)
    {
        var split = line.Split([',', '=', 'p', 'v', ' '], StringSplitOptions.RemoveEmptyEntries);
        return split.Length == 4
            ? new Thing(new Pos(int.Parse(split[0]), int.Parse(split[1])),
                new Pos(int.Parse(split[2]), int.Parse(split[3]))):null;
    }

    internal static int GetResult(this IEnumerable<Thing> things, int sec, Pos mapSize) => things.Select(t => t.AsResult(sec, mapSize))
        .GroupBy(pos => pos.Quadrant(mapSize))
        .Where(gr => gr.Key != 0)
        .Select(gr => gr.Count())
        .Aggregate(1, (n,m) => n*m);
    internal static Pos AsResult(this Thing thing, int sec, Pos mapSize) => thing.Pos.Add(thing.Speed.Times(sec)).AbsMod(mapSize);

    internal static int Quadrant(this Pos pos, Pos mapSize)
    {
        if (pos.X < mapSize.X / 2)
        {
            if (pos.Y < mapSize.Y / 2)
                return 1;
            if (pos.Y > mapSize.Y / 2)
                return 3;
        }
        if (pos.X > mapSize.X / 2)
        {
            if (pos.Y < mapSize.Y / 2)
                return 2;
            if (pos.Y > mapSize.Y / 2)
                return 4;
        }
        return 0;
    }
}