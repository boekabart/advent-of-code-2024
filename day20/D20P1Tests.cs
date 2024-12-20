using FluentAssertions;
using Xunit;

namespace day20;

public static class D20P1Tests
{
    [Fact]
    internal static void ParseInputTest()
    {
        Input.ExampleInput.Part1Answer(64).Should().Be(1);
        Input.ExampleInput.Part1Answer(40).Should().Be(2);
        Input.ExampleInput.Part1Answer(20).Should().Be(5);
        Input.ExampleInput.Part1Answer(12).Should().Be(8);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 14;
        Input.ExampleInput
            .Part1Answer(8)
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1358;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
