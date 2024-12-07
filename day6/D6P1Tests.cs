using FluentAssertions;
using Xunit;

namespace day6;

public static class D6P1Tests
{
    [Fact]
    internal static void DirTest()
    {
        var dir = new D6P1.Dir(0, 1);
        dir.RotateRight().Should().Be(new D6P1.Dir(-1, 0));
        dir.RotateRight().RotateRight().Should().Be(new D6P1.Dir(0, -1));
        dir.RotateRight().RotateRight().RotateRight().RotateRight().Should().Be(dir);
    }
    
    [Fact]
    internal static void ParseInputTest()
    {
        var map = Input.ExampleInput.ParseMap();
        map.IsInGrid(new D6P1.Pos(0, 0)).Should().BeTrue();
        map.IsInGrid(new D6P1.Pos(9, 9)).Should().BeTrue();
        map.IsInGrid(new D6P1.Pos(10, 9)).Should().BeFalse();
        map.IsInGrid(new D6P1.Pos(9, 10)).Should().BeFalse();
        map.IsFree(new D6P1.Pos(9, 10)).Should().BeTrue();
        map.IsFree(new D6P1.Pos(-1, -1)).Should().BeTrue();
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 41;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 4939;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
