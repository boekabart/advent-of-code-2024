using FluentAssertions;
using Xunit;

namespace day7;

public static class D7P1Tests
{
    [Fact]
    internal static void ParseInputLineTest()
    {   
        var actualThing = "190: 10 19".TryParseAsThing();
        actualThing.Answer.Should().Be(190);
        actualThing.Operands.Should().BeEquivalentTo([10,19]);
    }

    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseThings().ToArray();
        things.Should().HaveCount(9);
    }

    [Fact]
    internal static void CaseTests()
    {
        "190: 10 19".TryParseAsThing().AsResult().Should().BeTrue();
        "3267: 81 40 27".TryParseAsThing().AsResult().Should().BeTrue();
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 3749;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1289579105366L;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
