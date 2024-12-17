using FluentAssertions;
using Xunit;

namespace day17;

public static class D17P1Tests
{
    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseThings().ToArray();
        things.Should().HaveCount(4);
        var state = things.AsInitialState();
        state.RegA.Should().Be(729);
        state.Program.Should().HaveCount(6);
    }

    [Fact]
    internal static void InstructionTests()
    {
        new State([], 0, 5, 0, 0, []).Adv(2).RegA.Should().Be(1);
        new State([], 0, 403, 0, 0, []).Adv(2).RegA.Should().Be(100);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = "4,6,3,5,6,3,5,2,1,0";
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = "6,1,6,4,2,4,7,3,5";
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
