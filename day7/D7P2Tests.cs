using FluentAssertions;
using Xunit;

namespace day7;

public class D7P2Tests
{
    [Fact]
    internal static void OrTests()
    {
        var orr = new Thing(12345, [12, 345]).Orred();
        orr.Answer.Should().Be(12345);
        orr.Operands.Should().BeEquivalentTo([12345]);
    }

    [Fact]
    internal static void TestCases()
    {
        "7290: 6 8 6 15".TryParseAsThing().AsResult2().Should().BeTrue();
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 11387;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 92148721834692L;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}