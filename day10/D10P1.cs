using shared;

namespace day10;


public static class D10P1
{
    public static object Part1Answer(this string input) =>
        input.ParseMap().Go();

    internal static int Go(this Map map)
    {
        var mapOfReachableNines = map.Convert(kar => new HashSet<Pos>());
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
            var lowerNeighbours = pos.FourAround().Where(map.Contains).Where(nb => map.Get(nb)==lowerKar);
            foreach (var neighbour in lowerNeighbours)
            {
                mapOfReachableNines
                    .Get(neighbour)
                    .UnionWith(ninePositionsToCopy);
                todo.Enqueue(neighbour);
            }
        }

        return map.FindAll('0').SelectMany(mapOfReachableNines.Get).Count();
    }
}
