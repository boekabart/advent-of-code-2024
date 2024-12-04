using FluentAssertions;
using Xunit;

namespace day4;

public static class D4P1Tests
{
    [InlineData("",null)]
    [Theory]
    internal static void ParseInputLineTest(string line, string? expectedThing)
    {
        var actualThing = line.TryParseAsThing();
        actualThing.Should().Be(expectedThing);
    }

    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseThings().ToArray();
        things.Should().HaveCount(10);
        things.Should().AllSatisfy(l => l.Length.Should().Be(10));
    }

    [InlineData("XMAS", "SAMX")]
    [Theory]
    internal static void ReverseWordTest(string input, string expected)
    {
        input.Reversed().Should().Be(expected);
    }

    [InlineData("AXMAS", 1)]
    [InlineData("XMAS", 1)]
    [InlineData("AXMASXMASA", 2)]
    [InlineData("AXMASAXMASA", 2)]
    [Theory]
    internal static void CountWordTest(string input, int expected)
    {
        input.CountWords("XMAS").Should().Be(expected);
    }

    [Fact]
    internal static void TransposedTest()
    {
        List<string> x = ["ABC", "123"];
        List<string> expected = ["A1", "B2", "C3"];
        x.Transposed().Should().BeEquivalentTo(expected);
    }

    [Fact]
    internal static void SkewedTest()
    {
        List<string> x = ["ABC", "123"];
        List<string> expected = ["ABC ", " 123"];
        x.Skewed().Should().BeEquivalentTo(expected);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 18;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 2336;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
