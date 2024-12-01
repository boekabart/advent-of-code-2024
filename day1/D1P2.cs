namespace day1;

public static class D1P2
{
    public static object Part2Answer(this string input)
    {
        var lists = input.ParseThings().ToList();
        var list1 = lists.Select(t => t.Number1).Order().ToList();
        var list2 = lists.Select(t => t.Number2).Order().ToList();
        return list1.Select(n1 => list2.Count(n2 => n2==n1) * n1).Sum();
    }

}
