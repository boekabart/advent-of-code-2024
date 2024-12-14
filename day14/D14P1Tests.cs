using FluentAssertions;
using shared;
using Xunit;

namespace day14;

public static class D14P1Tests
{
    [Fact]
    internal static void ParseInputLineTests()
    {
        var actualThing = "p=0,4 v=3,-3".TryParseAsThing().Should().Be(new Thing(new Pos(0, 4), new Pos(3, -3)));
    }
    [Fact]
    internal static void QuadrantTest()
    {
        var mapSize = new Pos(11, 7);
        new Pos(0, 0).Quadrant(mapSize).Should().Be(1);
        new Pos(4, 2).Quadrant(mapSize).Should().Be(1);
        new Pos(10, 0).Quadrant(mapSize).Should().Be(2);
        new Pos(6, 4).Quadrant(mapSize).Should().Be(4);
        new Pos(10, 6).Quadrant(mapSize).Should().Be(4);
        new Pos(0, 6).Quadrant(mapSize).Should().Be(3);

        new Pos(5, 0).Quadrant(mapSize).Should().Be(0);
        new Pos(5, 6).Quadrant(mapSize).Should().Be(0);
        new Pos(0, 3).Quadrant(mapSize).Should().Be(0);
        new Pos(10, 3).Quadrant(mapSize).Should().Be(0);
        var actualThing = "p=0,4 v=3,-3".TryParseAsThing().Should().Be(new Thing(new Pos(0, 4), new Pos(3, -3)));
    }

    [Fact]
    internal static void RobotTest()
    {
        var mapSize = new Pos(11, 7);
        var robot1 = "p=2,4 v=2,-3".TryParseAsThing()!;
        robot1.AsResult(0, mapSize).Should().Be(new Pos(2, 4));
        robot1.AsResult(5, mapSize).Should().Be(new Pos(1, 3));

        var robots = Input.ExampleInput.ParseThings().Select(r => r.AsResult(100, mapSize));
        robots.Where(r => r.Quadrant(mapSize) == 1).Should().HaveCount(1);
        robots.Where(r => r.Quadrant(mapSize) == 2).Should().HaveCount(3);
        robots.Where(r => r.Quadrant(mapSize) == 3).Should().HaveCount(4);
        robots.Where(r => r.Quadrant(mapSize) == 4).Should().HaveCount(1);
    }

    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseThings().ToArray();
        things.Should().HaveCount(12);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 12;
        Input.ExampleInput
            .Part1Answer(new Pos(11,7))
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 214400550;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
