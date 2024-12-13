using FluentAssertions;
using shared;

namespace day13;

public static class D13P1
{
    public static object Part1Answer(this string input) =>
        input.ParseThings().GetResult();

    internal static long GetResult(this IEnumerable<Thing> things) => things.Select(AsResult).Sum();

    internal static long AsResult(this Thing thing)
    {
        var (na, nb) = CalcButtonPresses(thing);
        if (na > 100 || nb > 100) return 0;
        return 3 * na + nb;
    }

    internal static (long, long) CalcButtonPresses(this Thing thing, long offset = 0)
    {
        var (a, b, p) = thing;
        long Xp = p.X + offset;
        long Yp = p.Y + offset;

        // na * A.x + nb * B.x = P.x
        // na * A.y + nb * B.y = P.y

        // na * A.x = P.x - nb * B.x 
        // na * A.y = P.y - nb * B.y

        // na = (P.x - nb * B.x) / A.x
        // na = (P.y - nb * B.y) / A.y

        // (P.x - nb * B.x) / A.x = (P.y - nb * B.y) / A.y

        // (P.x - nb * B.X) * A.y = (P.y - nb * B.y) * A.x

        // P.x * A.y - nb * B.X * A.y = P.y * A.x - nb * B.y * A.x

        // nb * B.y * A.x - nb * B.X * A.y = P.y * A.x - P.x * A.y

        // nb * (B.y * A.x - B.X * A.y) = P.y * A.x - P.x * A.y

        // nb = (P.y * A.x - P.x * A.y) / (B.y * A.x - B.X * A.y)

        long nb = (Yp * a.X - a.Y * Xp) / (a.X * (long)b.Y - (long)b.X * a.Y);
        // Note - nb is rounded, so it may not be 'the right answer', in which case one of the next 2 checks will kick out the solutions
        // - the remaining X and Y both must be solvable by a nice number of na

        var xtoBeDoneByA = Xp - nb * b.X;
        if (xtoBeDoneByA % a.X != 0)
            return (0, 0);

        var yToBeDoneByA = Yp - nb * b.Y;
        if (yToBeDoneByA % a.Y != 0)
            return (0, 0);

        // If a *different* number ends up being necessary for X and Y, then it's also not good. Would be a weird coincidence after the above checks though.
        var nax = xtoBeDoneByA / a.X;
        var nay = yToBeDoneByA / a.Y;
        if (nax != nay)
            return (0, 0);

        return (nax, nb);
    }

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
}

internal record Thing(Pos A, Pos B, Pos P);