using FluentAssertions;
using Xunit;

namespace day20;

public class D20P2Tests
{
    [Fact]
    internal static void ParseInputTest()
    {
        Input.ExampleInput.Part2Answer(77).Should().Be(0);
        Input.ExampleInput.Part2Answer(76).Should().Be(3);
        Input.ExampleInput.Part2Answer(74).Should().Be(7);
        Input.ExampleInput.Part2Answer(74).Should().Be(7);
        Input.ExampleInput.Part2Answer(70).Should().Be(41);
        Input.ExampleInput.Part2Answer(68).Should().Be(41+14);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 41;
        Input.ExampleInput
            .Part2Answer(70)
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1005856;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}