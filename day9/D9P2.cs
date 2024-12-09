using shared;

namespace day9;

public static class D9P2
{
    public static object Part2Answer(this string input) =>
        input.ParseThings().DefragV2().Checksum();

    internal static Diskmap DefragV2(this Diskmap diskmap)
    {
        Dump(diskmap);
        var freeSpaces = diskmap.GetFreeSpaceDictionary();
        long lastMovedFileId = long.MaxValue;
        int? lastIndexOfMovingFile = null;
        long? movingFileId = null;
        for (int searchPos = diskmap.Blocks.Count - 1; searchPos >= 0; searchPos--)
        {
            var fileId = diskmap.Blocks[searchPos];
            if (movingFileId is not null)
            {
                if (movingFileId == fileId)
                    continue;
                var firstIndexOfMovingFile = searchPos + 1;
                var fileLength = 1 + (lastIndexOfMovingFile!.Value - firstIndexOfMovingFile);
                var (targetBlock, freeSpaceIndex) = freeSpaces
                    .TakeWhile(fs => fs.Pos < firstIndexOfMovingFile)
                    .WithIndex()
                    .FirstOrDefault(space => space.item.Size >= fileLength);

                if (targetBlock.Size > 0)
                {
                    for (int q = 0; q < fileLength; q++)
                    {
                        diskmap.Blocks[targetBlock.Pos + q] = movingFileId.Value;
                        diskmap.Blocks[firstIndexOfMovingFile + q] = null;
                    }

                    if (targetBlock.Size == fileLength)
                    {
                        freeSpaces.RemoveAt(freeSpaceIndex);
                    }
                    else
                    {
                        freeSpaces[freeSpaceIndex] = (targetBlock.Pos + fileLength, targetBlock.Size - fileLength);
                    }
                    //Dump(diskmap);
                }

                lastMovedFileId = movingFileId.Value;
                movingFileId = null;
                lastIndexOfMovingFile = null;
            }
            if (movingFileId == null)
            {
                if (fileId >= lastMovedFileId)
                    continue;
                if (fileId is null)
                    continue;
                movingFileId = fileId;
                lastIndexOfMovingFile = searchPos;
            }
        }
        return diskmap;
    }

    internal static void Dump(this Diskmap dm)
    {
        if (dm.Blocks.Count > 100) return;
        var c = dm.Blocks.Select(l => l is null ? (char)'.' : (char)(((char)l.Value) + 48)).ToList();
        Console.WriteLine(string.Join("", c));
    }

    internal static List<(int Pos, int Size)> GetFreeSpaceDictionary(this Diskmap diskmap)
    {
        return diskmap.GetFreeSpaces().ToList();
    }

    internal static IEnumerable<(int Pos, int Size)> GetFreeSpaces(this Diskmap diskmap)
    {
        int? startPos = null;
        for (int q = 0; q < diskmap.Blocks.Count; ++q)
        {
            bool isFree = diskmap.Blocks[q] is null;
            if (isFree)
            {
                startPos ??= q;
            }
            else
            {
                if (startPos is not null)
                    yield return (startPos.Value, q - startPos.Value);
                startPos = null;
            }
        }
    }

}
