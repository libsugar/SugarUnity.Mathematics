using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace LibSugar.Unity.Mathematics
{

    public static partial class MathematicsExt
    {
        #region vector2 => vector3

        #region insert x

        /// <summary>insert <c>x</c> <code>(x, y) => (X, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Ix(this bool2 self, bool x)
            => new(x, self.x, self.y);

        /// <summary>insert <c>x</c> <code>(x, y) => (X, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 Ix(this half2 self, half x)
            => new(x, self.x, self.y);

        /// <summary>insert <c>x</c> <code>(x, y) => (X, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Ix(this float2 self, float x)
            => new(x, self.x, self.y);

        /// <summary>insert <c>x</c> <code>(x, y) => (X, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 Ix(this double2 self, double x)
            => new(x, self.x, self.y);

        /// <summary>insert <c>x</c> <code>(x, y) => (X, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Ix(this int2 self, int x)
            => new(x, self.x, self.y);

        /// <summary>insert <c>x</c> <code>(x, y) => (X, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Ix(this uint2 self, uint x)
            => new(x, self.x, self.y);

        #endregion

        #region insert y

        /// <summary>insert <c>y</c> <code>(x, y) => (x, Y, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Iy(this bool2 self, bool y)
            => new(self.x, y, self.y);

        /// <summary>insert <c>y</c> <code>(x, y) => (x, Y, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 Iy(this half2 self, half y)
            => new(self.x, y, self.y);

        /// <summary>insert <c>y</c> <code>(x, y) => (x, Y, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Iy(this float2 self, float y)
            => new(self.x, y, self.y);

        /// <summary>insert <c>y</c> <code>(x, y) => (x, Y, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 Iy(this double2 self, double y)
            => new(self.x, y, self.y);

        /// <summary>insert <c>y</c> <code>(x, y) => (x, Y, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Iy(this int2 self, int y)
            => new(self.x, y, self.y);

        /// <summary>insert <c>y</c> <code>(x, y) => (x, Y, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Iy(this uint2 self, uint y)
            => new(self.x, y, self.y);

        #endregion

        #region insert z

        /// <summary>insert <c>z</c> <code>(x, y) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Iz(this bool2 self, bool z)
            => new(self.x, self.y, z);

        /// <summary>insert <c>z</c> <code>(x, y) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 Iz(this half2 self, half z)
            => new(self.x, self.y, z);

        /// <summary>insert <c>z</c> <code>(x, y) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Iz(this float2 self, float z)
            => new(self.x, self.y, z);

        /// <summary>insert <c>z</c> <code>(x, y) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 Iz(this double2 self, double z)
            => new(self.x, self.y, z);

        /// <summary>insert <c>z</c> <code>(x, y) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 Iz(this int2 self, int z)
            => new(self.x, self.y, z);

        /// <summary>insert <c>z</c> <code>(x, y) => (x, y, Z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 Iz(this uint2 self, uint z)
            => new(self.x, self.y, z);

        #endregion

        #endregion

        #region vector3 => vector4

        #region insert x

        /// <summary>insert <c>x</c> <code>(x, y, z) => (X, x, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ix(this bool3 self, bool x)
            => new(x, self.x, self.y, self.z);

        /// <summary>insert <c>x</c> <code>(x, y, z) => (X, x, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Ix(this half3 self, half x)
            => new(x, self.x, self.y, self.z);

        /// <summary>insert <c>x</c> <code>(x, y, z) => (X, x, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ix(this float3 self, float x)
            => new(x, self.x, self.y, self.z);

        /// <summary>insert <c>x</c> <code>(x, y, z) => (X, x, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ix(this double3 self, double x)
            => new(x, self.x, self.y, self.z);

        /// <summary>insert <c>x</c> <code>(x, y, z) => (X, x, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Ix(this int3 self, int x)
            => new(x, self.x, self.y, self.z);

        /// <summary>insert <c>x</c> <code>(x, y, z) => (X, x, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Ix(this uint3 self, uint x)
            => new(x, self.x, self.y, self.z);

        #endregion

        #region insert y

        /// <summary>insert <c>y</c> <code>(x, y, z) => (x, Y, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Iy(this bool3 self, bool y)
            => new(self.x, y, self.y, self.z);

        /// <summary>insert <c>y</c> <code>(x, y, z) => (x, Y, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Iy(this half3 self, half y)
            => new(self.x, y, self.y, self.z);

        /// <summary>insert <c>y</c> <code>(x, y, z) => (x, Y, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Iy(this float3 self, float y)
            => new(self.x, y, self.y, self.z);

        /// <summary>insert <c>y</c> <code>(x, y, z) => (x, Y, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Iy(this double3 self, double y)
            => new(self.x, y, self.y, self.z);

        /// <summary>insert <c>y</c> <code>(x, y, z) => (x, Y, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Iy(this int3 self, int y)
            => new(self.x, y, self.y, self.z);

        /// <summary>insert <c>y</c> <code>(x, y, z) => (x, Y, y, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Iy(this uint3 self, uint y)
            => new(self.x, y, self.y, self.z);

        #endregion

        #region insert z

        /// <summary>insert <c>z</c> <code>(x, y, z) => (x, y, Z, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Iz(this bool3 self, bool z)
            => new(self.x, self.y, z, self.z);

        /// <summary>insert <c>z</c> <code>(x, y, z) => (x, y, Z, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Iz(this half3 self, half z)
            => new(self.x, self.y, z, self.z);

        /// <summary>insert <c>z</c> <code>(x, y, z) => (x, y, Z, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Iz(this float3 self, float z)
            => new(self.x, self.y, z, self.z);

        /// <summary>insert <c>z</c> <code>(x, y, z) => (x, y, Z, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Iz(this double3 self, double z)
            => new(self.x, self.y, z, self.z);

        /// <summary>insert <c>z</c> <code>(x, y, z) => (x, y, Z, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Iz(this int3 self, int z)
            => new(self.x, self.y, z, self.z);

        /// <summary>insert <c>z</c> <code>(x, y, z) => (x, y, Z, z)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Iz(this uint3 self, uint z)
            => new(self.x, self.y, z, self.z);

        #endregion

        #region insert w

        /// <summary>insert <c>w</c> <code>(x, y, z) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Iw(this bool3 self, bool w)
            => new(self.x, self.y, self.z, w);

        /// <summary>insert <c>w</c> <code>(x, y, z) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Iw(this half3 self, half w)
            => new(self.x, self.y, self.z, w);

        /// <summary>insert <c>w</c> <code>(x, y, z) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Iw(this float3 self, float w)
            => new(self.x, self.y, self.z, w);

        /// <summary>insert <c>w</c> <code>(x, y, z) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Iw(this double3 self, double w)
            => new(self.x, self.y, self.z, w);

        /// <summary>insert <c>w</c> <code>(x, y, z) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Iw(this int3 self, int w)
            => new(self.x, self.y, self.z, w);

        /// <summary>insert <c>w</c> <code>(x, y, z) => (x, y, z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Iw(this uint3 self, uint w)
            => new(self.x, self.y, self.z, w);

        #endregion

        #endregion

        #region vector2 => vector4

        #region insert xy

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ixy(this bool2 self, bool2 xy)
            => new(xy.x, xy.y, self.x, self.y);

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Ixy(this half2 self, half2 xy)
            => new(xy.x, xy.y, self.x, self.y);

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ixy(this float2 self, float2 xy)
            => new(xy.x, xy.y, self.x, self.y);

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ixy(this double2 self, double2 xy)
            => new(xy.x, xy.y, self.x, self.y);

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Ixy(this int2 self, int2 xy)
            => new(xy.x, xy.y, self.x, self.y);

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Ixy(this uint2 self, uint2 xy)
            => new(xy.x, xy.y, self.x, self.y);

        #endregion

        #region insert yz

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Iyz(this bool2 self, bool2 yz)
            => new(self.x, yz.x, yz.y, self.y);

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Iyz(this half2 self, half2 yz)
            => new(self.x, yz.x, yz.y, self.y);

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Iyz(this float2 self, float2 yz)
            => new(self.x, yz.x, yz.y, self.y);

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Iyz(this double2 self, double2 yz)
            => new(self.x, yz.x, yz.y, self.y);

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Iyz(this int2 self, int2 yz)
            => new(self.x, yz.x, yz.y, self.y);

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Iyz(this uint2 self, uint2 yz)
            => new(self.x, yz.x, yz.y, self.y);

        #endregion

        #region insert zw

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Izw(this bool2 self, bool2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Izw(this half2 self, half2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Izw(this float2 self, float2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Izw(this double2 self, double2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Izw(this int2 self, int2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Izw(this uint2 self, uint2 zw)
            => new(self.x, self.y, zw.x, zw.y);

        #endregion

        #region insert xz

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ixz(this bool2 self, bool2 xz)
            => new(xz.x, self.x, xz.y, self.y);

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Ixz(this half2 self, half2 xz)
            => new(xz.x, self.x, xz.y, self.y);

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ixz(this float2 self, float2 xz)
            => new(xz.x, self.x, xz.y, self.y);

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ixz(this double2 self, double2 xz)
            => new(xz.x, self.x, xz.y, self.y);

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Ixz(this int2 self, int2 xz)
            => new(xz.x, self.x, xz.y, self.y);

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Ixz(this uint2 self, uint2 xz)
            => new(xz.x, self.x, xz.y, self.y);

        #endregion

        #region insert yw

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Iyw(this bool2 self, bool2 yw)
            => new(self.x, yw.x, self.y, yw.y);

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Iyw(this half2 self, half2 yw)
            => new(self.x, yw.x, self.y, yw.y);

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Iyw(this float2 self, float2 yw)
            => new(self.x, yw.x, self.y, yw.y);

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Iyw(this double2 self, double2 yw)
            => new(self.x, yw.x, self.y, yw.y);

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Iyw(this int2 self, int2 yw)
            => new(self.x, yw.x, self.y, yw.y);

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Iyw(this uint2 self, uint2 yw)
            => new(self.x, yw.x, self.y, yw.y);

        #endregion

        #region insert xw

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ixw(this bool2 self, bool2 xw)
            => new(xw.x, self.x, self.y, xw.y);

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Ixw(this half2 self, half2 xw)
            => new(xw.x, self.x, self.y, xw.y);

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ixw(this float2 self, float2 xw)
            => new(xw.x, self.x, self.y, xw.y);

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ixw(this double2 self, double2 xw)
            => new(xw.x, self.x, self.y, xw.y);

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Ixw(this int2 self, int2 xw)
            => new(xw.x, self.x, self.y, xw.y);

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Ixw(this uint2 self, uint2 xw)
            => new(xw.x, self.x, self.y, xw.y);

        #endregion

        #endregion

        #region vector2 => vector4 (,)

        #region insert xy

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ixy(this bool2 self, bool x, bool y)
            => new(x, y, self.x, self.y);

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Ixy(this half2 self, half x, half y)
            => new(x, y, self.x, self.y);

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ixy(this float2 self, float x, float y)
            => new(x, y, self.x, self.y);

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ixy(this double2 self, double x, double y)
            => new(x, y, self.x, self.y);

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Ixy(this int2 self, int x, int y)
            => new(x, y, self.x, self.y);

        /// <summary>insert <c>x &amp; y</c> <code>(x, y) => (X, Y, x, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Ixy(this uint2 self, uint x, uint y)
            => new(x, y, self.x, self.y);

        #endregion

        #region insert yz

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Iyz(this bool2 self, bool y, bool z)
            => new(self.x, y, z, self.y);

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Iyz(this half2 self, half y, half z)
            => new(self.x, y, z, self.y);

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Iyz(this float2 self, float y, float z)
            => new(self.x, y, z, self.y);

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Iyz(this double2 self, double y, double z)
            => new(self.x, y, z, self.y);

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Iyz(this int2 self, int y, int z)
            => new(self.x, y, z, self.y);

        /// <summary>insert <c>y &amp; z</c> <code>(x, y) => (x, Y, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Iyz(this uint2 self, uint y, uint z)
            => new(self.x, y, z, self.y);

        #endregion

        #region insert zw

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Izw(this bool2 self, bool z, bool w)
            => new(self.x, self.y, z, w);

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Izw(this half2 self, half z, half w)
            => new(self.x, self.y, z, w);

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Izw(this float2 self, float z, float w)
            => new(self.x, self.y, z, w);

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Izw(this double2 self, double z, double w)
            => new(self.x, self.y, z, w);

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Izw(this int2 self, int z, int w)
            => new(self.x, self.y, z, w);

        /// <summary>insert <c>z &amp; w</c> <code>(x, y) => (x, y, Z, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Izw(this uint2 self, uint z, uint w)
            => new(self.x, self.y, z, w);

        #endregion

        #region insert xz

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ixz(this bool2 self, bool x, bool z)
            => new(x, self.x, z, self.y);

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Ixz(this half2 self, half x, half z)
            => new(x, self.x, z, self.y);

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ixz(this float2 self, float x, float z)
            => new(x, self.x, z, self.y);

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ixz(this double2 self, double x, double z)
            => new(x, self.x, z, self.y);

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Ixz(this int2 self, int x, int z)
            => new(x, self.x, z, self.y);

        /// <summary>insert <c>x &amp; z</c> <code>(x, y) => (X, x, Z, y)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Ixz(this uint2 self, uint x, uint z)
            => new(x, self.x, z, self.y);

        #endregion

        #region insert yw

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Iyw(this bool2 self, bool y, bool w)
            => new(self.x, y, self.y, w);

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Iyw(this half2 self, half y, half w)
            => new(self.x, y, self.y, w);

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Iyw(this float2 self, float y, float w)
            => new(self.x, y, self.y, w);

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Iyw(this double2 self, double y, double w)
            => new(self.x, y, self.y, w);

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Iyw(this int2 self, int y, int w)
            => new(self.x, y, self.y, w);

        /// <summary>insert <c>y &amp; w</c> <code>(x, y) => (x, Y, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Iyw(this uint2 self, uint y, uint w)
            => new(self.x, y, self.y, w);

        #endregion

        #region insert xw

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ixw(this bool2 self, bool x, bool w)
            => new(x, self.x, self.y, w);

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 Ixw(this half2 self, half x, half w)
            => new(x, self.x, self.y, w);

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ixw(this float2 self, float x, float w)
            => new(x, self.x, self.y, w);

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 Ixw(this double2 self, double x, double w)
            => new(x, self.x, self.y, w);

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 Ixw(this int2 self, int x, int w)
            => new(x, self.x, self.y, w);

        /// <summary>insert <c>x &amp; w</c> <code>(x, y) => (X, x, y, W)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 Ixw(this uint2 self, uint x, uint w)
            => new(x, self.x, self.y, w);

        #endregion

        #endregion
    }

}
