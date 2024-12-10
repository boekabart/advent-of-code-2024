using FluentAssertions;
using shared;
using Xunit;

namespace day10;

public class D10P2Tests
{
    [Fact]
    internal static void ExampleOneTest()
    {
        const string ex1 = @"
.....0.
..4321.
..5..2.
..6543.
..7..4. 
..8765.
..9....";
        ex1.ParseMap().Go2().Should().Be(3);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 81;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1110;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}