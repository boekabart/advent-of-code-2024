using shared;

namespace day13;

internal record Thing(Pos A, Pos B, Pos P);

public static class D13P1
{
    public static object Part1Answer(this string input) =>
        input.ParseThings().GetResult();

    internal static IEnumerable<Thing> ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<Pos>()
            .Buffer(3)
            .Where(b => b.Length==3)
            .Select(l => new Thing(l[0], l[1], l[2]));

    internal static Pos? TryParseAsThing(this string line)
    {
        var split = line.Split([',', '=', '+', ' '], StringSplitOptions.RemoveEmptyEntries);
        return split.Length >= 4 ? new Pos(int.Parse(split[^3]), int.Parse(split[^1])) : null;
    }

    internal static int GetResult(this IEnumerable<Thing> things) => things.Select(AsResult).Sum();
    internal static int AsResult(this Thing thing)
    {
        var (a, b, p) = thing;
        if (100 * (a.X + b.X) < p.X)
        {
            return 0;
        }

        if (100 * (a.Y + b.Y) < p.Y)
        {
            return 0;
        }

        int maxA = Math.Min(p.X / a.X, p.Y / a.Y);
        for (var na = 0; na <= maxA; na++)
        {
            var Xa = na * a.X;
            var Ya = na * a.Y;
            var Xra = p.X - Xa;
            var Yra = p.Y - Ya;
            if (Xra % b.X != 0)
                continue;
            if (Yra % b.Y != 0)
                continue;
            var nbx = Xra / b.X;
            var nby = Yra / b.Y;
            if (nbx == nby)
                return 3 * na + nbx;
        }

        return 0;
    }
}