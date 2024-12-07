namespace day7;

public static class D7P2
{
    public static object Part2Answer(this string input) =>
        input.ParseThings().GetResult2();
    internal static long GetResult2(this IEnumerable<Thing> things) => things.Where(AsResult2).Aggregate((long)0, (l, thing) => thing.Answer + l);

    internal static bool AsResult2(this Thing thing)
    {
        if (thing.Operands.Count == 1) return thing.Operands[0] == thing.Answer;
        return thing.Plussed().AsResult2()
               || thing.Multiplied().AsResult2()
        || thing.Orred().AsResult2();
    }

    internal static Thing Orred(this Thing thing)
    {
        return thing.Modified((a, b) => long.Parse(a.ToString() + b));
    }
    internal static Thing Plussed(this Thing thing)
    {
        return thing.Modified((a, b) => a+b);
    }
    internal static Thing Multiplied(this Thing thing)
    {
        return thing.Modified((a, b) => a*b);
    }

    internal static Thing Modified(this Thing thing, Func<long, long, long> op)
    {
        var first = thing.Operands[0];
        var second = thing.Operands[1];
        var newFirst = op(first, second);
        return thing with { Operands = thing.Operands.Skip(2).Prepend(newFirst).ToList() };
    }
}
