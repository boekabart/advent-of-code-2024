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


    internal static int GetResult(this IEnumerable<ulong> things) => things
        .Iterate(25)
        .Count();
    internal static IEnumerable<ulong> Iterate(this IEnumerable<ulong> thing, int n)
    {
        var iter = thing.ToList();
        for (int q = 0; q < n; q++)
            iter = iter.Iterate().ToList();
        return iter;
    }

    internal static IEnumerable<ulong> Iterate(this IEnumerable<ulong> thing) => thing.SelectMany(Iterate);

    internal static IEnumerable<ulong> Iterate(this ulong thing)
    {
        if (thing == 0)
        {
            yield return 1;
            yield break;
        }

        var str = thing.ToString();
        if (str.Length % 2 == 0)
        {
            yield return ulong.Parse(str.Substring(0, str.Length / 2).TrimStart('0'));
            var rhs = str.Substring(str.Length / 2).TrimStart('0');
            if (rhs.Length == 0)
                yield return 0;
            else
                yield return ulong.Parse(rhs);
            yield break;
        }

        yield return thing * 2024;
    }
}