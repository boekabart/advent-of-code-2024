using FluentAssertions;
using Xunit;

namespace day11;

public class D11P2Tests
{
    [Fact]
    internal static void IterateNTest()
    {
        var things = Input.ExampleInput.ParseInput().ToArray();
        var step1 = things.Iterate(1);
        step1.Should().Be(3);
        var step6 = things.Iterate(6);
        step6.Should().Be(22);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 55312UL;
        Input.ExampleInput
            .ParseInput()
            .Iterate(25)
            .Should().Be(expected);
    }

    [Fact]
    internal static void AcceptanceTest2()
    {
        var expected = 222461UL;
        Input.RawInput
            .ParseInput()
            .Iterate(25)
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 264_350_935_776_416UL;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}