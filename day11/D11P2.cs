namespace day11;

public static class D11P2
{
    public static ulong Part2Answer(this string input) =>
        input.ParseInput().GetResult2();

    internal static ulong GetResult2(this IEnumerable<ulong> things) => things
        .Iterate(75);
}
