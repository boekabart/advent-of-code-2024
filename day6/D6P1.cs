using shared;

namespace day6;


public static class D6P1
{
    public record Pos(int X, int Y);
    public record Dir(int dX, int dY);

    private static List<Dir> dirs = [new Dir(0, -1), new Dir(1, 0), new Dir(0, 1), new Dir(-1, 0)];
    public static Dir RotateRight(this Dir dir) => dirs[(dirs.IndexOf(dir) + 1) % dirs.Count];

    public static Pos Step(this Pos pos, Dir dir) => new Pos(pos.X + dir.dX, pos.Y + dir.dY);

    public class Map(char[][] Grid)
    {
        public char GetValue(Pos pos) => Grid[pos.Y][pos.X];
        public bool IsFree(Pos pos) => !IsInGrid(pos) || GetValue(pos) != '#';
        public bool IsInGrid(Pos pos) => pos is { X: >= 0, Y: >= 0 } && pos.X < Grid[0].Length && pos.Y<Grid.Length;

        public (Pos, Dir) FindStart()
        {
            for (int y =0; y < Grid.Length; y++)
            for (int x = 0; x < Grid[0].Length; x++)
            {
                if (Grid[y][x] == '^') return (new Pos(x, y), dirs[0]);
                if (Grid[y][x] == '>') return (new Pos(x, y), dirs[1]);
                if (Grid[y][x] == 'v') return (new Pos(x, y), dirs[2]);
                if (Grid[y][x] == '<') return (new Pos(x, y), dirs[3]);
            }

            throw new InvalidOperationException();
        }
    }

    public static object Part1Answer(this string input)
    {
        var map = input.ParseMap();
        var (pos, dir) = map.FindStart();
        HashSet<Pos> uniquePositions = [];
        while (map.IsInGrid(pos))
        {
            uniquePositions.Add(pos);
            var nextPos = pos.Step(dir);
            if (map.IsFree(nextPos))
            {
                pos = nextPos;
                continue;
            }

            dir = dir.RotateRight();
        }

        return uniquePositions.Count;
    }

    internal static Map ParseMap(this string input) => new Map(
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<string>()
            .Select(s => s.ToArray()).ToArray());

    internal static string? TryParseAsThing(this string line)
    {
        return string.IsNullOrWhiteSpace(line)?null:line;
    }
}