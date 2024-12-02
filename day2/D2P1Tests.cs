using FluentAssertions;
using Xunit;

namespace day2;

public static class D2P1Tests
{
    [Fact]
    internal static void ParseInputLineTest2()
    {
        "1 2 3".TryParseAsThing()!.Sum().Should().Be(6);
        " 3 79 993 ".TryParseAsThing()!.Sum().Should().Be(3+ 79+ 993);
        "3".TryParseAsThing().Should().BeNull();
        "".TryParseAsThing().Should().BeNull();
        "  ".TryParseAsThing().Should().BeNull();
    }

    [Fact]
    internal static void ParseInputTest()
    {
        var things = Input.ExampleInput.ParseThings().ToArray();
        things.Should().HaveCount(6);
    }

    [Fact]
    internal static void ResultOfOneTest()
    {
        List<int> s = [1,3];
        s.AsResult().Should().BeTrue();
        s = [3, 1];
        s.AsResult().Should().BeTrue();
        s = [4, 0];
        s.AsResult().Should().BeFalse();
        s = [45,47,48,50,51,52,54,51];
        s.AsResult().Should().BeFalse();
        s = [1, 3, 2, 4, 5];
        s.AsResult().Should().BeFalse();
        "9 7 6 2 1".TryParseAsThing().AsResult().Should().BeFalse();
    }

    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 2;
        Input.ExampleInput
            .Part1Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 663;
        Input.RawInput
            .Part1Answer()
            .Should().Be(expected);
    }
}
