using FluentAssertions;
using shared;
using Xunit;

namespace day12;

public class D12P2Tests
{
    [Fact]
    internal static void CalcFenceCostTest()
    {
        var map = @"
AAAA
BBCD
BBCC
EEEC".ParseMap();
        var regionA = map.FindRegion(new Pos(0, 0));
        regionA.CountSides().Should().Be(4);
        var regionC = map.FindRegion(new Pos(2, 1));
        regionC.CountSides().Should().Be(8);
    }

    [Fact]
    internal static void CalcFenceCostTest2()
    {
        var map = @"
EEEEE
EXXXX
EEEEE
EXXXX
EEEEE".ParseMap();
        var region = map.FindRegion(new Pos(0, 0));
        region.CountSides().Should().Be(12);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 1206;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 865662;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}