using FluentAssertions;
using shared;
using Xunit;

namespace day10;

public static class D10P1Tests
{
    [Fact]
    internal static void ParseInputTest()
    {
        const string ex1 = @"
0123
1234
8765
9876";
        var map = ex1.ParseMap();

        map.FindAll('0').Should().BeEquivalentTo([new Pos(0, 0)]);
        map.FindAll('9').Should().BeEquivalentTo([new Pos(0, 3)]);

        map.Go().Should().Be(1);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 36;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 538;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
