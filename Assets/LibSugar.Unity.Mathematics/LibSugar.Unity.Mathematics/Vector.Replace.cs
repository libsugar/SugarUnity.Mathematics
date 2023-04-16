using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace LibSugar.Unity.Mathematics
{

    public static partial class MathematicsExt
    {
        #region vector2

        #region replace x

        /// <summary>replace <c>x</c> <code>(x, y) => (X, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 Rx(this bool2 self, bool x)
            => new(x, self.y);

        /// <summary>replace <c>x</c> <code>(x, y) => (X, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half2 Rx(this half2 self, half x)
            => new(x, self.y);

        /// <summary>replace <c>x</c> <code>(x, y) => (X, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Rx(this float2 self, float x)
            => new(x, self.y);

        /// <summary>replace <c>x</c> <code>(x, y) => (X, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Rx(this double2 self, double x)
            => new(x, self.y);

        /// <summary>replace <c>x</c> <code>(x, y) => (X, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 Rx(this int2 self, int x)
            => new(x, self.y);

        /// <summary>replace <c>x</c> <code>(x, y) => (X, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 Rx(this uint2 self, uint x)
            => new(x, self.y);

        #endregion

        #region replace y

        /// <summary>replace <c>y</c> <code>(x, y) => (x, Y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 Ry(this bool2 self, bool y)
            => new(self.x, y);

        /// <summary>replace <c>y</c> <code>(x, y) => (x, Y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half2 Ry(this half2 self, half y)
            => new(self.x, y);

        /// <summary>replace <c>y</c> <code>(x, y) => (x, Y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Ry(this float2 self, float y)
            => new(self.x, y);

        /// <summary>replace <c>y</c> <code>(x, y) => (x, Y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 Ry(this double2 self, double y)
            => new(self.x, y);

        /// <summary>replace <c>y</c> <code>(x, y) => (x, Y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 Ry(this int2 self, int y)
            => new(self.x, y);

        /// <summary>replace <c>y</c> <code>(x, y) => (x, Y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 Ry(this uint2 self, uint y)
            => new(self.x, y);

        #endregion

        #endregion

        #region vector3

        #region replace x

        /// <summary>replace <c>x</c> <code>(x, y, z) => (X, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Rx(this bool3 self, bool x)
            => new(x, self.y, self.z);

        /// <summary>replace <c>x</c> <code>(x, y, z) => (X, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 Rx(this half3 self, half x)
            => new(x, self.y, self.z);

        /// <summary>replace <c>x</c> <code>(x, y, z) => (X, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Rx(this float3 self, float x)
            => new(x, self.y, self.z);

        /// <summary>replace <c>x</c> <code>(x, y, z) => (X, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 Rx(this double3 self, double x)
            => new(x, self.y, self.z);

        /// <summary>replace <c>x</c> <code>(x, y, z) => (X, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Rx(this int3 self, int x)
            => new(x, self.y, self.z);

        /// <summary>replace <c>x</c> <code>(x, y, z) => (X, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Rx(this uint3 self, uint x)
            => new(x, self.y, self.z);

        #endregion

        #region replace y

        /// <summary>replace <c>y</c> <code>(x, y, z) => (x, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Ry(this bool3 self, bool y)
            => new(self.x, y, self.z);

        /// <summary>replace <c>y</c> <code>(x, y, z) => (x, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 Ry(this half3 self, half y)
            => new(self.x, y, self.z);

        /// <summary>replace <c>y</c> <code>(x, y, z) => (x, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Ry(this float3 self, float y)
            => new(self.x, y, self.z);

        /// <summary>replace <c>y</c> <code>(x, y, z) => (x, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 Ry(this double3 self, double y)
            => new(self.x, y, self.z);

        /// <summary>replace <c>y</c> <code>(x, y, z) => (x, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Ry(this int3 self, int y)
            => new(self.x, y, self.z);

        /// <summary>replace <c>y</c> <code>(x, y, z) => (x, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Ry(this uint3 self, uint y)
            => new(self.x, y, self.z);

        #endregion

        #region replace z

        /// <summary>replace <c>z</c> <code>(x, y, z) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Rz(this bool3 self, bool z)
            => new(self.x, self.y, z);

        /// <summary>replace <c>z</c> <code>(x, y, z) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 Rz(this half3 self, half z)
            => new(self.x, self.y, z);

        /// <summary>replace <c>z</c> <code>(x, y, z) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Rz(this float3 self, float z)
            => new(self.x, self.y, z);

        /// <summary>replace <c>z</c> <code>(x, y, z) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 Rz(this double3 self, double z)
            => new(self.x, self.y, z);

        /// <summary>replace <c>z</c> <code>(x, y, z) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Rz(this int3 self, int z)
            => new(self.x, self.y, z);

        /// <summary>replace <c>z</c> <code>(x, y, z) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Rz(this uint3 self, uint z)
            => new(self.x, self.y, z);

        #endregion

        #region replace xy

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z) => (X, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Rxy(this bool3 self, bool2 xy)
            => new(xy.x, xy.y, self.z);

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z) => (X, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 Rxy(this half3 self, half2 xy)
            => new(xy.x, xy.y, self.z);

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z) => (X, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Rxy(this float3 self, float2 xy)
            => new(xy.x, xy.y, self.z);

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z) => (X, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 Rxy(this double3 self, double2 xy)
            => new(xy.x, xy.y, self.z);

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z) => (X, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Rxy(this int3 self, int2 xy)
            => new(xy.x, xy.y, self.z);

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z) => (X, Y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Rxy(this uint3 self, uint2 xy)
            => new(xy.x, xy.y, self.z);

        #endregion

        #region replace yz

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z) => (x, Y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Ryz(this bool3 self, bool2 yz)
            => new(self.x, yz.x, yz.y);

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z) => (x, Y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 Ryz(this half3 self, half2 yz)
            => new(self.x, yz.x, yz.y);

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z) => (x, Y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Ryz(this float3 self, float2 yz)
            => new(self.x, yz.x, yz.y);

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z) => (x, Y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 Ryz(this double3 self, double2 yz)
            => new(self.x, yz.x, yz.y);

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z) => (x, Y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Ryz(this int3 self, int2 yz)
            => new(self.x, yz.x, yz.y);

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z) => (x, Y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Ryz(this uint3 self, uint2 yz)
            => new(self.x, yz.x, yz.y);

        #endregion

        #region replace xz

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z) => (X, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Rxz(this bool3 self, bool2 xz)
            => new(xz.x, self.y, xz.y);

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z) => (X, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 Rxz(this half3 self, half2 xz)
            => new(xz.x, self.y, xz.y);

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z) => (X, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Rxz(this float3 self, float2 xz)
            => new(xz.x, self.y, xz.y);

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z) => (X, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 Rxz(this double3 self, double2 xz)
            => new(xz.x, self.y, xz.y);

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z) => (X, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Rxz(this int3 self, int2 xz)
            => new(xz.x, self.y, xz.y);

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z) => (X, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Rxz(this uint3 self, uint2 xz)
            => new(xz.x, self.y, xz.y);

        #endregion

        #endregion

        #region vector4

        #region replace x

        /// <summary>replace <c>x</c> <code>(x, y, z, w) => (X, y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Rx(this bool4 self, bool x)
            => new(x, self.y, self.z, self.w);

        /// <summary>replace <c>x</c> <code>(x, y, z, w) => (X, y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Rx(this half4 self, half x)
            => new(x, self.y, self.z, self.w);

        /// <summary>replace <c>x</c> <code>(x, y, z, w) => (X, y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Rx(this float4 self, float x)
            => new(x, self.y, self.z, self.w);

        /// <summary>replace <c>x</c> <code>(x, y, z, w) => (X, y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Rx(this double4 self, double x)
            => new(x, self.y, self.z, self.w);

        /// <summary>replace <c>x</c> <code>(x, y, z, w) => (X, y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Rx(this int4 self, int x)
            => new(x, self.y, self.z, self.w);

        /// <summary>replace <c>x</c> <code>(x, y, z, w) => (X, y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Rx(this uint4 self, uint x)
            => new(x, self.y, self.z, self.w);

        #endregion

        #region replace y

        /// <summary>replace <c>y</c> <code>(x, y, z, w) => (x, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ry(this bool4 self, bool y)
            => new(self.x, y, self.z, self.w);

        /// <summary>replace <c>y</c> <code>(x, y, z, w) => (x, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Ry(this half4 self, half y)
            => new(self.x, y, self.z, self.w);

        /// <summary>replace <c>y</c> <code>(x, y, z, w) => (x, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ry(this float4 self, float y)
            => new(self.x, y, self.z, self.w);

        /// <summary>replace <c>y</c> <code>(x, y, z, w) => (x, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ry(this double4 self, double y)
            => new(self.x, y, self.z, self.w);

        /// <summary>replace <c>y</c> <code>(x, y, z, w) => (x, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Ry(this int4 self, int y)
            => new(self.x, y, self.z, self.w);

        /// <summary>replace <c>y</c> <code>(x, y, z, w) => (x, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Ry(this uint4 self, uint y)
            => new(self.x, y, self.z, self.w);

        #endregion

        #region replace z

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Rz(this bool4 self, bool z)
            => new(self.x, self.y, z, self.w);

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Rz(this half4 self, half z)
            => new(self.x, self.y, z, self.w);

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Rz(this float4 self, float z)
            => new(self.x, self.y, z, self.w);

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Rz(this double4 self, double z)
            => new(self.x, self.y, z, self.w);

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Rz(this int4 self, int z)
            => new(self.x, self.y, z, self.w);

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Rz(this uint4 self, uint z)
            => new(self.x, self.y, z, self.w);

        #endregion

        #region replace w

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Rw(this bool4 self, bool w)
            => new(self.x, self.y, self.z, w);

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Rw(this half4 self, half w)
            => new(self.x, self.y, self.z, w);

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Rw(this float4 self, float w)
            => new(self.x, self.y, self.z, w);

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Rw(this double4 self, double w)
            => new(self.x, self.y, self.z, w);

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Rw(this int4 self, int w)
            => new(self.x, self.y, self.z, w);

        /// <summary>replace <c>z</c> <code>(x, y, z, w) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Rw(this uint4 self, uint w)
            => new(self.x, self.y, self.z, w);

        #endregion

        #region replace xy

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z, w) => (X, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Rxy(this bool4 self, bool2 xy)
            => new(xy.x, xy.y, self.z, self.w);

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z, w) => (X, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Rxy(this half4 self, half2 xy)
            => new(xy.x, xy.y, self.z, self.w);

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z, w) => (X, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Rxy(this float4 self, float2 xy)
            => new(xy.x, xy.y, self.z, self.w);

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z, w) => (X, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Rxy(this double4 self, double2 xy)
            => new(xy.x, xy.y, self.z, self.w);

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z, w) => (X, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Rxy(this int4 self, int2 xy)
            => new(xy.x, xy.y, self.z, self.w);

        /// <summary>replace <c>x &amp; y</c> <code>(x, y, z, w) => (X, Y, z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Rxy(this uint4 self, uint2 xy)
            => new(xy.x, xy.y, self.z, self.w);

        #endregion

        #region replace yz

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z, w) => (x, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ryz(this bool4 self, bool2 yz)
            => new(self.x, yz.x, yz.y, self.w);

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z, w) => (x, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Ryz(this half4 self, half2 yz)
            => new(self.x, yz.x, yz.y, self.w);

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z, w) => (x, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ryz(this float4 self, float2 yz)
            => new(self.x, yz.x, yz.y, self.w);

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z, w) => (x, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ryz(this double4 self, double2 yz)
            => new(self.x, yz.x, yz.y, self.w);

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z, w) => (x, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Ryz(this int4 self, int2 yz)
            => new(self.x, yz.x, yz.y, self.w);

        /// <summary>replace <c>y &amp; z</c> <code>(x, y, z, w) => (x, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Ryz(this uint4 self, uint2 yz)
            => new(self.x, yz.x, yz.y, self.w);

        #endregion

        #region replace xz

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z, w) => (X, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Rxz(this bool4 self, bool2 xz)
            => new(xz.x, self.y, xz.y, self.w);

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z, w) => (X, y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Rxz(this half4 self, half2 xz)
            => new(xz.x, self.y, xz.y, self.w);

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z, w) => (X, y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Rxz(this float4 self, float2 xz)
            => new(xz.x, self.y, xz.y, self.w);

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z, w) => (X, y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Rxz(this double4 self, double2 xz)
            => new(xz.x, self.y, xz.y, self.w);

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z, w) => (X, y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Rxz(this int4 self, int2 xz)
            => new(xz.x, self.y, xz.y, self.w);

        /// <summary>replace <c>x &amp; z</c> <code>(x, y, z, w) => (X, y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Rxz(this uint4 self, uint2 xz)
            => new(xz.x, self.y, xz.y, self.w);

        #endregion

        #region replace zw

        /// <summary>replace <c>z &amp; w</c> <code>(x, y, z, w) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Rzw(this bool4 self, bool2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        /// <summary>replace <c>z &amp; w</c> <code>(x, y, z, w) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Rzw(this half4 self, half2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        /// <summary>replace <c>z &amp; w</c> <code>(x, y, z, w) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Rzw(this float4 self, float2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        /// <summary>replace <c>z &amp; w</c> <code>(x, y, z, w) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Rzw(this double4 self, double2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        /// <summary>replace <c>z &amp; w</c> <code>(x, y, z, w) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Rzw(this int4 self, int2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        /// <summary>replace <c>z &amp; w</c> <code>(x, y, z, w) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Rzw(this uint4 self, uint2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        #endregion

        #region replace xw

        /// <summary>replace <c>x &amp; w</c> <code>(x, y, z, w) => (X, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Rxw(this bool4 self, bool2 xw)
            => new(xw.x, self.y, self.z, xw.y);

        /// <summary>replace <c>x &amp; w</c> <code>(x, y, z, w) => (X, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Rxw(this half4 self, half2 xw)
            => new(xw.x, self.y, self.z, xw.y);

        /// <summary>replace <c>x &amp; w</c> <code>(x, y, z, w) => (X, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Rxw(this float4 self, float2 xw)
            => new(xw.x, self.y, self.z, xw.y);

        /// <summary>replace <c>x &amp; w</c> <code>(x, y, z, w) => (X, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Rxw(this double4 self, double2 xw)
            => new(xw.x, self.y, self.z, xw.y);

        /// <summary>replace <c>x &amp; w</c> <code>(x, y, z, w) => (X, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Rxw(this int4 self, int2 xw)
            => new(xw.x, self.y, self.z, xw.y);

        /// <summary>replace <c>x &amp; w</c> <code>(x, y, z, w) => (X, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Rxw(this uint4 self, uint2 xw)
            => new(xw.x, self.y, self.z, xw.y);

        #endregion

        #region replace yw

        /// <summary>replace <c>y &amp; w</c> <code>(x, y, z, w) => (x, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ryw(this bool4 self, bool2 yw)
            => new(self.x, yw.x, self.z, yw.y);

        /// <summary>replace <c>y &amp; w</c> <code>(x, y, z, w) => (x, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Ryw(this half4 self, half2 yw)
            => new(self.x, yw.x, self.z, yw.y);

        /// <summary>replace <c>y &amp; w</c> <code>(x, y, z, w) => (x, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ryw(this float4 self, float2 yw)
            => new(self.x, yw.x, self.z, yw.y);

        /// <summary>replace <c>y &amp; w</c> <code>(x, y, z, w) => (x, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ryw(this double4 self, double2 yw)
            => new(self.x, yw.x, self.z, yw.y);

        /// <summary>replace <c>y &amp; w</c> <code>(x, y, z, w) => (x, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Ryw(this int4 self, int2 yw)
            => new(self.x, yw.x, self.z, yw.y);

        /// <summary>replace <c>y &amp; w</c> <code>(x, y, z, w) => (x, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Ryw(this uint4 self, uint2 yw)
            => new(self.x, yw.x, self.z, yw.y);

        #endregion

        #region replace xyz

        /// <summary>replace <c>x &amp; y &amp; z</c> <code>(x, y, z, w) => (X, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Rxyz(this bool4 self, bool3 xyz)
            => new(xyz.x, xyz.y, xyz.z, self.w);

        /// <summary>replace <c>x &amp; y &amp; z</c> <code>(x, y, z, w) => (X, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Rxyz(this half4 self, half3 xyz)
            => new(xyz.x, xyz.y, xyz.z, self.w);

        /// <summary>replace <c>x &amp; y &amp; z</c> <code>(x, y, z, w) => (X, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Rxyz(this float4 self, float3 xyz)
            => new(xyz.x, xyz.y, xyz.z, self.w);

        /// <summary>replace <c>x &amp; y &amp; z</c> <code>(x, y, z, w) => (X, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Rxyz(this double4 self, double3 xyz)
            => new(xyz.x, xyz.y, xyz.z, self.w);

        /// <summary>replace <c>x &amp; y &amp; z</c> <code>(x, y, z, w) => (X, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Rxyz(this int4 self, int3 xyz)
            => new(xyz.x, xyz.y, xyz.z, self.w);

        /// <summary>replace <c>x &amp; y &amp; z</c> <code>(x, y, z, w) => (X, Y, Z, w)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Rxyz(this uint4 self, uint3 xyz)
            => new(xyz.x, xyz.y, xyz.z, self.w);

        #endregion

        #region replace yzw

        /// <summary>replace <c>y &amp; z &amp; w</c> <code>(x, y, z, w) => (x, Y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ryzw(this bool4 self, bool3 yzw)
            => new(self.x, yzw.x, yzw.y, yzw.z);

        /// <summary>replace <c>y &amp; z &amp; w</c> <code>(x, y, z, w) => (x, Y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Ryzw(this half4 self, half3 yzw)
            => new(self.x, yzw.x, yzw.y, yzw.z);

        /// <summary>replace <c>y &amp; z &amp; w</c> <code>(x, y, z, w) => (x, Y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ryzw(this float4 self, float3 yzw)
            => new(self.x, yzw.x, yzw.y, yzw.z);

        /// <summary>replace <c>y &amp; z &amp; w</c> <code>(x, y, z, w) => (x, Y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ryzw(this double4 self, double3 yzw)
            => new(self.x, yzw.x, yzw.y, yzw.z);

        /// <summary>replace <c>y &amp; z &amp; w</c> <code>(x, y, z, w) => (x, Y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Ryzw(this int4 self, int3 yzw)
            => new(self.x, yzw.x, yzw.y, yzw.z);

        /// <summary>replace <c>y &amp; z &amp; w</c> <code>(x, y, z, w) => (x, Y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Ryzw(this uint4 self, uint3 yzw)
            => new(self.x, yzw.x, yzw.y, yzw.z);

        #endregion
        
        #region replace xyw

        /// <summary>replace <c>x &amp; y &amp; w</c> <code>(x, y, z, w) => (X, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Rxyw(this bool4 self, bool3 xyw)
            => new(xyw.x, xyw.y, self.z, xyw.z);

        /// <summary>replace <c>x &amp; y &amp; w</c> <code>(x, y, z, w) => (X, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Rxyw(this half4 self, half3 xyw)
            => new(xyw.x, xyw.y, self.z, xyw.z);

        /// <summary>replace <c>x &amp; y &amp; w</c> <code>(x, y, z, w) => (X, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Rxyw(this float4 self, float3 xyw)
            => new(xyw.x, xyw.y, self.z, xyw.z);

        /// <summary>replace <c>x &amp; y &amp; w</c> <code>(x, y, z, w) => (X, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Rxyw(this double4 self, double3 xyw)
            => new(xyw.x, xyw.y, self.z, xyw.z);

        /// <summary>replace <c>x &amp; y &amp; w</c> <code>(x, y, z, w) => (X, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Rxyw(this int4 self, int3 xyw)
            => new(xyw.x, xyw.y, self.z, xyw.z);

        /// <summary>replace <c>x &amp; y &amp; w</c> <code>(x, y, z, w) => (X, Y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Rxyw(this uint4 self, uint3 xyw)
            => new(xyw.x, xyw.y, self.z, xyw.z);

        #endregion

        #region replace xzw

        /// <summary>replace <c>x &amp; z &amp; w</c> <code>(x, y, z, w) => (X, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Rxzw(this bool4 self, bool3 xzw)
            => new(xzw.x, self.y, xzw.y, xzw.z);

        /// <summary>replace <c>x &amp; z &amp; w</c> <code>(x, y, z, w) => (X, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Rxzw(this half4 self, half3 xzw)
            => new(xzw.x, self.y, xzw.y, xzw.z);

        /// <summary>replace <c>x &amp; z &amp; w</c> <code>(x, y, z, w) => (X, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Rxzw(this float4 self, float3 xzw)
            => new(xzw.x, self.y, xzw.y, xzw.z);

        /// <summary>replace <c>x &amp; z &amp; w</c> <code>(x, y, z, w) => (X, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Rxzw(this double4 self, double3 xzw)
            => new(xzw.x, self.y, xzw.y, xzw.z);

        /// <summary>replace <c>x &amp; z &amp; w</c> <code>(x, y, z, w) => (X, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Rxzw(this int4 self, int3 xzw)
            => new(xzw.x, self.y, xzw.y, xzw.z);

        /// <summary>replace <c>x &amp; z &amp; w</c> <code>(x, y, z, w) => (X, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Rxzw(this uint4 self, uint3 xzw)
            => new(xzw.x, self.y, xzw.y, xzw.z);

        #endregion
        
        #endregion
    }

}
