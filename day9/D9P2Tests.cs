using FluentAssertions;
using Xunit;

namespace day9;

public class D9P2Tests
{
    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 2858;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 6390781891880;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}