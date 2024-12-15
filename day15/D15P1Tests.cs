using FluentAssertions;
using shared;
using Xunit;

namespace day15;

public static class D15P1Tests
{
    [Fact]
    internal static void ParseInputLineTest()
    {
        var things = Input.ExampleInput2.ParseMapPart();
        things.Grid.Should().HaveCount(10);
        var dirs = Input.ExampleInput2.ParseDirectionsPart().ToList();
        dirs.Should().HaveCount(700);
        dirs[^1].Should().Be(D15P1.Up);
    }

    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseMapPart();
        things.Grid.Should().HaveCount(8);
        var dirs = Input.ExampleInput.ParseDirectionsPart().ToList();
        dirs.Should().HaveCount(15);
        dirs[0].Should().Be(D15P1.Left);
    }

    [Fact]
    internal static void PushTest()
    {
        var map = Input.ExampleInput.ParseMapPart();
        var robot = map.FindRobot();
        map.MoveRobot(robot, D15P1.Left).Should().Be(robot);
        map.MoveRobot(robot, D15P1.Up).Should().NotBe(robot);
        var r2 = map.MoveRobot(robot, D15P1.Right);
            r2.Should().NotBe(robot);
            var r3a = map.MoveRobot(r2, D15P1.Right);
            r3a.Should().NotBe(r2);
            var r3b = map.MoveRobot(r2, D15P1.Up);
            r3b.Should().Be(r2);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 2028;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void AcceptanceTest2()
    {
        var expected = 10092;
        Input.ExampleInput2
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1552463L;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
