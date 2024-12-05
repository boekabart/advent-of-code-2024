namespace day5;

public static class D5P2
{

    public static object Part2Answer(this string input)
    {
        var rules = input.ParseRules().ToList();
        return input.ParseOrdering()
            .Where(o => !o.Matches(rules))
            .Select(o => o.OrderCorrectly(rules))
            .Select(o => o.MiddleNumber())
            .Sum();
    }

    internal static Ordering OrderCorrectly(this Ordering ordering, List<Rules> rules)
    {
        for (int q = 0; q < rules.Count; q++)
        {
            // If the ordering get fixed, go back through all the rules again
            if (ordering.OrderCorrectly(rules[q]))
                q = -1;
        }

        return ordering;
    }

    internal static bool OrderCorrectly(this Ordering ordering, Rules rules)
    {
        var index1 = ordering.PageNumbers.IndexOf(rules.RequiredOrdering[0]);
        var index2 = ordering.PageNumbers.IndexOf(rules.RequiredOrdering[1]);

        if (index2 < 0 || index1 < index2)
            return false;

        ordering.PageNumbers[index2] = rules.RequiredOrdering[0];
        ordering.PageNumbers[index1] = rules.RequiredOrdering[1];

        return true;
    }
}
