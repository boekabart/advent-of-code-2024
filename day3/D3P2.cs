using System.Text.RegularExpressions;

namespace day3;

public static class D3P2
{
    public static object Part2Answer(this string input) => input.ParseThings2().Select(t => t.a * t.b).Sum();

    private static Regex regex = new Regex(@"(do\(\)|don't\(\)|mul\((\d+),(\d+)\))", RegexOptions.Compiled);

    internal static IEnumerable<Thing> ParseThings2(this string input)
    {
        var m = regex.Matches(input);
        var doen = true;
        for (int q = 0; q < m.Count; q++)
        {
            var mm = m[q];
            if (mm.Captures[0].Value == "do()")
            {
                doen = true;
                continue;
            }

            if (!doen)
                continue;

            if (mm.Captures[0].Value == "don't()")
            {
                doen = false;
                continue;
            }

            var a = int.Parse(mm.Groups[2].Captures[0].Value);
            var b = int.Parse(mm.Groups[3].Captures[0].Value);
            yield return new Thing(a, b);
        }
    }
}
