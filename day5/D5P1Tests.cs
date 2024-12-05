using FluentAssertions;
using Xunit;

namespace day5;

public static class D5P1Tests
{
    [Fact]
    internal static void ParseInputLineTest()
    {
        "12|13".TryParseAsRules().RequiredOrdering.Should().BeEquivalentTo([12,13]);
        "12|11|10".TryParseAsRules().RequiredOrdering.Should().BeEquivalentTo([12, 11,10]);
        "12,12".TryParseAsRules().Should().BeNull();
    }

    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseRules().ToArray();
        things.Should().HaveCount(21);
    }

    [Fact]
    internal static void ParseInputOrderingLineTest()
    {
        "12,13".TryParseAsOrdering().PageNumbers.Should().BeEquivalentTo([12, 13]);
        "12,11,10".TryParseAsOrdering().PageNumbers.Should().BeEquivalentTo([12, 11, 10]);
        "12|12".TryParseAsOrdering().Should().BeNull();
    }

    [Fact]
    internal static void MatchesTest()
    {

    }

    [Fact]
    internal static void ParseInputOrderingTest()
    {
        var things = Input.ExampleInput.ParseOrdering().ToArray();
        things.Should().HaveCount(6);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 143;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 5509;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
