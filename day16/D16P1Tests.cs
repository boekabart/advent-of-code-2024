using FluentAssertions;
using Xunit;

namespace day16;

public static class D16P1Tests
{

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 7036;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void AcceptanceTest2()
    {
        var expected = 11048;
        Input.ExampleInput2 
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 115500L;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
