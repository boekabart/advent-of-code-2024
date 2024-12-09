using FluentAssertions;
using Xunit;

namespace day9;

public static class D9P1Tests
{
    [Fact]
    internal static void ParseInputTest()
    {
        var diskmap = Input.ExampleInput.ParseThings();
        diskmap.Blocks.Should().HaveCount(42);
        diskmap.Blocks.OfType<long>().Should().HaveCount(28);
        var df = diskmap.Defrag();
        df.Blocks.Skip(28).OfType<long>().Should().HaveCount(0);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 1928;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 6367087064415;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
