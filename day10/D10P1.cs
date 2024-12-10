using System.Collections;
using shared;

namespace day10;

internal record Thing(bool Data);

public static class D10P1
{
    public static object Part1Answer(this string input) =>
        input.ParseMap().Go();

    internal static IEnumerable<Pos> FindAll(this Map map, char q)
    {
        for (int y =0; y<map.Grid.Length; y++)
        for (int x = 0; x < map.Grid[y].Length; x++)
            if (map.Grid[y][x]==q)
                yield return new Pos(x, y);
    }

    internal static int Go(this Map map)
    {
        var mapOfReachableNines = map.Convert(kar => new HashSet<Pos>());
        Queue<Pos> todo = [];
        foreach (var nine in map.FindAll('9'))
        {
            mapOfReachableNines.Get(nine).Add(nine);
            todo.Enqueue(nine);
        }

        while (todo.Count > 0)
        {
            var pos = todo.Dequeue();
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
                int added = 0;
                foreach (var ninePos in ninePositionsToCopy)
                    if (mapOfReachableNines.Get(neighbour).Add(ninePos))
                        added++;
                if (added > 0)
                    todo.Enqueue(neighbour);
            }
        }

        return map.FindAll('0').SelectMany(mapOfReachableNines.Get).Count();
    }

}
