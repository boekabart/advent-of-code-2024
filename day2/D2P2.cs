namespace day2;

public static class D2P2
{
    public static int Part2Answer(this string input) => input.ParseThings().GetResult2();

    internal static int GetResult2(this IEnumerable<List<int>> things) =>
        things.Select(AsResult2).Where(r => r).Count();

    internal static bool AsResult2x(this List<int> thing)
    {

        return thing.AsResult() || thing.VariantsWithoutOne().Any(l => l.AsResult());
    }

    internal static bool AsResult2(this List<int> thing) =>
        thing.AsResult2SkipFailing()
        || thing.AsResult2SkipPrevious();
    internal static bool AsResult2SkipFailing(this List<int> thing)
    {
        int MinDiff = int.MaxValue;
        int MaxDiff = int.MinValue;
        var prev = thing[0];
        bool oneRemoved = false;
        for (int q = 1; q < thing.Count; q++)
        {
            var cur = thing[q];
            var newMinDiff = Math.Min(cur - prev, MinDiff);
            var newMaxDiff = Math.Max(cur - prev, MaxDiff);
            if (newMaxDiff > 3 || newMinDiff < -3 || newMinDiff * newMaxDiff < 1)
            {
                if (oneRemoved)
                    return thing[1..].AsResult();
                oneRemoved = true;
                continue;
            }

            prev = cur;
            MinDiff = newMinDiff;
            MaxDiff = newMaxDiff;
        }

        return true;
    }

    internal static bool AsResult2SkipPrevious(this List<int> thing)
    {
        int prevMinDiff = int.MaxValue;
        int prevMaxDiff = int.MinValue;
        int MinDiff = int.MaxValue;
        int MaxDiff = int.MinValue;
        var prev = thing[0];
        var prevPrev = thing[0];
        bool oneRemoved = false;
        for (int q = 1; q < thing.Count; q++)
        {
            var cur = thing[q];
            var newMinDiff = Math.Min(cur - prev, MinDiff);
            var newMaxDiff = Math.Max(cur - prev, MaxDiff);
            if (newMaxDiff > 3 || newMinDiff < -3 || newMinDiff * newMaxDiff < 1)
            {
                if (oneRemoved)
                    return thing[1..].AsResult();
                oneRemoved = true;

                var altMinDiff = Math.Min(cur - prevPrev, prevMinDiff);
                var altMaxDiff = Math.Max(cur - prevPrev, prevMaxDiff);
                if (altMinDiff > 3 || altMinDiff < -3 || altMinDiff * altMaxDiff < 1)
                    continue;

                prev = cur;
                MinDiff = altMinDiff;
                MaxDiff = altMaxDiff;
                continue;
            }

            prevPrev = prev;
            prev = cur;
            prevMinDiff = MinDiff;
            prevMaxDiff = MaxDiff;
            MinDiff = newMinDiff;
            MaxDiff = newMaxDiff;
        }

        return true;
    }

    internal static IEnumerable<List<int>> VariantsWithoutOne(this List<int> input)
    {
        return Enumerable
            .Range(0, input.Count)
            .Select(i => input
                .Take(i)
                .Concat(input.Skip(i+1))
                .ToList());
    }
}
