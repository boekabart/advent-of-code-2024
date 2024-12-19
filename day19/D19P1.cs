using shared;

namespace day19;

internal record struct Towel(string Stripes);

internal record struct Pattern(string Stripes);

public static class D19P1
{
    public static object Part1Answer(this string input)
    {
        var towels = input.ParseTowels().ToList();
        return input.ParsePatterns().CanBeMade(towels).Count( boel => boel);
    }

    internal static IEnumerable<bool> CanBeMade(this IEnumerable<Pattern> patterns, List<Towel> towels)
    {
        HashSet<string> yes = towels.Select(t => t.Stripes).ToHashSet();
        HashSet<string> no = [];
        return patterns.CanBeMade(yes, no);
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