using System.Reflection.Metadata.Ecma335;
using shared;

namespace day2;

internal record Thing(List<int> Levels);

public static class D2P1
{
    public static int Part1Answer(this string input) => input.ParseThings().GetResult();

    internal static IEnumerable<List<int>> ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<List<int>>();

    internal static List<int>? TryParseAsThing(this string line)
    {
        var lijn = line.Split([' '], StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        return lijn.Count > 1 ? lijn : null;
    }

    internal static int GetResult(this IEnumerable<List<int>> things) => things.Select(AsResult).Where(r => r).Count();
    internal static bool AsResult(this List<int> thing)
    {
        int MinDiff = int.MaxValue;
        int MaxDiff = int.MinValue;
        for (int q = 1; q < thing.Count; q++)
        {
            var v1 = thing[q - 1];
            var v2 = thing[q];
            MinDiff = Math.Min(v2 - v1, MinDiff);
            MaxDiff = Math.Max(v2 - v1, MaxDiff);
            if (MaxDiff > 3 || MinDiff < -3)
                return false;
            if (Math.Abs(MinDiff) < 1)
                return false;
            if (MinDiff * MaxDiff < 1)
                return false;
        }

        return true;
    }
}