using FluentAssertions;
using shared;
using Xunit;

namespace day8;

public class D8P2Tests
{
    [Fact]
    internal static void BuikenTest2()
    {
        const string q = @"
T.........
...T......
.#....#...
.........#
..T.......
..........
...#......
.#........
....#.....
..........";
        var map = q.ParseMap();
        map.GetAntennas().Should().HaveCount(3);
        map.GetAntennas().Select(a => a.Pos).ToList().GetAllPairs().Should().HaveCount(3);
        var actual = map.GetAllBuiken2();
        actual.Should().HaveCount(9);
    }

    [Fact]

    internal static void AcceptanceTest()
    {
        var expected = 34;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1134;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}