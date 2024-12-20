using shared;

namespace day19;

public static class D19P2
{
    public static long Part2Answer(this string input)
    {
        var towels = input.ParseTowels().ToList();
        return input.ParsePatterns()
            .Select(p => p.CountOptions(towels))
            .Sum(lang => lang);
    }

    internal static long CountOptions(this Pattern pattern, List<Towel> towels)
    {
        var startIndices = pattern.FindGuaranteedStarts(towels, out var words).Order().ToList();
        if (!startIndices.Any())
            return 0;

        var wordStarts = words.GroupBy(se => se.Start).ToDictionary(gr => gr.Key, gr => gr.Select(se => se.End).ToList());
        long n = 1;
        foreach (var (start, index) in startIndices.WithIndex())
        {
            var end = index + 1 < startIndices.Count ? startIndices[index + 1] : pattern.Stripes.Length;
            var length = end - start;
            var substring = pattern.Stripes.Substring(start, length);
            var possibilities = wordStarts.CountPathsFromTo(start, end, []);
            n *= possibilities;
        }
        return n;
    }

    internal static long CountPathsFromTo(this Dictionary<int, List<int>> words, int start, int end, Dictionary<(int Start, int End), long> cache)
    {
        if (start == end)
            return 1;
        var key = (start, end);
        if (cache.TryGetValue(key, out var result)) return result;
        result = words[start].Sum(endsFromHere => words.CountPathsFromTo(endsFromHere, end, cache));
        cache[key]= result;
        return result;
    }

    internal static IEnumerable<int> AllIndicesOf(this string longString, string shortString)
    {
        int start = 0;
        while (true)
        {
            var index = longString.IndexOf(shortString, start, StringComparison.Ordinal);
            if (index < 0) yield break;

            yield return index;
            start = index + 1;
        }
    }
}
