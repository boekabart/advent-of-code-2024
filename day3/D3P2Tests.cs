using FluentAssertions;
using Xunit;

namespace day3;

public class D3P2Tests
{
    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 48;
        Input.ExampleInput2
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 83595109;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}