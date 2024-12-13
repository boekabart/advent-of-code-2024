using FluentAssertions;
using Xunit;

namespace day13;

public static class D13P1Tests
{
    [Fact]
    internal static void ParseInputLineTest1()
    {
        var cases = Input.ExampleInput.ParseThings().ToArray();
        var case1 = cases[0];
        var case2 = cases[1];
        var case3 = cases[2];
        var case4 = cases[3];
        case1.AsResult().Should().Be(280);
        case2.AsResult().Should().Be(0);//impossible
        case3.AsResult().Should().Be(200);
        case4.AsResult().Should().Be(0);//impossible
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
        var expected = 480;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 29598;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
