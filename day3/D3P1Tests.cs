using FluentAssertions;
using Xunit;

namespace day3;

public static class D3P1Tests
{
    [InlineData("",null)]
    [Theory]
    internal static void ParseInputLineTest(string line, Thing? expectedThing)
    {
        var actualThing = line.TryParseAsThing();
        actualThing.Should().Be(expectedThing);
    }

    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseThings().ToArray();
        things.Should().HaveCount(4);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 161;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 161289189;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
