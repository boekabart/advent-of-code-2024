using FluentAssertions;
using shared;
using Xunit;

namespace day15;

public class D15P2Tests
{
    [Fact]
    internal static void SmallTest()
    {
        var map = @"
#####
#.O@#
#...#
#####^
".ParseMapPart().Stretch();
        /// ##..[]@.##
        /// ##.[].@.##

        /// ##.[]...##
        /// ##......##
        map.Get(new Pos(0, 1)).Should().Be('#');
        map.Get(new Pos(1, 1)).Should().Be('#');

        var robot = map.FindRobot();
        robot.X.Should().Be(6);
        var r1 = map.MoveRobot2(robot, D15P1.Right);
        r1.Should().NotBe(robot);
        map.MoveRobot2(r1, D15P1.Right).Should().Be(r1);

        map.Get(new Pos(4, 1)).Should().Be('[');
        var l1 = map.MoveRobot2(robot, D15P1.Left);
        l1.Should().NotBe(robot);
        map.Get(new Pos(4, 1)).Should().Be(']');
        map.Get(new Pos(3, 1)).Should().Be('[');

        var l2 = map.MoveRobot2(l1, D15P1.Left);
        l2.Should().NotBe(l1);
        map.Get(new Pos(3, 1)).Should().Be(']');
        map.Get(new Pos(2, 1)).Should().Be('[');
        map.Get(new Pos(1, 1)).Should().Be('#');

        var l3 = map.MoveRobot2(l2, D15P1.Left);
        l3.Should().Be(l2);
        map.Get(new Pos(3, 1)).Should().Be(']');
        map.Get(new Pos(2, 1)).Should().Be('[');

        var leftabove = new Pos(2, 0);
        map.Set(leftabove, '@');
        var d1 = map.MoveRobot2(leftabove, D15P1.Down);
        d1.Should().NotBe(leftabove);
        map.Get(leftabove).Should().Be('.');
        map.Get(new Pos(3, 1)).Should().Be('.');
        map.Get(new Pos(3, 2)).Should().Be(']');
        map.Get(new Pos(2, 2)).Should().Be('[');
        map.Get(new Pos(2, 1)).Should().Be('@');
        var d2 = map.MoveRobot2(d1, D15P1.Down);
        d2.Should().Be(d1);
    }

    [Fact]
    internal static void AcceptanceTest2()
    {
        var expected = 9021;
        Input.ExampleInput2
            .Part2Answer()
            .Should().Be(expected);

    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1554058L;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}