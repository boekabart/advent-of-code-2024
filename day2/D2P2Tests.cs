using FluentAssertions;
using Xunit;

namespace day2;

public class D2P2Tests
{
    [Fact]
    internal static void SomeTests()
    {
        "7 6 4 2 1".TryParseAsThing().AsResult2().Should().BeTrue();
        "1 2 7 8 9".TryParseAsThing().AsResult2().Should().BeFalse();
        "9 7 6 2 1".TryParseAsThing().AsResult2().Should().BeFalse();
        "1 3 2 4 5".TryParseAsThing().AsResult2().Should().BeTrue();
        "7 6 4 2 1".TryParseAsThing().AsResult2().Should().BeTrue();
        "1 3 6 7 9".TryParseAsThing().AsResult2().Should().BeTrue();
        "1 3 6 7 99".TryParseAsThing().AsResult2().Should().BeTrue();
    }

    [Fact]
    internal static void SomeTestsMoreComplu()
    {
        //"0 5 6 7 9".TryParseAsThing().AsResult2().Should().BeTrue();
        //"16 15 19 22 23 25".TryParseAsThing().AsResult2().Should().BeTrue();
        " 77 76 74 75 71".TryParseAsThing().AsResult2().Should().BeTrue();
    }

    [Fact]
    internal static void Comparative()
    {
        var lines = Input.RawInput.ParseThings();
        lines.Where(l => l.AsResult2() != l.AsResult2x()).Should().BeEmpty();
    }


    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 4;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 692;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}