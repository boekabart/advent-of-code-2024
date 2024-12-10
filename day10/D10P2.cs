using shared;
using System.Collections.Generic;

namespace day10;

public static class D10P2
{
    public static object Part2Answer(this string input) =>
        input.ParseMap().Go2();

    internal static int Go2(this Map map)
    {
        var mapOfReachableNines = map.Convert(kar => new List<Pos>());
        Queue<Pos> todo = [];
        foreach (var nine in map.FindAll('9'))
        {
            mapOfReachableNines.Get(nine).Add(nine);
            todo.Enqueue(nine);
        }

        HashSet<Pos> positionsChecked = [];

        while (todo.Count > 0)
        {
            var pos = todo.Dequeue();
            if (!positionsChecked.Add(pos))
                continue;

            var kar = map.Grid[pos.Y][pos.X];
            if (kar == '0')
                continue;

            var lowerKar = (char)(kar - 1);
            var ninePositionsToCopy = mapOfReachableNines.Get(pos);
            foreach (var neighbour in pos.FourAround())
            {
                var nbKar = map.TryGet(neighbour);
                if (nbKar != lowerKar)
                    continue;
                mapOfReachableNines.Get(neighbour).AddRange(ninePositionsToCopy);
                todo.Enqueue(neighbour);
            }
        }

        return map.FindAll('0').SelectMany(mapOfReachableNines.Get).Count();
    }
}
