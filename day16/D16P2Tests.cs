using FluentAssertions;
using Xunit;

namespace day16;

public class D16P2Tests
{
    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 45;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void AcceptanceTest2()
    {
        var expected = 64;
        Input.ExampleInput2
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 679;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}