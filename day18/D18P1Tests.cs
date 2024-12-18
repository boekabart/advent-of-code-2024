using FluentAssertions;
using Xunit;

namespace day18;

public static class D18P1Tests
{
    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseThings().ToArray();
        things.Should().HaveCount(25);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 22;
        Input.ExampleInput
            .Part1Answer(12)
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 436;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
