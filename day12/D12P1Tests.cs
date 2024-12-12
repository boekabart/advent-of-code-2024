using FluentAssertions;
using shared;
using Xunit;

namespace day12;

public static class D12P1Tests
{
    [Fact]
    internal static void FindRegionTest()
    {
        var map = @"
AAAA
BBCD
BBCC
EEEC".ParseMap();
        var region = map.FindRegion(new Pos(0, 0));
        region.Count.Should().Be(4);
    }

    [Fact]
    internal static void FindRegionTest2()
    {
        var map = @"
    OOOOO
OXOXO
OOOOO
OXOXO
OOOOO".ParseMap();
        var region = map.FindRegion(new Pos(0, 0));
        region.Count.Should().Be(21);
    }

    [Fact]
    internal static void FindRegionsTest()
    {
        var map = @"
AAAA
BBCD
BBCC
EEEC".ParseMap();
        var regions = map.GetRegions();
        regions.Should().HaveCount(5);
    }

    [Fact]
    internal static void FindRegionsTest2()
    {
        var map = @"
OOOOO
OXOXO
OOOOO
OXOXO
OOOOO".ParseMap();
        var regions = map.GetRegions();
        regions.Should().HaveCount(5);
    }

    [Fact]
    internal static void CalcFenceCostTest()
    {
        var map = @"
AAAA
BBCD
BBCC
EEEC".ParseMap();
        var region = map.FindRegion(new Pos(0, 0));

        new Region('A', region).CalcFenceCost().Should().Be(4 * 10);
    }

    [Fact]
    internal static void CalcFenceCostTest2()
    {
        var map = @"
    OOOOO
OXOXO
OOOOO
OXOXO
OOOOO".ParseMap();
        var region = map.FindRegion(new Pos(0, 0));
        new Region('A', region).CalcFenceCost().Should().Be(756);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 1930;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1450816;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
