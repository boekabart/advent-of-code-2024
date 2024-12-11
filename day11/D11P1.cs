using shared;

namespace day11;

public static class D11P1
{
    public static object Part1Answer(this string input) =>
        input.ParseInput().GetResult();

    internal static IEnumerable<ulong> ParseInput(this string input) =>
        input
            .NotEmptyTrimmedLines()
            .Single()
            .Split(' ')
            .Select(ulong.Parse);


    internal static ulong GetResult(this IEnumerable<ulong> things) => things
        .Iterate(25);


    internal static ulong Iterate(this IEnumerable<ulong> thing, int n)
        => thing.Aggregate<ulong, ulong>(0, (current, t) => current + Iterate(t, n));

    private static Dictionary<(ulong N, int Gens), ulong> dict = [];

    internal static ulong Iterate(this ulong thing, int n)
    {
        if (n == 0) return 1;
        if (dict.TryGetValue((thing, n), out var value)) return value;
        var arr = Iterate(thing);
        ulong answer = arr.Aggregate<ulong, ulong>(0, (current, t) => current + Iterate(t, n - 1));
        dict[(thing, n)] = answer;
        return answer;
    }

    internal static ulong[] Iterate(this ulong thing)
    {
        if (thing == 0)
        {
            return [1];
        }

        var str = thing.ToString();
        if (str.Length % 2 == 0)
        {
            var n1 = ulong.Parse(str.Substring(0, str.Length / 2));
            var rhs = str.Substring(str.Length / 2);
            var n2 = ulong.Parse(rhs);
            return [n1, n2];
        }

        return [thing * 2024];
    }

}