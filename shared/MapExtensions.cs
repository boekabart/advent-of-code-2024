namespace shared;

public static class MapExtensions
{
    public static Pos Left(this Pos pos) => pos with { X = pos.X - 1 };
    public static Pos Up(this Pos pos) => pos with { Y = pos.Y - 1 };
    public static Pos Right(this Pos pos) => pos with { X = pos.X + 1 };
    public static Pos Down(this Pos pos) => pos with { Y = pos.Y + 1 };

    public static IEnumerable<Pos> FourAround(this Pos pos)
    {
        yield return pos.Left();
        yield return pos.Right();
        yield return pos.Up();
        yield return pos.Down();
    }

    public static Map ParseMap(this string input) =>
        input
            .NotEmptyTrimmedLines()
            .AsMap();

    public static Map AsMap(this IEnumerable<string> lines)
    {
        var grid = lines.Select(line => line.ToArray()).ToArray();
        return new Map(grid);
    }

    public static Map<T2> Convert<T1, T2>(this Map<T1> map, Func<T1, T2> mapper) =>
        new(map.Grid.Select(line => line.Select(mapper).ToArray()).ToArray());

    public static T Get<T>(this Map<T> map, Pos pos) => map.Grid[pos.Y][pos.X];
    public static T? TryGet<T>(this Map<T> map, Pos pos) where T : class => map.Contains(pos) ? map.Get(pos) : null;

    public static T? GetOr<T>(this Map<T> map, Pos pos, T? def) where T : struct =>
        map.Contains(pos) ? map.Get(pos) : def;

    public static bool Contains<T>(this Map<T> map, Pos pos) =>
        pos.X >= 0 && pos.X < map.Grid[0].Length && pos.Y >= 0 && pos.Y < map.Grid.Length;

    public static IEnumerable<Pos> FindAll<T>(this Map<T> map, T q)
    {
        for (int y = 0; y < map.Grid.Length; y++)
        for (int x = 0; x < map.Grid[y].Length; x++)
            if (q.Equals(map.Grid[y][x]))
                yield return new Pos(x, y);
    }
}

public record Map<T>(T[][] Grid);

public record Map(char[][] Grid) : Map<char>(Grid);

public record Pos(int X, int Y);
