using FluentAssertions;
using Xunit;

namespace day24;

public class D24P2Tests
{
    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = "z00,z01,z02,z05";
        Input.ExampleInput2
            .Part2Answer((a,b) => a&b, 2)
            .Should().Be(expected);
    }

    [Fact(Skip = "ToDo")]
    internal static void RegressionTest()
    {
        var expected = "witnie";
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}