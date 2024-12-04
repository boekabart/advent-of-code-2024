using FluentAssertions;
using Xunit;

namespace day4;

public class D4P2Tests
{
    [Fact]
    internal static void Test1()
    {
        var input = @"
M..
.A.
..S
";
        input.Part2Answer().Should().Be(0);
    }

    [Fact]
    internal static void Test2()
    {
        var input = @"
.....
..S.M
...A.
..S.M
";
        input.Part2Answer().Should().Be(1);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 9;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1831;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}