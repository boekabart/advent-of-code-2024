using shared;

namespace day5;

internal record Rules(List<int> RequiredOrdering);
internal record Ordering(List<int> PageNumbers);

public static class D5P1
{
    public static object Part1Answer(this string input) =>
        input.ParseOrdering().Where(o => o.Matches(input.ParseRules())).Select(o => o.MiddleNumber()).Sum();

    internal static int MiddleNumber(this Ordering o)
    {
        return o.PageNumbers[o.PageNumbers.Count / 2];
    }

    internal static IEnumerable<Rules> ParseRules(this string input) =>
        input
            .Lines()
            .Select(TryParseAsRules)
            .OfType<Rules>();

    internal static Rules? TryParseAsRules(this string line)
    {
        var split = line.Split('|');
        if (split.Length < 2) return null;
        return new Rules(split.Select(int.Parse).ToList());
    }

    internal static IEnumerable<Ordering> ParseOrdering(this string input) =>
        input
            .Lines()
            .Select(TryParseAsOrdering)
            .OfType<Ordering>();

    internal static Ordering? TryParseAsOrdering(this string line)
    {
        var split = line.Split(',');
        if (split.Length < 2) return null;
        return new Ordering(split.Select(int.Parse).ToList());
    }

    internal static bool Matches(this Ordering ordering, IEnumerable<Rules> rules)
    {
        return rules.All(ordering.Matches);
    }

    internal static bool Matches(this Ordering ordering, Rules rules)
    {
        int prev = -1;
        foreach (var pn in rules.RequiredOrdering)
        {
            var index = ordering.PageNumbers.IndexOf(pn);
            if (index == -1)
                continue;
            if (index < prev)
                return false;
            prev = index;
        }

        return true;
    }

}