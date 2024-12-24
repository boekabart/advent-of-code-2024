using FluentAssertions;
using Xunit;

namespace day24;

public static class D24P1Tests
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
        var mach = Input.ExampleInput.ParseThings();
        mach.Operations.Should().HaveCount(46);

        mach.GetValue("x00").Should().Be(1);
        mach.GetValue("x04").Should().Be(0);
        mach.GetValue("djm").Should().Be(1);
        mach.GetValue("z03").Should().Be(1);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 2024;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 55114892239566L;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
