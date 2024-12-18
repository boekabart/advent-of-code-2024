using FluentAssertions;
using shared;
using Xunit;

namespace day18;

public class D18P2Tests
{
    [Fact]
    internal static void OneOneShouldFindPath()
    {
        var list = Input.ExampleInput.ParseThings().ToList();
        var actual = list.CalculateShortestPath(20);
        actual.Should().NotBe(-1);
    }

    [Fact]
    internal static void SixOneShouldNotFindPath()
    {
        var list = Input.ExampleInput.ParseThings().ToList();
        var actual = list.CalculateShortestPath(21);
        actual.Should().Be(-1);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = new Pos(6,1);
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = new Pos(61, 50);
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}