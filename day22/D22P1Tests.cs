using FluentAssertions;
using Xunit;

namespace day22;

public static class D22P1Tests
{
    [Fact]
    internal static void ParseInputTest()
    {
        123L.Next().Should().Be(15887950);
        123L.Next().Next().Should().Be(16495136);
        123L.Next(2).Should().Be(16495136);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 37327623;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 12759339434L;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
