using shared;

namespace day9;

internal record Thing(bool Data);

public static class D9P1
{
    public static object Part1Answer(this string input) =>
        input.ParseThings().Defrag().Checksum();

    internal static Diskmap ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<Diskmap>()
            .Single();

    internal static Diskmap? TryParseAsThing(this string line)
    {
        if (string.IsNullOrWhiteSpace(line))
            return null;
        return line.AsDiskmap();
    }

    internal static Diskmap AsDiskmap(this string line)
    {
        long? fileIndex = 0;
        List<long?> diskmapList = [];
        for (int inputPos = 0; inputPos < line.Length; inputPos++)
        {
            var blockCount = ((int)line[inputPos]) - 48;
            if (inputPos % 2 == 0) // file
            {
                diskmapList.AddRange(Enumerable.Range(0,blockCount).Select(_ => fileIndex));
                fileIndex++;
            }
            else
            {
                diskmapList.AddRange(Enumerable.Range(0, blockCount).Select(_ => (long?)null));
            }
        }

        return new Diskmap(diskmapList);
    }

    internal static Diskmap Defrag(this Diskmap diskmap)
    {
        int fileBlockCount = diskmap.Blocks.OfType<long>().Count();
        for (int q = 0; q<diskmap.Blocks.Count; q++)
        {
            if (!DefragOnce(diskmap, fileBlockCount))
                return diskmap;
        }
        return diskmap;
    }

    private static bool DefragOnce(Diskmap diskmap, int fileBlockCount)
    {
        var emptyIndex = diskmap.Blocks.IndexOf(null);
        if (emptyIndex == -1 || emptyIndex == fileBlockCount)
            return false;
        var lastFullIndex = diskmap.Blocks.FindLastIndex(block => block is not null);
        diskmap.Blocks.Swap(emptyIndex, lastFullIndex);
        return true;
    }

    internal static void Swap<T>(this List<T> list, int index1, int index2)
    {
        (list[index1], list[index2]) = (list[index2], list[index1]);
    }

    internal static long Checksum(this Diskmap dm) => dm.Blocks.Select((fileIdOrNull, index) => fileIdOrNull is null ? 0 : fileIdOrNull.Value * index).Sum();

    
}

internal record Diskmap(List<long?> Blocks);