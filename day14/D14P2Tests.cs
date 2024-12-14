using FluentAssertions;
using shared;
using Xunit;

namespace day14;

public class D14P2Tests
{
    [Fact]
    internal static void RegressionTest()
    {
        var expected = 8149;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}