using FluentAssertions;
using Xunit;

namespace day25;

public static class D25P1Tests
{
    [Fact]
    internal static void ParseLocksTest()
    {
        var things = Input.ExampleInput.ParseLocks().ToArray();
        things.Should().HaveCount(2);
        things[0].Heights[0].Should().Be(0);
        things[0].Heights[1].Should().Be(5);
    }

    [Fact]
    internal static void ParseKeysTest()
    {
        var things = Input.ExampleInput.ParseKeys().ToArray();
        things.Should().HaveCount(3);
        things[0].Heights[0].Should().Be(5);
        things[0].Heights[1].Should().Be(0);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 3;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 2586;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
