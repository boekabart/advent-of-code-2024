﻿using FluentAssertions;
using Xunit;

namespace day4;

public class D4P2Tests
{
    [Fact(Skip = "ToDo")]
    internal static void AcceptanceTest()
    {
        var expected = 42;
        Input.ExampleInput
            .Part2Answer()
            .Should().Be(expected);
    }

    [Fact(Skip = "ToDo")]
    internal static void RegressionTest()
    {
        var expected = 42;
        Input.RawInput
            .Part2Answer()
            .Should().Be(expected);
    }
}