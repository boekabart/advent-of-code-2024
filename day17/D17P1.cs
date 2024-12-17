using System.Collections.Immutable;
using shared;

namespace day17;

internal record State(long[] Program, long IP, long RegA, long RegB, long RegC, ImmutableList<long> Output);

public static class D17P1
{
    public static object Part1Answer(this string input)
    {
        var state = input.ParseThings().AsInitialState();
        state = Run(state);

        return string.Join(",", state.Output);
    }

    internal static State Run(this State state)
    {
        while (!state.Halted())
        {
            state = state.Execute();
        }

        return state;
    }

    internal static bool Halted(this State state) => state.IP >= state.Program.Length;

    internal static State Execute(this State state)
    {
        var instruction = state.Program[state.IP];
        var operand = state.Program[state.IP + 1];
        state = state with { IP = state.IP + 2 };
        return state.ExecuteInstruction(instruction, operand);
    }

    internal static State ExecuteInstruction(this State state, long opcode, long operand)
    {
        return opcode switch
        {
            0 => state.Adv(operand),
            1 => state.Bxl(operand),
            2 => state.Bst(operand),
            3 => state.Jnz(operand),
            4 => state.Bxc(operand),
            5 => state.Out(operand),
            6 => state.Bdv(operand),
            7 => state.Cdv(operand),
            _ => throw new InvalidOperationException()
        };
    }

    internal static State Adv(this State state, long operand) => state with {RegA = state.RegA / (1L<<(int)state.DecodeComboOperand(operand))};
    internal static State Bxl(this State state, long operand) => state with {RegB = state.RegB ^operand};
    internal static State Bst(this State state, long operand) => state with { RegB = state.DecodeComboOperand(operand) % 8 };
    internal static State Jnz(this State state, long operand) => state.RegA == 0 ? state : state with { IP = operand };
    internal static State Bxc(this State state, long _) => state with { RegB = state.RegB ^ state.RegC};
    internal static State Out(this State state, long operand) => state with { Output = state.Output.Add(state.DecodeComboOperand(operand) % 8) };
    internal static State Bdv(this State state, long operand) => state with { RegB = state.RegA / (1L << (int)state.DecodeComboOperand(operand)) };
    internal static State Cdv(this State state, long operand) => state with { RegC = state.RegA / (1L << (int)state.DecodeComboOperand(operand)) };

    internal static long DecodeComboOperand(this State state, long operand)
    {
        return operand switch
        {
            4 => state.RegA,
            5 => state.RegB,
            6 => state.RegC,
            >=0 and <=3 => operand,
            _ => throw new InvalidOperationException(),
        };
    }

    internal static long[][] ParseThings(this string input) =>
        input
            .NotEmptyTrimmedLines()
            .Select(TryParseAsThing)
            .ToArray();

    internal static State AsInitialState(this long[][] input)
    {
        return new State(input[3], 0, input[0][0], input[1][0], input[2][0], []);
    }

    internal static long[] TryParseAsThing(this string line)
    {
        return line.Split([':', ' '], StringSplitOptions.RemoveEmptyEntries)[^1].Split(',').Select(long.Parse).ToArray();
    }
}