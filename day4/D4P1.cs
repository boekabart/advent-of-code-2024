using shared;

namespace day4;

public static class D4P1
{
    public static object Part1Answer(this string input) =>
        input.ParseThings().GetResult();

    internal static IEnumerable<string> ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<string>();

    internal static string? TryParseAsThing(this string line)
    {
        return string.IsNullOrWhiteSpace(line)?null:line.Trim();
    }

    internal static int GetResult(this IEnumerable<string> things)
    {
        var word = "XMAS";
        var wordRev = word.Reversed();
        
        var normalGrid = things.ToList();
        var horCount = normalGrid.Sum(l => l.CountWords(word) + l.CountWords(wordRev));

        var transposedGrid = normalGrid.Transposed();
        var verCount = transposedGrid.Sum(l => l.CountWords(word) + l.CountWords(wordRev));

        var skewedOneWay = normalGrid.Skewed().ToList().Transposed().ToList();
        var skewOneCount = skewedOneWay.Sum(l => l.CountWords(word) + l.CountWords(wordRev));

        var skewedOtherWay = things.Reverse().ToList().Skewed().ToList().Transposed().ToList();
        var skewTwoCount = skewedOtherWay.Sum(l => l.CountWords(word) + l.CountWords(wordRev));

        return horCount + verCount + skewOneCount + skewTwoCount;
    }

    internal static IEnumerable<string> Transposed(this IList<string> grid)
    {
        for (int col = 0; col < grid.Max(l => l.Length); col++)
        {
            yield return string.Join("", grid.Select(l => l[col]));
        }
    }

    internal static IEnumerable<string> Skewed(this IList<string> grid)
    {
        return grid.Select((l, i) => string.Join("",
            Enumerable.Repeat(0, i).Select(_ => ' ').Concat(l).Concat(Enumerable.Repeat(0, grid.Count - (i+1)).Select(_ => ' '))));
    }

    internal static int CountWords(this string line, string word)
    {
        int count = 0;
        int start = 0;
        while (true)
        {
            start = line.IndexOf(word, start, StringComparison.InvariantCulture);
            if (start < 0)
                return count;
            count++;
            start++;
        }
    }

    internal static string Reversed(this string any)
    {
        return string.Join("", any.Reverse());
    }
}