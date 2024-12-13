using shared;

namespace day13;

public static class D13P2
{
    public static long Part2Answer(this string input) =>
        input.ParseThings().GetResult2();

    internal static long GetResult2(this IEnumerable<Thing> things) => things.Select(AsResult2).Sum();

    internal static long AsResult2(this Thing thing)
    {
        var (na, nb) = thing.CalcButtonPresses(10000000000000);
        return 3 * na + nb;
    }

}
