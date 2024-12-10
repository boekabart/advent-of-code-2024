namespace shared;

public static class ParsingExtensions
{
    public static IEnumerable<string> TrimmedLines(this string multiLineString) =>
        multiLineString.Split(new[] { '\n' })
            .Select(s => s.Trim());

    public static IEnumerable<string> Lines(this string multiLineString) =>
        multiLineString
            .Replace("\r\n", "\n")
            .Split(new[] { '\n' });

    public static IEnumerable<string> NotEmptyLines(this string multiLineString) =>
        multiLineString
            .Lines()
            .Where(s => s.Length > 0);

    public static IEnumerable<string> NotEmptyTrimmedLines(this string multiLineString) =>
        multiLineString
            .TrimmedLines()
            .Where(s => s.Length > 0);

    public static int? AsIntOrNull(this string txt) => int.TryParse(txt, out var number) ? number : null;
    public static int AsInt(this string txt) => int.Parse(txt);

    public static IEnumerable<int?> AsIntsOrNulls(this IEnumerable<string> lines) => lines.Select(AsIntOrNull);
}

public record Map<T>(T[][] Grid);

public record Map(char[][] Grid) : Map<char>(Grid);

public record Pos(int X, int Y);

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
        new Map<T2>(map.Grid.Select(line => line.Select(mapper).ToArray()).ToArray());

    public static T Get<T>(this Map<T> map, Pos pos) => map.Grid[pos.Y][pos.X];
    public static T? TryGet<T>(this Map<T> map, Pos pos) => map.Contains(pos) ? map.Get(pos) : default;

    public static bool Contains<T>(this Map<T> map, Pos pos) =>
        pos.X >= 0 && pos.X < map.Grid[0].Length && pos.Y >= 0 && pos.Y < map.Grid.Length;
}