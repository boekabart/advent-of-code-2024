using FluentAssertions;
using Xunit;

namespace day19;

public static class D19P1Tests
{

    [Fact]
    internal static void ParseInputTest()
    {
        var towels = Input.ExampleInput.ParseTowels().ToArray();
        towels.Should().HaveCount(8);
        towels[0].Stripes.Should().Be("r");

        var patt = Input.ExampleInput.ParsePatterns().ToArray();
        patt.Should().HaveCount(8);
    }

    [Fact]
    internal static void CanBeMadeTest()
    {
        var towels = Input.ExampleInput.ParseTowels().ToList();
        towels.Should().HaveCount(8);

        new Pattern(towels.Last().Stripes).CanBeMade(towels).Should().BeTrue();

        new Pattern("gekkie").CanBeMade(towels).Should().BeFalse();

        new Pattern("brwrr").CanBeMade(towels).Should().BeTrue();
        new Pattern("rrbgbr").CanBeMade(towels).Should().BeTrue();
        new Pattern("ubwu").CanBeMade(towels).Should().BeFalse();
        new Pattern("bwurrg").CanBeMade(towels).Should().BeTrue();
    }
    [Fact]
    internal static void CanBeMadeTest2()
    {
        var towels = Input.RawInput.ParseTowels().ToList();
        towels.Should().HaveCount(447);
        var patterns = Input.RawInput.ParsePatterns().ToList();
        patterns[0].CanBeMade(towels).Should().BeTrue();
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 6;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 300;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
