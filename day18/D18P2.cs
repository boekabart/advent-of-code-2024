using shared;

namespace day18;

public static class D18P2
{
    public static Pos Part2Answer(this string input)
    {
        var list = input.ParseThings().ToList();
        int works = 1;
        int doesNotWork = list.Count;
        while (doesNotWork - works > 1)
        {
            var letsTry = (works + doesNotWork) / 2;
            if (list.CalculateShortestPath(letsTry) == -1)
                doesNotWork = letsTry;
            else
                works = letsTry;
        }
        return list[doesNotWork-1];
    }
}
