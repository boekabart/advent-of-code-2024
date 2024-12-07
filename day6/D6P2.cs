using static day6.D6P1;

namespace day6;

public static class D6P2
{
    public static object Part2Answer(this string input)
    {
        var map = input.ParseMap();
        var (startPos, startDir) = map.FindStart();
        var dir = startDir;
        var pos = startPos;
        HashSet<Pos> uniqueFreeNextPositions = [];
        while (map.IsInGrid(pos))
        {
            if (pos != startPos)
                uniqueFreeNextPositions.Add(pos);
            var nextPos = pos.Step(dir);
            if (map.IsFree(nextPos))
            {
                pos = nextPos;
                continue;
            }

            dir = dir.RotateRight();
        }

        return uniqueFreeNextPositions.AsParallel().Count(extraBlock => DoesLoop(map, extraBlock, startPos, startDir));
    }

    static bool DoesLoop(Map map, Pos extraBlock, Pos startPos, Dir startDir)
    {
        var (pos, dir) = (startPos, startDir);
        HashSet<(Pos,Dir)> uniqueSituations = [];
        while (map.IsInGrid(pos))
        {
            if (!uniqueSituations.Add((pos, dir)))
                return true;

            var nextPos = pos.Step(dir);
            if (map.IsFree(nextPos) && nextPos != extraBlock)
                pos = nextPos;
            else
                dir = dir.RotateRight();
        }

        return false;
    }

}
