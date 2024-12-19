namespace day19;

public static class D19P2
{
    public static object Part2Answer(this string input)
    {
        var towels = input.ParseTowels().ToList();
        return input.ParsePatterns()
            .OrderBy(p => p.Stripes.Length)
            .CanBeMade2(towels).Sum(boel => boel);
    }

    internal static IEnumerable<int> CanBeMade2(this IEnumerable<Pattern> patterns, IEnumerable<Towel> towels)
    {
        Dictionary<string, int> yes = towels.ToDictionary();
        HashSet<string> no = [];
        return patterns.CanBeMade(yes, no);
    }

    internal static Dictionary<string, int> ToDictionary(this IEnumerable<Towel> towels)
    {
        var retval = new Dictionary<string, int>();
        foreach (var t in towels)
        {
            var p = new Pattern(t.Stripes);
            var n = p.CanBeMade2(towels.Where(tw => tw != t));
            retval[t.Stripes] = n + 1;
        }

        return retval;
    }

    internal static int CanBeMade2(this Pattern pattern, IEnumerable<Towel> towels)
    {
        Dictionary<string, int> yes = towels.ToDictionary();
        HashSet<string> no = [];
        return pattern.CanBeMade(yes, no);
    }

    internal static IEnumerable<int> CanBeMade(this IEnumerable<Pattern> pattern, Dictionary<string,int> yes,
        HashSet<string> no)
    {
        return pattern.Select(p => p.CanBeMade(yes, no));
    }

    internal static int CanBeMade(this Pattern pattern, Dictionary<string,int> yes, HashSet<string> no)
    {
        if (yes.TryGetValue(pattern.Stripes, out var k)) return k;
        if (no.Contains(pattern.Stripes)) return 0;
        int n = 0;
        HashSet<string> alreadyChecked = [];
        var toCheck = yes.Keys.OrderBy(kk => kk.Length).ToList();
        while (true)
        {
            if (toCheck.Count == 0) break;

            foreach (var t in toCheck)
            {
                if (pattern.Stripes.StartsWith(t))
                {
                    var subPattern = new Pattern(pattern.Stripes.Substring(t.Length));
                    n += subPattern.CanBeMade(yes, no) * yes[t];
                }

                alreadyChecked.Add(t);
            }

            toCheck = yes.Keys.Except(alreadyChecked).ToList();
        }

        if (n > 0)
        {
            yes.Add(pattern.Stripes, n);
            return n;
        }

        no.Add(pattern.Stripes);
        return 0;
    }
}
