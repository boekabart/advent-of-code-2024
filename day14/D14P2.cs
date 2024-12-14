using shared;

namespace day14;

public static class D14P2
{
    public static object Part2Answer(this string input)
    {
        var mapSize = new Pos(101, 103);
        int seconds = 0;

        var robots = input.ParseThings().ToArray();

        while (seconds < mapSize.X * mapSize.Y)
        {
            var positions = robots.Select(r => r.AsResult(seconds, mapSize)).ToHashSet();
            var positionsThatMightBeAPeakBecauseTheOneAboveItDoesntExist = positions.Where(p => !positions.Contains(p.Up()));
            var positionsWithAllPositionsToTheBottomLeftAndBottomRightExisting = positionsThatMightBeAPeakBecauseTheOneAboveItDoesntExist
                .Where( p => p.FiveToBottomLeftAndBottomRight().All(positions.Contains));
            if (positionsWithAllPositionsToTheBottomLeftAndBottomRightExisting.Any())
            {
                return seconds;
            }

            seconds++;
        }

        return -1;
    }

    internal static IEnumerable<Pos> FiveToBottomLeftAndBottomRight(this Pos pos) =>
        pos.InDir(new Pos(-1, 1), 4).Concat(pos.InDir(new Pos(1, 1), 4));


    internal static IEnumerable<Pos> InDir(this Pos pos, Pos dir, int count) => Enumerable.Range(1, count).Select(m => pos.Add(dir.Times(m)));
}
