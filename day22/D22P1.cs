using shared;

namespace day22;

public static class D22P1
{
    public static object Part1Answer(this string input)
    {
        var secrets =
            input.NotEmptyTrimmedLines()
                .Select(long.Parse)
                .ToList();
        return secrets.Select(s => s.Next(2000)).Sum();
    }

    internal static long Next(this long s, int n)
    {
        return Enumerable.Range(0, n).Aggregate(s, (a, _) => a.Next());
    }

    internal static long Next(this long s)
    {
        long s1 = (s ^ (s * 64)) % 16777216;
        long s2 = (s1 ^ (s1 / 32)) % 16777216;
        long s3 = (s2 ^ (s2 * 2048)) % 16777216;
        return s3;
    }
};
