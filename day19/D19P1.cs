using shared;

namespace day19;

internal record Towel(string Stripes);

internal record Pattern(string Stripes);

public static class D19P1
{
    public static object Part1Answer(this string input)
    {
        var towels = input.ParseTowels().ToList();
        return input.ParsePatterns().AsParallel().Count(p => p.CanBeMade(towels));
    }

    internal static bool CanBeMade(this Pattern pattern, List<Towel> towels)
    {
        foreach (var t in towels)
        {
            if (pattern.Stripes.StartsWith(t.Stripes))
            {
                if (pattern.Stripes.Length == t.Stripes.Length)
                    return true;
                var subPattern = new Pattern(pattern.Stripes.Substring(t.Stripes.Length));
                if (subPattern.CanBeMade(towels))
                    return true;
            }
        }
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