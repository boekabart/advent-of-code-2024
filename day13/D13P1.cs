using shared;

namespace day13;

internal record Thing(Pos A, Pos B, Pos P);

public static class D13P1
{
    public static object Part1Answer(this string input) =>
        input.ParseThings().GetResult();

    internal static IEnumerable<Thing> ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<Pos>()
            .Buffer(3)
            .Where(b => b.Length==3)
            .Select(l => new Thing(l[0], l[1], l[2]));

    internal static Pos? TryParseAsThing(this string line)
    {
        var split = line.Split([',', '=', '+', ' '], StringSplitOptions.RemoveEmptyEntries);
        return split.Length >= 4 ? new Pos(int.Parse(split[^3]), int.Parse(split[^1])) : null;
    }

    internal static int GetResult(this IEnumerable<Thing> things) => things.Select(AsResult).Sum();
    internal static int AsResult(this Thing thing) => 0;
}