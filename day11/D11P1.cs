using shared;

namespace day11;

public static class D11P1
{
    public static object Part1Answer(this string input) =>
        input.ParseInput().GetResult();

    internal static IEnumerable<ulong> ParseInput(this string input) =>
        input
            .NotEmptyTrimmedLines()
            .Single()
            .Split(' ')
            .Select(ulong.Parse);


    internal static ulong GetResult(this IEnumerable<ulong> things) => things
        .Iterate(25);


    internal static ulong Iterate(this IEnumerable<ulong> thing, int n)
        => thing.Aggregate<ulong, ulong>(0, (current, t) => current + NumberOfStonesAfterGenerations(t, n));

    internal static Dictionary<(ulong N, int Gens), ulong> cache = [];

    internal static ulong NumberOfStonesAfterGenerations(this ulong stone, int generations)
    {
        if (generations == 0)
            return 1;
        
        if (cache.TryGetValue((stone, generations), out var cacheValue))
            return cacheValue;

        var arr = ApplyStoneRules(stone);

        ulong answer = arr.Aggregate(0UL, (sum, newStone) => sum + NumberOfStonesAfterGenerations(newStone, generations - 1));

        cache[(stone, generations)] = answer;
        return answer;
    }

    internal static ulong[] ApplyStoneRules(this ulong stone)
    {
        if (stone == 0)
        {
            return [1];
        }

        var str = stone.ToString();
        if (str.Length % 2 == 0)
        {
            var n1 = ulong.Parse(str.Substring(0, str.Length / 2));
            var rhs = str.Substring(str.Length / 2);
            var n2 = ulong.Parse(rhs);
            return [n1, n2];
        }

        return [stone * 2024];
    }

}