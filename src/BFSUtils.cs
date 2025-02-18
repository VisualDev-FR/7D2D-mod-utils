using System.Linq;

public class BFSUtils
{
    public static readonly Vector3i[] offsets = new Vector3i[]
    {
        new Vector3i(1, 0, 0),
        new Vector3i(-1, 0, 0),
        new Vector3i(0, 1, 0),
        new Vector3i(0, -1, 0),
        new Vector3i(0, 0, 1),
        new Vector3i(0, 0, -1),
        new Vector3i(0, 1, 1),
        new Vector3i(0, -1, 1),
        new Vector3i(0, 1, -1),
        new Vector3i(0, -1, -1),
        new Vector3i(1, 0, 1),
        new Vector3i(-1, 0, 1),
        new Vector3i(1, 0, -1),
        new Vector3i(-1, 0, -1),
        new Vector3i(1, 1, 0),
        new Vector3i(1, -1, 0),
        new Vector3i(-1, 1, 0),
        new Vector3i(-1, -1, 0),
        new Vector3i(1, 1, 1),
        new Vector3i(1, -1, 1),
        new Vector3i(1, 1, -1),
        new Vector3i(1, -1, -1),
        new Vector3i(-1, 1, 1),
        new Vector3i(-1, -1, 1),
        new Vector3i(-1, 1, -1),
        new Vector3i(-1, -1, -1)
    };

    public static readonly int[] offsetHashes = offsets
        .Select(offset => PositionHashCode(offset.x, offset.y, offset.z))
        .ToArray();

    public static readonly Vector3i[] offsetsHorizontal8 = offsets
        .Where(offset => offset.y == 0)
        .ToArray();

    public static readonly Vector3i[] offsetsHorizontal4 = offsets
        .Where(offset => offset.y == 0 && (offset.x == 0 || offset.z == 0))
        .ToArray();

    public static readonly Vector3i[] offsetsNoDiagonal = offsets
        .Where(offset =>
               (offset.x == 0 && offset.y == 0)
            || (offset.x == 0 && offset.z == 0)
            || (offset.y == 0 && offset.z == 0))
        .ToArray();

    public static readonly Vector3i[] offsetsNoVertical = offsets
        .Where(offset => offset.y == 0 || offset.x != 0 || offset.z != 0)
        .ToArray();

    public static readonly Vector3i[] offsetsBelow = offsets
        .Where(offset => offset.y == -1)
        .ToArray();

    public static int PositionHashCode(int x, int y, int z)
    {
        // Hashing function of Vector3i
        return x * 8976890 + y * 981131 + z;
    }

}