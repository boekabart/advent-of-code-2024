using FluentAssertions;
using Xunit;

namespace day11;

public static class D11P1Tests
{
    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseInput().ToArray();
        things.Should().HaveCount(2);
    }


    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 55312;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 222461;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
