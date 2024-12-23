using FluentAssertions;
using Xunit;

namespace day22;

public class D22P2Tests
{
    [Fact]
    internal static void RP()
    {
        123L.FirstSeqs(4).First().Key.Should().Be(new Seq(-3, 6, -1, -1));
        123L.FirstSeqs(10)[new Seq(2, -2, 0, -2)].Should().Be(2);
        123L.FirstSeqs(10)[new Seq(-1,-1,0,2)].Should().Be(6);

    }


    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 23;
        Input.ExampleInput2
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1405;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}