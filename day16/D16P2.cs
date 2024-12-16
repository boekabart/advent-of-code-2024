using shared;

namespace day16;

public static class D16P2
{
    public static object Part2Answer(this string input)
    {
        var map = input.ParseMap();
        var start = map.FindAll('S').First();
        var end = map.FindAll('E').First();
        var dir = Dir.Right;
        _ = map.FindCheapestPath(start, dir, end, out var goodPositions);
        return goodPositions;
    }
}
