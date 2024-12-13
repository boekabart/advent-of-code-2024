using FluentAssertions;
using Xunit;

namespace day13;

public class D13P2Tests
{
    [Fact]
    internal static void RegressionTest()
    {
        var expected = 93217456941970L;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}