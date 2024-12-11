using FluentAssertions;
using Xunit;

namespace day11;

public static class D11P1Tests
{
    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseInput().ToArray();
        things.Should().HaveCount(2);
    }

    [Fact]
    internal static void IterateTest()
    {
        var things = Input.ExampleInput.ParseInput().ToArray();
        things.Should().HaveCount(2);
        var step1 = things.Iterate().ToList();
        step1.Should().BeEquivalentTo([253000, 1, 7]);
        var step2 = step1.Iterate().ToList();
        step2.Should().BeEquivalentTo([253,0, 2024, 14168]);
        var step3 = step2.Iterate().ToList();
        var step4 = step3.Iterate().ToList();
        var step5 = step4.Iterate().ToList();
        var step6 = step5.Iterate().ToList();
        step6.Should().BeEquivalentTo([2097446912,14168,4048,2,0,2,4,40,48,2024,40,48,80,96,2,8,6,7,6,0,3,2]);   
    }
    [Fact]
    internal static void IterateNTest()
    {
        var things = Input.ExampleInput.ParseInput().ToArray();
        var step6 = things.Iterate(6).ToList();
        step6.Should().BeEquivalentTo([2097446912, 14168, 4048, 2, 0, 2, 4, 40, 48, 2024, 40, 48, 80, 96, 2, 8, 6, 7, 6, 0, 3, 2]);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 55312;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 222461;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
