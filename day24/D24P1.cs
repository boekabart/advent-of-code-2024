using shared;

namespace day24;


internal record Thing(string Name, Func<Machine, long> Operation);
internal record Machine(Dictionary<string, Func<Machine, long>> Operations);

public static class D24P1
{
    public static object Part1Answer(this string input)
    {
        var machine = input.ParseThings();
        long allZ = 0;
        int bitNo = 0;
        long bitValue = 1;
        while (true)
        {
            var name = $"z{bitNo:00}";
            if (!machine.Operations.ContainsKey(name))
                break;
            var bit = machine.GetValue(name);
            allZ += bit << bitNo;
            bitNo ++;
        }

        return allZ;
    }

    internal static Machine ParseThings(this string input)
    => new Machine(input
            .NotEmptyTrimmedLines()
            .Select(TryParseAsThing)
            .OfType<Thing>()
            .ToDictionary(t => t.Name, t=> t.Operation ));

    internal static Thing? TryParseAsThing(this string line)
    {
        var valLine = line.Split([':', ' '], StringSplitOptions.RemoveEmptyEntries);
        if (valLine.Length == 2)
        {
            var value = long.Parse(valLine[1]);
            return new Thing(valLine[0], _ => value);
        }
        var opLine = line.Split(['-', ' ', '>'], StringSplitOptions.RemoveEmptyEntries);
        if (opLine.Length != 4)
            return null;
        var lhs = opLine[0];
        var rhs = opLine[2];
        var name = opLine[3];
        var op = opLine[1];
        Func<Machine, long> func = op switch
        {
            "XOR" => mach => mach.GetValue(lhs) ^ mach.GetValue(rhs),
            "AND" => mach => mach.GetValue(lhs) & mach.GetValue(rhs),
            "OR" => mach => mach.GetValue(lhs) | mach.GetValue(rhs),
            _ => throw new InvalidOperationException(op)
        };
        return new Thing(name, func);
    }

    internal static long GetValue(this Machine machine, string name)
    {
        return machine.Operations[name](machine);
    }

    internal static int GetResult(this IEnumerable<Thing> things) => things.Select(AsResult).Sum();
    internal static int AsResult(this Thing thing) => 0;
}