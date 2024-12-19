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
        /*
        string.Join(',',
                Input.ExampleInput.ParsePatterns()
                    .CanBeMade2(towels)).Should()
            .NotBe("2,1,4,6,0,1,2,0");

        new Pattern("b").CanBeMade2(towels).Should().Be(1);
        new Pattern("br").CanBeMade2(towels).Should().Be(2);
        new Pattern("gb").CanBeMade2(towels).Should().Be(2);
        */
        new Pattern("brwrr").CanBeMade2(towels).Should().Be(2);
        new Pattern("bggr").CanBeMade2(towels).Should().Be(1);
        new Pattern("gbbr").CanBeMade2(towels).Should().Be(4);
        new Pattern("rrbgbr").CanBeMade2(towels).Should().Be(6);
        new Pattern("bwurrg").CanBeMade2(towels).Should().Be(1);
        new Pattern("brgr").CanBeMade2(towels).Should().Be(2);
        new Pattern("ubwu").CanBeMade2(towels).Should().Be(0);
        new Pattern("bbrgwb").CanBeMade2(towels).Should().Be(0);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 16;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact(Skip="f")]
    internal static void RegressionTest()
    {
        var expected = 42;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}