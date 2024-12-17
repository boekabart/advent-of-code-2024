namespace day17;

public static class D17P2
{
    public static long Part2Answer(this string input)
    {
        var initialState = input.ParseThings().AsInitialState();

        // This queue contains RegA values that are known to yield N correct output digits (at the tail end).
        Queue<(long RegA, int CorrectOutputDigits)> successfulOutputs = new();

        // We know that 0 is the good RegA that leads to a further 0 digits of correct output.
        successfulOutputs.Enqueue((0,0));

        while(successfulOutputs.Any())
        {
            var (outputRegA, previousOutputLength) = successfulOutputs.Dequeue();

            var lowestRegAToTest = 8 * outputRegA;
            var highestRegAToTest = lowestRegAToTest + 7;

            var expectedOutputLength = previousOutputLength + 1;
            var expectedFirstOutput = initialState.Program[^expectedOutputLength];

            for (long regA = lowestRegAToTest; regA <= highestRegAToTest; regA++)
            {
                var state = initialState with { RegA = regA };

                // Run the program until the end or the first loop, and test that a) the output is what we expect and b) RegA is what we expect too
                //  ( this is the faster alternative than running the whole program again - we already know that with that RegA, the rest of the
                //    output is going to match the tail )
                if (!TestFirstProgramOutput(state, expectedFirstOutput, outputRegA))
                    continue;

                //Console.WriteLine($"==> {regA} leads to an output of {string.Join(",", initialState.Program[^expectedOutputLength..])}");

                // If we've reached the final answer, return it immediately - it's by definition the shortest because of the way we iterate
                if (expectedOutputLength == initialState.Program.Length)
                    return regA;

                // Enqueue this good result for further testing
                successfulOutputs.Enqueue((regA, expectedOutputLength));
            }
        }

        // Only hypothetical programs that never output their own program, end up here
        return -1;
    }

    internal static bool TestFirstProgramOutput(this State state, long expectedOutput, long expectedRegA)
    {
        // Run until jumped to 0 or halted
        do
        {
            state = state.Execute();
        } while (!(state.IP == 0 || state.Halted()));

        return state.Output.Count == 1 && expectedOutput == state.Output[0] && expectedRegA == state.RegA;
    }
}
