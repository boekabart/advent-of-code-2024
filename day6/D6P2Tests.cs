﻿using FluentAssertions;
using Xunit;

namespace day6;

public class D6P2Tests
{
    [Fact]
    internal static void AcceptanceTest()
    {
        var expected = 6;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact]
    internal static void RegressionTest()
    {
        var expected = 1434;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}