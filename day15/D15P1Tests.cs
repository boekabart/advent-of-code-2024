using FluentAssertions;
using Xunit;

namespace day15;

public static class D15P1Tests
{
    [Fact]
    internal static void ParseInputLineTest()
    {
        var actualThing = "".TryParseAsThing();
        actualThing.Should().Be(null);
    }

    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseThings().ToArray();
        things.Should().HaveCount(0);
    }

    [Fact(Skip="ToDo")]
    internal static void AcceptanceTest()
    {
        var expected = 42;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact(Skip = "ToDo")]
    internal static void RegressionTest()
    {
        var expected = 42;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
