using shared;

namespace day12;

public static class D12P2
{
    public static object Part2Answer(this string input) =>
        input.ParseMap().GetResult2();


    internal static int GetResult2(this Map map)
    {
        var regions = map.GetRegions();
        return regions.Sum(CalcFenceCost2);

    }

    internal static int CalcFenceCost2(this Region region)
    {
        var area = region.Locations.Count;
        var sides = region.CountSides();
        return area * sides;
    }

    internal static int CountSides(this Region region)
    {
        return region.CountSides(p => p.Up())
               + region.CountSides(p => p.Down())
               + region.CountSides(p => p.Left())
               + region.CountSides(p => p.Right());
    }

    internal static int CountSides(this Region region, Func<Pos, Pos> dirToCheck)
    {
        var positionsOutsideRegionInThisDir = region
            .Locations
            .Select(dirToCheck)
            .Where(up => !region.Locations.Contains(up))
            .ToHashSet();
        return positionsOutsideRegionInThisDir.CountContiguousGroups();
    }

    internal static int CountContiguousGroups(this HashSet<Pos> allPositions)
    {
        HashSet<Pos> alreadyGrouped = [];
        int contiguousGroups = 0;
        foreach (var pos in allPositions)
        {
            if (alreadyGrouped.Contains(pos))
                continue;

            contiguousGroups++;

            Stack<Pos> toCheck = [];
            toCheck.Push(pos);
            while (toCheck.Count > 0)
            {
                var p = toCheck.Pop();
                if (!alreadyGrouped.Add(p))
                    continue;
                foreach (var neighbour in p.FourAround().Where(allPositions.Contains))
                    toCheck.Push(neighbour);
            }
        }

        return contiguousGroups;
    }
}
