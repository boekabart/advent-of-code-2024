using shared;

namespace day22;


public record Seq(int D1, int D2, int D3, int D4);
public static class D22P2
{
    public static object Part2Answer(this string input)
    {
        var secrets =
            input.NotEmptyTrimmedLines()
                .Select(long.Parse)
                .ToList();
        var fs = secrets.Select(s => s.FirstSeqs(2000)).ToList();
        var retVal = fs.BestSeqValue(out var seq);
        Console.WriteLine(seq);
        return retVal;
    }


    public static Seq BestSec(this List<Dictionary<int, HashSet<Seq>>> sets)
    {
        int best = 0;
        for (int p = 9; p >= 0; p--)
        {
            var seqSets = sets.Select(d => d.GetValueOrDefault(p) ?? []).ToList();
            var bestSeq = seqSets.SelectMany(ss => ss).GroupBy(seq => seq)
                .Select(gr => new { gr.Key, Count = gr.Count() }).OrderByDescending(gr => gr.Count)
                .First();
            var value = bestSeq.Count * p;
        }
        return default;
    }

    public static int BestSeqValue(this List<Dictionary<Seq, int>> sets, out Seq bestSeq)
    {
        int bestValue = 0;
        bestSeq = new Seq(0,0,0,0);
        foreach (var seq in sets.SelectMany(d => d.Keys).Distinct())
        {
            var totalValue = sets.Sum(set => set.GetValueOrDefault(seq));
            if (totalValue > bestValue)
            {
                bestValue = totalValue;
                bestSeq = seq;
            }
        }

        return bestValue;
    }

    public static Dictionary<int, HashSet<Seq>> BestSecs(this long secret, int n)
    {
        var returnValue = new Dictionary<int, HashSet<Seq>>();
        var firstSeqs = secret.FirstSeqs(n);
        foreach (var fs in firstSeqs)
        {
            if (returnValue.ContainsKey(fs.Value))
                returnValue[fs.Value].Add(fs.Key);
            else
                returnValue.Add(fs.Value, [fs.Key]);
        }
        return returnValue;
    }

    public static Dictionary<Seq, int> FirstSeqs(this long secret, int n)
    {
        var firstSeqs = new Dictionary<Seq, int>();
        secret.FirstSeqs(n, firstSeqs);
        return firstSeqs;
    }

    public static void FirstSeqs(this long secret, int n, Dictionary<Seq,int> seqs)
    {
        var difSeq = new Seq(0, 0, 0, 0);
        var priceSeq = new Seq(0, 0, 0, (int)(secret % 10));
        for (int q = 0; q < n; q++)
        {
            secret = secret.Next();
            var newPrice = (int)(secret % 10);
            difSeq = difSeq.Push(newPrice - priceSeq.D4);
            priceSeq = priceSeq.Push(newPrice);
            if (q >= 3)
                seqs.TryAdd(difSeq, newPrice);
        }
    }

    public static Seq Push(this Seq seq, int d) => new Seq(
        seq.D2, seq.D3, seq.D4, d);

}
