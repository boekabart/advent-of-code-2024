using shared;

namespace day8;

internal record Pos(int X, int Y);

public static class D8P1
{
    public static int Part1Answer(this string input) 
    {
        return input.ParseMap()
            .GetAllBuiken()
            .Count();
    }

    //internal static int GetResult(this Map things) => things.Select(AsResult).Sum();

    internal static IEnumerable<(char Freq, Pos Pos)> GetAntennas(this Map map)
    {
        for (int y = 0; y < map.Grid.Length; y++)
        for (int x = 0; x < map.Grid[y].Length; x++)
        {
            var kar = map.Grid[y][x];
            if (IsFreq(kar))
                yield return (kar, new(x, y));
        }
    }

    internal static IEnumerable<Pos> GetAllBuiken(this Map map)
    {
        var sizeY = map.Grid.Length;
        var sizeX = map.Grid[0].Length;

        return map.GetAntennas()
                .GetAllBuiken()
                .Where(pos => pos.InGrid(sizeX, sizeY))
            ;
    }

    internal static bool InGrid(this Pos pos, int sizeX, int sizeY) =>
        pos.X >= 0 && pos.X < sizeX && pos.Y >= 0 && pos.Y < sizeY;

    internal static IEnumerable<Pos> GetAllBuiken(this IEnumerable<(char Freq, Pos Pos)> antennas)
    {
        return antennas.SplitByFrequency().SelectMany(
                freq => freq.GetAllPairs().SelectMany(pair => pair.GetBuiken()))
            .Distinct();
    }


    internal static IEnumerable<List<Pos>> SplitByFrequency(this IEnumerable<(char Freq, Pos Pos)> antennas)
    {
        return antennas
            .GroupBy( a => a.Freq ).Select(gr => gr.Select(a => a.Pos).ToList());
    }

    internal static IEnumerable<(Pos Pos1, Pos Pos2)> GetAllPairs(this IList<Pos> positions)
    {
        for (var one = 0; one < positions.Count -1; one++)
        for (var two = one+1; two < positions.Count; two++)
            yield return (positions[one], positions[two]);
    }

    internal static IEnumerable<Pos> GetBuiken(this (Pos Pos1, Pos Pos2) pair)
    {
        var dX = pair.Pos2.X - pair.Pos1.X;
        var dY = pair.Pos2.Y - pair.Pos1.Y;
        yield return new(pair.Pos2.X + dX, pair.Pos2.Y + dY);
        yield return new(pair.Pos1.X - dX, pair.Pos1.Y - dY);
    }

    internal static bool  IsFreq(this char kar)
    {
        return kar is >= '0' and <= '9' or >= 'A' and <= 'Z' or >= 'a' and <= 'z';
    }
}