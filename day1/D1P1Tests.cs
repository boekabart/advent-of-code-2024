using FluentAssertions;
using Xunit;

namespace day1;

public static class D1P1Tests
{
    [Fact]
    internal static void ParseInputLineTest()
    {
        "3    4".TryParseAsThing().Should().Be(new Thing(3, 4));
        "6 \t11".TryParseAsThing().Should().Be(new Thing(6, 11));
        " 26 1  ".TryParseAsThing().Should().Be(new Thing(26, 1));
        "".TryParseAsThing().Should().BeNull();
        "  ".TryParseAsThing().Should().BeNull();
    }

    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseThings().ToArray();
        things.Should().HaveCount(6);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 11;
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
