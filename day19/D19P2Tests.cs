using FluentAssertions;
using Xunit;

namespace day19;

public class D19P2Tests
{
    [Fact]
    internal static void Testjes()
    {
        var towels = Input.ExampleInput.ParseTowels().ToList();
        towels.Should().HaveCount(8);
        new Pattern("brbr").FindGuaranteedStartString(towels).Should().Be("0");
        new Pattern("gbgb").FindGuaranteedStartString(towels).Should().Be("0,2");
        /*
        string.Join(',',
                Input.ExampleInput.ParsePatterns()
                    .CanBeMade2(towels)).Should()
            .NotBe("2,1,4,6,0,1,2,0");

        new Pattern("b").CanBeMade2(towels).Should().Be(1);
        new Pattern("br").CanBeMade2(towels).Should().Be(2);
        new Pattern("gb").CanBeMade2(towels).Should().Be(2);
        */
        new Pattern("gbgb").CountOptions(towels).Should().Be(4);
        //new Pattern("brbr").CountOptions(towels).Should().Be(4);

        new Pattern("brwrr").CountOptions(towels).Should().Be(2);
        new Pattern("bggr").CountOptions(towels).Should().Be(1);
        new Pattern("gbbr").CountOptions(towels).Should().Be(4);
        new Pattern("rrbgbr").CountOptions(towels).Should().Be(6);
        new Pattern("bwurrg").CountOptions(towels).Should().Be(1);
        new Pattern("brgr").CountOptions(towels).Should().Be(2);
        new Pattern("ubwu").CountOptions(towels).Should().Be(0);
        new Pattern("bbrgwb").CountOptions(towels).Should().Be(0);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 16;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 624802218898092L;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}