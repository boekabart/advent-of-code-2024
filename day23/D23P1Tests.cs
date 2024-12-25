using FluentAssertions;
using Xunit;

namespace day23;

public static class D23P1Tests
{
    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseThings().ToArray();
        things.Should().HaveCount(32);
    }

    [Fact]
    internal static void FindTripletsTest()
    {
        var things = Input.ExampleInput.ParseThings().ToList();
        var triplets = things.FindTriplets();
        triplets.Should().HaveCount(12);
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 7;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1054;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
