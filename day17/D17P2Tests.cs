using FluentAssertions;
using Xunit;

namespace day17;

public class D17P2Tests
{
    [Fact]
    internal static void Test()
    {
        var state = Input.ExampleInputPart2.ParseThings().AsInitialState() with { RegA = 117440 };
        state.TestFirstProgramOutput(state.Program[0], 14680).Should().BeTrue();
    }

    [Fact]
    internal static void Test0()
    {
        var actualProgram = Input.ExampleInputPart2.ParseThings().AsInitialState();
        (actualProgram with { RegA = 1 }).Run().Output[0].Should().Be(0);
        (actualProgram with { RegA = 2 }).Run().Output[0].Should().Be(0);
        (actualProgram with { RegA = 3 }).Run().Output[0].Should().Be(0);
        (actualProgram with { RegA = 4 }).Run().Output[0].Should().Be(0);
        (actualProgram with { RegA = 5 }).Run().Output[0].Should().Be(0);
        (actualProgram with { RegA = 6 }).Run().Output[0].Should().Be(0);
        (actualProgram with { RegA = 7 }).Run().Output[0].Should().Be(0);
        (actualProgram with { RegA = 3 * 8 + 4 }).Run().Output.Should().BeEquivalentTo([3, 0]);
        (actualProgram with { RegA = 3 * 8 + 1 }).Run().Output.Should().BeEquivalentTo([3, 0]);
        (actualProgram with { RegA = 3 * 8 + 2 }).Run().Output.Should().BeEquivalentTo([3, 0]);
        (actualProgram with { RegA = 3 * 8 + 3 }).Run().Output.Should().BeEquivalentTo([3, 0]);
        (actualProgram with { RegA = 3 * 8 + 4 }).Run().Output.Should().BeEquivalentTo([3, 0]);
        (actualProgram with { RegA = 3 * 8 + 5 }).Run().Output.Should().BeEquivalentTo([3, 0]);
        (actualProgram with { RegA = 3 * 8 + 6 }).Run().Output.Should().BeEquivalentTo([3, 0]);
        (actualProgram with { RegA = 3 * 8 + 7 }).Run().Output.Should().BeEquivalentTo([3, 0]);
        (actualProgram with { RegA = 229 }).Run().Output.Should().BeEquivalentTo([4, 3, 0]);
    }

    [Fact]
    internal static void Test1()
    {
        var actualProgram = Input.RawInput.ParseThings().AsInitialState();
        (actualProgram with { RegA = 1 }).Run().Output[0].Should().Be(5);
        (actualProgram with { RegA = 2 }).Run().Output[0].Should().Be(7);
        (actualProgram with { RegA = 3 }).Run().Output[0].Should().Be(6);
        (actualProgram with { RegA = 4 }).Run().Output[0].Should().Be(1);
        (actualProgram with { RegA = 5 }).Run().Output[0].Should().Be(0); //This
        (actualProgram with { RegA = 6 }).Run().Output[0].Should().Be(3);
        (actualProgram with { RegA = 7 }).Run().Output[0].Should().Be(2);
        (actualProgram with { RegA = 5*8+6 }).Run().Output.Should().BeEquivalentTo([3,0]); //This
        (actualProgram with { RegA = (5 * 8 + 6) * 8 + 1 }).Run().Output.Should().BeEquivalentTo([5, 3, 0]); // This
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 117440;
        Input.ExampleInputPart2
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 202975183645226L;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}