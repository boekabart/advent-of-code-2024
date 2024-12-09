using shared;

namespace day9;

internal record Thing(bool Data);

public static class D9P1
{
    public static object Part1Answer(this string input) =>
        input.ParseThings().Defrag().Checksum();

    internal static DiskMap ParseThings(this string input) =>
        input
            .Lines()
            .Select(TryParseAsThing)
            .OfType<DiskMap>()
            .Single();

    internal static DiskMap? TryParseAsThing(this string line)
    {
        if (string.IsNullOrWhiteSpace(line))
            return null;
        return line.AsDiskmap();
    }

    internal static DiskMap AsDiskmap(this string line)
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

        return new DiskMap(diskmapList);
    }

    internal static DiskMap Defrag(this DiskMap diskMap)
    {
        var freeSpaces = diskMap.GetFreeSpaceDictionary();
        freeSpaces.Reverse();
        for (int searchPos = diskMap.Blocks.Count - 1; searchPos >= freeSpaces[^1].Pos; searchPos--)
        {
            var fileId = diskMap.Blocks[searchPos];
            if (fileId is not null)
            {
                var firstIndexOfMovingFile = searchPos;
                var fileLength = 1;

                var targetBlock = freeSpaces[^1];

                if (targetBlock.Size > 0)
                {
                    for (int q = 0; q < fileLength; q++)
                    {
                        diskMap.Blocks[targetBlock.Pos + q] = fileId.Value;
                        diskMap.Blocks[firstIndexOfMovingFile + q] = null;
                    }

                    if (targetBlock.Size == fileLength)
                        freeSpaces.RemoveAt(freeSpaces.Count-1);
                    else
                        freeSpaces[^1] = (targetBlock.Pos + fileLength, targetBlock.Size - fileLength);

                    diskMap.Dump();
                }
            }
        }
        return diskMap;
    }

    internal static long Checksum(this DiskMap dm) => dm.Blocks.Select((fileIdOrNull, index) => fileIdOrNull is null ? 0 : fileIdOrNull.Value * index).Sum();

    
}

internal record DiskMap(List<long?> Blocks);