using shared;

namespace day1;

internal record Thing(int Number1, int Number2);

public static class D1P1
{
    public static object Part1Answer(this string input)
    {
        var lists = ParseThings(input).ToList();
        var list1 = lists.Select(t => t.Number1).Order().ToList();
        var list2 = lists.Select(t => t.Number2).Order().ToList();
        return list1.Select((n1, idx) => Math.Abs(n1 - list2[idx])).Sum();
    }

    internal static IEnumerable<Thing> ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<Thing>();

    internal static Thing? TryParseAsThing(this string line)
    {
        var split = line.Split([' ', '\t'], StringSplitOptions.RemoveEmptyEntries);
        return split.Length == 2 && int.TryParse(split[0], out var n1) && int.TryParse(split[1], out var n2)
            ? new Thing(n1, n2)
            : null;

    }

    internal static int GetResult(this IEnumerable<Thing> things) => things.Select(AsResult).Sum();
    internal static int AsResult(this Thing thing) => 0;
}