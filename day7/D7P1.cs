using shared;
using System.Net.NetworkInformation;

namespace day7;

internal record Thing(long Answer, List<long> Operands);

public static class D7P1
{
    public static object Part1Answer(this string input) =>
        input.ParseThings().GetResult();

    internal static IEnumerable<Thing> ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<Thing>();

    internal static Thing? TryParseAsThing(this string line)
    {
        if (string.IsNullOrWhiteSpace(line)) return null;
        var split = line.Split([':',' '], StringSplitOptions.RemoveEmptyEntries);
        var answer = long.Parse(split[0]);
        var operands = split[1..].Select(long.Parse).ToList();
        return new Thing(answer, operands);
    }

    internal static long GetResult(this IEnumerable<Thing> things) => things.Where(AsResult).Aggregate((long)0, (l,thing) => thing.Answer + l);

    internal static bool AsResult(this Thing thing)
    {
        if (thing.Operands.Count == 1) return thing.Operands[0] == thing.Answer;
        return new Thing(thing.Answer - thing.Operands[^1], thing.Operands[..^1]).AsResult()
               || (thing.Answer % thing.Operands[^1]==0 &&
               new Thing(thing.Answer / thing.Operands[^1], thing.Operands[..^1]).AsResult());
    }
}