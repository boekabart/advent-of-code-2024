using shared;

namespace day23;

internal record Thing(string C1, string C2);

public static class D23P1
{
    public static object Part1Answer(this string input)
    {
        var trip = input.ParseThings().ToList().FindTriplets();
        return trip.Count(trip => trip.StartsWith("t") || trip.Contains(",t"));
    }

    internal static IEnumerable<Thing> ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<Thing>();

    internal static Thing? TryParseAsThing(this string line)
    {
        if (line.Length != 5) return null;
        return new Thing(line.Substring(0, 2), line.Substring(3, 2));
    }

    internal static HashSet<string> FindTriplets(this List<Thing> things)
    {
        Dictionary<string, List<string>> dictionary = [];
        foreach (var t in things)
        {
            dictionary.AddToList(t.C1, t.C2);
            dictionary.AddToList(t.C2, t.C1);
        }

        HashSet<string> triplets = [];
        foreach (var t in things)
        {
            var others = dictionary[t.C1].Intersect(dictionary[t.C2]);
            foreach (var o in others)
            {
                var triplet = string.Join(',',new[]{t.C1, t.C2, o}.Order());
                triplets.Add(triplet);
            }
        }

        return triplets;
    }

    internal static void AddToList(this Dictionary<string, List<string>> dict, string key, string value)
    {
        if (dict.TryGetValue(key, out var list))
            list.Add(value);
        else
            dict.Add(key, [value]);
    }

}