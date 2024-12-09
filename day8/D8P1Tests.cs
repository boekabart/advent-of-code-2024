using FluentAssertions;
using Xunit;

namespace day8;

public static class D8P1Tests
{
    [Fact]
    internal static void ParseInputTest()
    {
        var map = Input.ExampleInput.ParseMap();
        map.Grid.Should().HaveCount(12);
        map.Grid.Should().AllSatisfy(line => line.Should().HaveCount(12));
    }

    [Fact]
    internal static void AntennaTest()
    {
        var map = Input.ExampleInput.ParseMap();
        var actual = map.GetAntennas().ToList();
        actual.Should().HaveCount(7);
    }

    [Fact]
    internal static void BuikenTest1()
    {
        const string q = @"
..........
...#......
..........
....a.....
..........
.....a....
..........
......#...
..........
..........";
        var map = q.ParseMap();
        var actual = map.GetAllBuiken();
        actual.Should().HaveCount(2);
    }

    [Fact]
    internal static void BuikenTest2a()
    {
        const string q = @"
..........
...#......
#.........
....a.....
........a.
.....a....
..#.......
......#...
..........
..........";
        var map = q.ParseMap();
        map.GetAntennas().Should().HaveCount(3);
        map.GetAntennas().Select(a => a.Pos).ToList().GetAllPairs().Should().HaveCount(3);
        var actual = map.GetAllBuiken();
        actual.Should().HaveCount(4);
    }

    [Fact]
    internal static void BuikenTest2()
    {
        const string q = @"
..........
...#......
#.........
....a.....
........a.
.....a....
..#.......
......#...
..........
..........";
        var map = q.ParseMap();
        var actual = map.GetAllBuiken();
        actual.Should().HaveCount(4);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 14;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 341;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
