using shared;

namespace day24;

public static class D24P2
{
    public static string Part2Answer(this string input, Func<long,long,long>? intendedOperation = null, int pairs = 4)
    {
        intendedOperation ??= (a, b) => a + b;
        var machine = input.ParseThings();
        var xValue = machine.GetCombinedValue("x");
        var yValue = machine.GetCombinedValue("y");
        var expectedZ = intendedOperation(xValue, yValue);
        Console.WriteLine($"Expected output: {expectedZ}");
        while (GetBadOutputPins(machine, expectedZ, out var ShouldBeOne, out var ShouldBeZero))
        {
            if (ShouldBeOne.Count == pairs && ShouldBeZero.Count == pairs)
            {
                Dictionary<string, string> swaps = [];
                foreach (var pr in ShouldBeOne.WithIndex())
                {
                    var one = pr.item;
                    var zero = ShouldBeZero[pr.index];
                    swaps.Add(one, zero);
                    swaps.Add(zero, one);
                }
                machine = machine with { Swaps = swaps };
            }
            else
                break;
        }
        return "";
    }

    private static bool GetBadOutputPins(Machine machine, long expectedZ, out List<string> ShouldBeOne,
        out List<string> ShouldBeZero)
    {
        ShouldBeOne = [];
        ShouldBeZero = [];
        long allZ = 0;
        int bitNo = 0;
        while (true)
        {
            var name = $"z{bitNo:00}";
            if (!machine.Operations.ContainsKey(name))
                break;
            var bit = machine.GetValue(name);
            var expectedBit = (expectedZ >> bitNo) % 2;
            if (expectedBit != bit)
            {
                if (expectedBit != 0) ShouldBeOne.Add(name);
                else ShouldBeZero.Add(name);
            }

            bitNo++;
        }

        return ShouldBeOne.Any() || ShouldBeZero.Any();
    }
}
