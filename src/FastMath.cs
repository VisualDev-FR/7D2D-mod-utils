using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FastMath
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float SqrEuclidianDist(Vector3i p1, Vector3i p2)
    {
        float dx = p1.x - p2.x;
        float dy = p1.y - p2.y;
        float dz = p1.z - p2.z;

        return dx * dx + dy * dy + dz * dz;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float SqrEuclidianDist(Vector3 p1, Vector3 p2)
    {
        float dx = p1.x - p2.x;
        float dy = p1.y - p2.y;
        float dz = p1.z - p2.z;

        return dx * dx + dy * dy + dz * dz;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int SqrEuclidianDistInt32(Vector3i p1, Vector3i p2)
    {
        int dx = p1.x - p2.x;
        int dy = p1.y - p2.y;
        int dz = p1.z - p2.z;

        return dx * dx + dy * dy + dz * dz;
    }

    public static float EuclidianDist(Vector3i p1, Vector3i p2)
    {
        return (float)Math.Sqrt(SqrEuclidianDist(p1, p2));
    }

    public static int SqrMagnitude(Vector3i vector)
    {
        return vector.x * vector.x + vector.y * vector.y + vector.z * vector.z;
    }

}