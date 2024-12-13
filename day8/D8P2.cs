using shared;

namespace day8;

public static class D8P2
{
    public static object Part2Answer(this string input)
    {
        return input.ParseMap()
            .GetAllBuiken2()
            .Count();
    }

    internal static IEnumerable<Pos> GetAllBuiken2(this Map map)
    {
        var sizeY = map.Grid.Length;
        var sizeX = map.Grid[0].Length;

        return map.GetAntennas()
                .GetAllBuiken2(sizeX, sizeY)
                .Where(buik => buik.X >= 0 && buik.X < sizeX && buik.Y >= 0 && buik.Y < sizeY)
            ;
    }

    internal static IEnumerable<Pos> GetAllBuiken2(this IEnumerable<(char Freq, Pos Pos)> antennas, int maxX, int maxY)
    {
        return antennas.SplitByFrequency().SelectMany(
                freq => freq.GetAllPairs().SelectMany(pair => pair.GetBuiken2(maxX, maxY)))
            .Distinct();
    }

    internal static IEnumerable<Pos> GetBuiken2(this (Pos Pos1, Pos Pos2) pair, int maxX, int maxY)
    {
        var dX = pair.Pos2.X - pair.Pos1.X;
        var dY = pair.Pos2.Y - pair.Pos1.Y;

        var ggd = dX.GGD(dY);
        dX /= ggd;
        dY /= ggd;

        for (var n = 0;; n++)
        {
            var pos = new Pos(pair.Pos1.X + n * dX, pair.Pos1.Y + n * dY);
            if (!pos.InGrid(maxX, maxY))
                break;
            yield return pos;
        }
        for (var n = -1; ; n--)
        {
            var pos = new Pos(pair.Pos1.X + n * dX, pair.Pos1.Y + n * dY);
            if (!pos.InGrid(maxX, maxY))
                break;
            yield return pos;
        }

        yield return new(pair.Pos2.X + dX, pair.Pos2.Y + dY);
        yield return new(pair.Pos1.X - dX, pair.Pos1.Y - dY);
    }
}
