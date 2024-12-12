using shared;

namespace day12;

public static class D12P1
{
    public static object Part1Answer(this string input) =>
        input.ParseMap().GetResult();


    internal static int GetResult(this Map map)
    {
        var regions = map.GetRegions();
        return regions.Sum(CalcFenceCost);

    }

    internal static IEnumerable<Region> GetRegions(this Map map)
    {
        HashSet<Pos> alreadyRegionized = [];
        foreach (var pos in map.AllPositions())
        {
            if (alreadyRegionized.Contains(pos))
                continue;
            var region = map.FindRegion(pos);
            yield return region;
            alreadyRegionized.UnionWith(region.Locations);
        }
    }

    internal static Region FindRegion(this Map map, Pos pos)
    {
        var crop = map.Get(pos);
        Stack<Pos> toCheck = [];
        toCheck.Push(pos);
        HashSet<Pos> positions = [];
        while (toCheck.Count > 0)
        {
            var p = toCheck.Pop();
            if (!positions.Add(p))
                continue;
            foreach (var neighbour in p.FourAround().Where(map.Contains).Where(nb => map.Get(nb) == crop))
                toCheck.Push(neighbour);
        }

        return new Region(crop,positions);
    }
        
    internal static int CalcFenceCost(this Region region)
    {
        var area = region.Locations.Count;
        var circum = region.Locations.Sum(loc => loc.FourAround().Count(op => !region.Locations.Contains(op)));
        return area * circum;
    }
}

internal record Region(char Crop, HashSet<Pos> Locations);