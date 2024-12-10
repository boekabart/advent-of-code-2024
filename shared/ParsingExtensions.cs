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

    public static Map ParseMap(this string input) =>
        input
            .NotEmptyTrimmedLines()
            .AsMap();

    public static string? NonWhitespace(this string line)
    {
        return string.IsNullOrWhiteSpace(line) ? null : line.Trim();
    }

    public static Map AsMap(this IEnumerable<string> lines)
    {
        var grid = lines.Select(line => line.ToArray()).ToArray();
        return new Map(grid);
    }
}

public record Map(char[][] Grid);
