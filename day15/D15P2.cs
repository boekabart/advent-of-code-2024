using FluentAssertions;
using shared;

namespace day15;

public static class D15P2
{
    public static object Part2Answer(this string input)
    {
        var map = input.ParseMapPart().Stretch();
        var dirs = input.ParseDirectionsPart();
        var pos = map.FindRobot();
        foreach (var dir in dirs)
        {
            //var before = map.DumpMap();
            var newPos = map.MoveRobot2(pos, dir);
            /*
            if (!CheckMap(map))
            {
                Console.WriteLine($"After moving from {pos} in {dir} to {newPos}, map wasn't ok");
                Console.WriteLine(before);
                Console.WriteLine(map.DumpMap());
                return 0;
            }//*/

            pos = newPos;
        }
        Console.WriteLine(map.DumpMap());
        return map.Checksum2();

    }

    internal static string DumpMap(this Map map)
    {
        return string.Join(Environment.NewLine, map.Grid.Select(l => string.Join("", l)));
    }

    internal static bool CheckMap(this Map map)
    {
        var leftBoxes = map.FindAll('[');
        if (leftBoxes.Any(lb => map.Get(lb.Add(D15P1.Right)) != ']'))
            return false;
        var rightBoxes = map.FindAll(']');
        if (rightBoxes.Any(lb => map.Get(lb.Add(D15P1.Left)) != '['))
            return false;
        return true;
    }

    public static Map Stretch(this Map map)
    {
        var s = map.StretchConvert<char, char>(c => c switch
        {
            '#' => ['#', '#'],
            'O' => ['[', ']'],
            '@' => ['@', '.'],
            _ => ['.', '.'],
        });
        return new Map(s.Grid);
    }
    internal static Pos MoveRobot2(this Map map, Pos pos, Pos dir)
    {
        var newPos = pos.Add(dir);
        if (TryToFree2(map, newPos, dir))
        {
            DoFree(map, pos, dir);
            return newPos;
        }
        return pos;
    }

    internal static bool TryToFree2(this Map map, Pos pos, Pos dir)
    {
        var value = map.Get(pos);
        if (!map.CanFree2(pos, dir, true))
            return false;

        if (value == '[')
        {
            map.DoFree(pos.Add(D15P1.Right), dir);
        }
        if (value == ']')
        {
            map.DoFree(pos.Add(D15P1.Left), dir);
        }

        map.DoFree(pos, dir);
        return true;
    }

    internal static void DoFree(this Map map, Pos pos, Pos dir)
    {
        var value = map.Get(pos);
        if (value == '#')
            throw new InvalidOperationException();
        if (value == '.')
            return;

        var newPos = pos.Add(dir);
        TryToFree2(map, newPos, dir);
        map.Set(newPos, value);
        map.Set(pos, '.');
    }


    internal static bool CanFree2(this Map map, Pos pos, Pos dir, bool checkBetterHalf)
    {
        var value = map.Get(pos);
        if (value == '#')
            return false;
        if (value == '@')
            return true;
        if (value == '.')
            return true;
        if (value == '[' || value == ']')
        {
            var newPos = pos.Add(dir);
            if (!CanFree2(map, newPos, dir, true))
                return false;
            if (checkBetterHalf)
            {
                var bhDir = value == '[' ? D15P1.Right : D15P1.Left;
                if (bhDir == dir.Times(-1))
                    return true;
                var bhp = pos.Add(bhDir);
                return map.CanFree2(bhp, dir, false);
            }
            return true;
        }

        return true;
    }

    internal static long Checksum2(this Map map)
    {
        return map.FindAll('[').Select(D15P1.Gps).Sum();
    }


}