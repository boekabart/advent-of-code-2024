namespace day4;

public static class D4P2
{
    public static object Part2Answer(this string input) => input.ParseThings().GetResult2();

    internal static int GetResult2(this IEnumerable<string> things)
    {
        var word = "XMAS";
        var wordRev = word.Reversed();

        var list = things.ToList();
        var skewedOneWay = list.Skewed().ToList().Transposed().ToList();
        var centerPositions1 = skewedOneWay.CenterPositions();
        centerPositions1 = centerPositions1.Transposed().Unskewed().ToList();
        //foreach (var cp in centerPositions1) Console.WriteLine(cp);
        //Console.WriteLine();
        var skewedOtherWay = things.Reverse().ToList().Skewed().ToList().Transposed().ToList();
        var centerPositions2 = skewedOtherWay.CenterPositions();
        centerPositions2 = centerPositions2.Transposed().Unskewed().Unreversed(list.Count - 1).ToList();
        //foreach (var cp in centerPositions2) Console.WriteLine(cp);

        return centerPositions1.Intersect(centerPositions2).Distinct().Count();
    }

    internal static IEnumerable<(int x, int y)> Transposed(this IEnumerable<(int x, int y)> src) =>
        src.Select(pair => (pair.y, pair.x));

    internal static IEnumerable<(int x, int y)> Unskewed(this IEnumerable<(int x, int y)> src) =>
        src.Select(pair => (pair.x - pair.y, pair.y));

    internal static IEnumerable<(int x, int y)> Unreversed(this IEnumerable<(int x, int y)> src, int height) =>
        src.Select(pair => (pair.x, height - pair.y));

    internal static IEnumerable<(int x, int y)> CenterPositions(this IEnumerable<string> lines)
    {
        return lines.SelectMany((l, y) => l.EnumerateWordsTwoWay("MAS").Select(start => start + 1).Select(x => (x, y)));
    }

    internal static IEnumerable<int> EnumerateWordsTwoWay(this string line, string word)
        => line.EnumerateWords(word).Concat(line.EnumerateWords(word.Reversed()));
    internal static IEnumerable<int> EnumerateWords(this string line, string word)
    {
        int start = 0;
        while (true)
        {
            start = line.IndexOf(word, start, StringComparison.InvariantCulture);
            if (start < 0)
                yield break;
            yield return start;
            start++;
        }
    }

}
