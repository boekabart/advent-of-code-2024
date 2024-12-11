namespace day11;

public static class D11P2
{
    public static ulong Part2Answer(this string input)
    {
        var part2Answer = input.ParseInput().GetResult2();
        //Console.WriteLine(D11P1.cache.Count);
        //Console.WriteLine(D11P1.cache.Keys.Select(pair => pair.N).Distinct().Count());
        return part2Answer;
    }

    internal static ulong GetResult2(this IEnumerable<ulong> things) => things
        .Iterate(75);
}
