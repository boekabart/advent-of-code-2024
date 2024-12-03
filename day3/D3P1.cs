using System.Text.RegularExpressions;
using shared;

namespace day3;

internal record Thing(int a, int b);

public static class D3P1
{
    public static object Part1Answer(this string input) => input.ParseThings().Select(t => t.a * t.b).Sum();

    private static Regex regex = new Regex(@"mul\((\d+),(\d+)\)", RegexOptions.Compiled);

    internal static IEnumerable<Thing> ParseThings(this string input)
    {
        var m = regex.Matches(input);
        for (int q = 0; q < m.Count; q++)
        {
            var mm = m[q];
            var a = int.Parse(mm.Groups[1].Captures[0].Value);
            var b = int.Parse(mm.Groups[2].Captures[0].Value);
            yield return new Thing(a, b);
        }
    }

    internal static Thing? TryParseAsThing(this string line)
    {
        return null;
    }

    internal static int GetResult(this IEnumerable<Thing> things) => things.Select(AsResult).Sum();
    internal static int AsResult(this Thing thing) => 0;
}