using shared;

namespace day19;

internal record struct Towel(string Stripes);

internal record struct Pattern(string Stripes);

public static class D19P1
{
    public static object Part1Answer(this string input)
    {
        var towels = input.ParseTowels().ToList();
        return input.ParsePatterns()
            .CanBeMade(towels).Count( boel => boel);
    }

    internal static string FindGuaranteedStartString(this Pattern pattern, IEnumerable<Towel> towels)
        => string.Join(",", pattern.FindGuaranteedStarts(towels, out _).Order());

    internal static IEnumerable<bool> CanBeMade(this IEnumerable<Pattern> patterns, List<Towel> towels)
    {
        return patterns.Select(p => p.FindGuaranteedStarts(towels, out _).Any());
    }

    internal static IEnumerable<int> FindGuaranteedStarts(this Pattern pattern, IEnumerable<Towel> towels, out List<(int Start, int End)> wordStarts)
    {
        var stripes = pattern.Stripes;
        HashSet<(int Start, int End)> words = [];
        foreach (var t in towels)
        {
            foreach (var se in stripes.AllIndicesOf(t.Stripes).Select(s => (s, s + t.Stripes.Length)))
                words.Add(se);
        }

        while (true)
        {
            var ends = words.Select(se => se.End).ToHashSet();
            ends.Add(0);
            var starts = words.Select(se => se.Start).ToHashSet();
            starts.Add(stripes.Length);
            var startsWithoutEnds = words.Where(se => !ends.Contains(se.Start)).ToList();
            var endsWithoutStarts = words.Where(se => !starts.Contains(se.End)).ToList();
            if (!startsWithoutEnds.Any() && !endsWithoutStarts.Any())
                break;
            foreach (var se in startsWithoutEnds)
                words.Remove(se);
            foreach (var se in endsWithoutStarts)
                words.Remove(se);
        }

        wordStarts = [];
        // Now, starts only has useful starts that are actually at the point where another option ends, and have another option starting
        // where they end
        var touchedIndices = words.SelectMany(se => Enumerable.Range(se.Start, se.End - se.Start)).ToHashSet();
        if (touchedIndices.Count < stripes.Length)
            return [];

        wordStarts = words.ToList();
        var midWords = words.SelectMany(se => Enumerable.Range(se.Start + 1, se.End - (se.Start + 1))).ToHashSet();
        var guaranteedStarts =
            words.Select(se => se.Start).Where(s => !midWords.Contains(s)).Distinct();
        return guaranteedStarts;
    }

    internal static bool CanBeMade(this Pattern pattern, List<Towel> towels)
    {
        HashSet<string> yes = towels.Select(t => t.Stripes).ToHashSet();
        HashSet<string> no = [];
        return pattern.CanBeMade(yes, no);
    }

    internal static IEnumerable<bool> CanBeMade(this IEnumerable<Pattern> pattern, HashSet<string> yes,
        HashSet<string> no)
    {
        return pattern.Select(p => p.CanBeMade(yes, no));
    }

    internal static bool CanBeMade(this Pattern pattern, HashSet<string> yes, HashSet<string> no)
    {
        if (yes.Contains(pattern.Stripes)) return true;
        if (no.Contains(pattern.Stripes)) return false;
        foreach (var t in yes)
        {
            if (pattern.Stripes.StartsWith(t))
            {
                var subPattern = new Pattern(pattern.Stripes.Substring(t.Length));
                if (subPattern.CanBeMade(yes, no))
                {
                    yes.Add(pattern.Stripes);
                    return true;
                }
            }
        }

        no.Add(pattern.Stripes);
        return false;
    }

    internal static IEnumerable<Pattern> ParsePatterns(this string input) =>
        input
            .NotEmptyTrimmedLines()
            .Where(l => !l.Contains(','))
            .Select(l => new Pattern(l));

    internal static IEnumerable<Towel> ParseTowels(this string input) =>
        input
            .Lines()
            .SelectMany(TryParseAsTowels);

    internal static IEnumerable<Towel> TryParseAsTowels(this string line)
    {
        var split = line.Split([',', ' '], StringSplitOptions.RemoveEmptyEntries);
        return split.Length > 1
            ? split.Select(s => new Towel(s))
            :[];
    }

}