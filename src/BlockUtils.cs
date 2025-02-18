using System.IO;

public class BlockUtils
{
    public static BlockValue GetBlockValue(string blockName)
    {
        if (Block.nameToBlock.TryGetValue(blockName, out var block))
        {
            return block.ToBlockValue();
        }

        throw new InvalidDataException($"block '{blockName}' does not exist. (case maybe invalid)");
    }

    public static bool IsTerrain(BlockValue blockValue)
    {
        return blockValue.Block.shape.IsTerrain();
    }

}