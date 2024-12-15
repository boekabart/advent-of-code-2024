using shared;

namespace day15;


public static class D15P1
{
    public static object Part1Answer(this string input)
    {
        var map = input.ParseMapPart();
        var dirs = input.ParseDirectionsPart();
        var pos = FindRobot(map);
        foreach (var dir in dirs)
        {
            pos = MoveRobot(map, pos, dir);
        }

        return map.Checksum();
    }

    internal static Pos FindRobot(this Map map)
    {
        return map.FindAll('@').First();
    }

    internal static Pos MoveRobot(this Map map, Pos pos, Pos dir)
    {
        var newPos = pos.Add(dir);
        if (TryToFree(map, newPos, dir))
            return newPos;
        return pos;
    }

    internal static bool TryToFree(this Map map, Pos pos, Pos dir)
    {
        var value = map.Get(pos);
        if (value == '#') return false;
        if (value == 'O')
        {
            var newPos = pos.Add(dir);
            if (!TryToFree(map, newPos, dir))
                return false;
            map.Set(newPos, 'O');
            map.Set(pos, ' ');
            return true;
        }

        return true;
    }

    internal static long Checksum(this Map map)
    {
        return map.FindAll('O').Select(Gps).Sum();
    }

    internal static long Gps(this Pos pos)
    {
        return pos.X + 100L * pos.Y;
    }


    internal static Map ParseMapPart(this string input)
    {
        var border = input.IndexOfAny(['v', '<', '>', '^']);
        return input.Substring(0, border).ParseMap();
    }
    internal static IEnumerable<Pos> ParseDirectionsPart(this string input)
    {
        var border = input.IndexOfAny(['v', '<', '>', '^']);
        return input.Substring(border)
            .Select(TryParseAsDirection)
            .OfType<Pos>();
    }

    internal static readonly Pos Up = new Pos(0, -1);
    internal static readonly Pos Down = new Pos(0, 1);
    internal static readonly Pos Left = new Pos(-1,0);
    internal static readonly Pos Right = new Pos(1,0);

    internal static Pos? TryParseAsDirection(this char kar) =>
        kar switch
        {
            '^' => Up,
            'v' => Down,
            '<' => Left,
            '>' => Right,
            _ => null
        };
}