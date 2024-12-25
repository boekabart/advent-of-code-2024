using shared;

namespace day25;

internal record Lock(int[] Heights);
internal record Key(int[] Heights);

public static class D25P1
{
    public static object Part1Answer(this string input)
    {
        var keys = input.ParseKeys().ToList();
        var locks = input.ParseLocks().ToList();
        int ok = 0;
        foreach (var k in keys)
            foreach (var l in locks)
                if (k.FitsWithoutOverlap(l))
                    ok++;
        return ok;
    }

    internal static IEnumerable<Lock> ParseLocks(this string input) =>
        input
            .NotEmptyTrimmedLines()
            .Buffer(7)
            .Select(TryParseAsLock)
            .OfType<Lock>();

    internal static Lock? TryParseAsLock(this string[] line)
    {
        if (line[0][0] != '#') return null;
        return new Lock(line.Transposed().Select(l => l.IndexOf('.') - 1).ToArray());
    }

    internal static IEnumerable<Key> ParseKeys(this string input) =>
        input
            .NotEmptyTrimmedLines()
            .Buffer(7)
            .Select(TryParseAsKey)
            .OfType<Key>();

    internal static Key? TryParseAsKey(this string[] line)
    {
        if (line[0][0] != '.') return null;
        return new Key(line.Transposed().Select(l => 6 - l.IndexOf('#')).ToArray());
    }

    //internal static Lock GetLockFor(this Key key) => new Lock(key.Heights.Select(h => 5 - h).ToArray());

    internal static bool FitsWithoutOverlap(this Key key, Lock lok) =>
        key.Heights.Zip(lok.Heights).All(pr => pr.First + pr.Second <= 5);

    internal static int GetResult(this IEnumerable<Lock> things) => things.Select(AsResult).Sum();
    internal static int AsResult(this Lock thing) => 0;

    internal static IEnumerable<string> Transposed(this IList<string> grid)
    {
        for (int col = 0; col < grid.Max(l => l.Length); col++)
        {
            yield return string.Join("", grid.Select(l => l[col]));
        }
    }
}