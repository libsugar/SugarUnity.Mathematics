using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace LibSugar.Unity.Mathematics
{

    public static partial class MathematicsExt
    {
        #region quaternion

        /// <summary>Deconstruct<code>var (x, y, z, w) = quaternion</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this quaternion self, out float x, out float y, out float z, out float w)
        {
            x = self.value.x;
            y = self.value.y;
            z = self.value.z;
            w = self.value.w;
        }

        #endregion

        #region vector

        /// <summary>Deconstruct<code>var (x, y) = bool2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool2 self, out bool x, out bool y)
        {
            x = self.x;
            y = self.y;
        }

        /// <summary>Deconstruct<code>var (x, y, z) = bool3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool3 self, out bool x, out bool y, out bool z)
        {
            x = self.x;
            y = self.y;
            z = self.z;
        }

        /// <summary>Deconstruct<code>var (x, y, z, w) = bool4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool4 self, out bool x, out bool y, out bool z, out bool w)
        {
            x = self.x;
            y = self.y;
            z = self.z;
            w = self.w;
        }

        /// <summary>Deconstruct<code>var (x, y) = half2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this half2 self, out half x, out half y)
        {
            x = self.x;
            y = self.y;
        }

        /// <summary>Deconstruct<code>var (x, y, z) = half3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this half3 self, out half x, out half y, out half z)
        {
            x = self.x;
            y = self.y;
            z = self.z;
        }

        /// <summary>Deconstruct<code>var (x, y, z, w) = half4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this half4 self, out half x, out half y, out half z, out half w)
        {
            x = self.x;
            y = self.y;
            z = self.z;
            w = self.w;
        }

        /// <summary>Deconstruct<code>var (x, y) = float2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float2 self, out float x, out float y)
        {
            x = self.x;
            y = self.y;
        }

        /// <summary>Deconstruct<code>var (x, y, z) = float3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float3 self, out float x, out float y, out float z)
        {
            x = self.x;
            y = self.y;
            z = self.z;
        }

        /// <summary>Deconstruct<code>var (x, y, z, w) = float4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float4 self, out float x, out float y, out float z, out float w)
        {
            x = self.x;
            y = self.y;
            z = self.z;
            w = self.w;
        }

        /// <summary>Deconstruct<code>var (x, y) = double2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double2 self, out double x, out double y)
        {
            x = self.x;
            y = self.y;
        }

        /// <summary>Deconstruct<code>var (x, y, z) = double3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double3 self, out double x, out double y, out double z)
        {
            x = self.x;
            y = self.y;
            z = self.z;
        }

        /// <summary>Deconstruct<code>var (x, y, z, w) = double4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double4 self, out double x, out double y, out double z, out double w)
        {
            x = self.x;
            y = self.y;
            z = self.z;
            w = self.w;
        }

        /// <summary>Deconstruct<code>var (x, y) = int2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int2 self, out int x, out int y)
        {
            x = self.x;
            y = self.y;
        }

        /// <summary>Deconstruct<code>var (x, y, z) = int3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int3 self, out int x, out int y, out int z)
        {
            x = self.x;
            y = self.y;
            z = self.z;
        }

        /// <summary>Deconstruct<code>var (x, y, z, w) = int4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int4 self, out int x, out int y, out int z, out int w)
        {
            x = self.x;
            y = self.y;
            z = self.z;
            w = self.w;
        }

        /// <summary>Deconstruct<code>var (x, y) = uint2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint2 self, out uint x, out uint y)
        {
            x = self.x;
            y = self.y;
        }

        /// <summary>Deconstruct<code>var (x, y, z) = uint3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint3 self, out uint x, out uint y, out uint z)
        {
            x = self.x;
            y = self.y;
            z = self.z;
        }

        /// <summary>Deconstruct<code>var (x, y, z, w) = uint4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint4 self, out uint x, out uint y, out uint z, out uint w)
        {
            x = self.x;
            y = self.y;
            z = self.z;
            w = self.w;
        }

        #endregion

        #region matrix2xx

        #region matrix2x2

        /// <summary>Deconstruct<code>var (c0, c1) = bool2x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool2x2 self, out bool2 c0, out bool2 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = float2x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float2x2 self, out float2 c0, out float2 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = double2x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double2x2 self, out double2 c0, out double2 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = int2x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int2x2 self, out int2 c0, out int2 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = uint2x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint2x2 self, out uint2 c0, out uint2 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        #endregion

        #region matrix2x3

        /// <summary>Deconstruct<code>var (c0, c1, c2) = bool2x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool2x3 self, out bool2 c0, out bool2 c1, out bool2 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = float2x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float2x3 self, out float2 c0, out float2 c1, out float2 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = double2x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double2x3 self, out double2 c0, out double2 c1, out double2 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = int2x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int2x3 self, out int2 c0, out int2 c1, out int2 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = uint2x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint2x3 self, out uint2 c0, out uint2 c1, out uint2 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        #endregion

        #region matrix2x4

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = bool2x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool2x4 self, out bool2 c0, out bool2 c1, out bool2 c2, out bool2 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = float2x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float2x4 self, out float2 c0, out float2 c1, out float2 c2, out float2 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = double2x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double2x4 self, out double2 c0, out double2 c1, out double2 c2,
            out double2 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = int2x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int2x4 self, out int2 c0, out int2 c1, out int2 c2, out int2 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = uint2x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint2x4 self, out uint2 c0, out uint2 c1, out uint2 c2, out uint2 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        #endregion

        #endregion

        #region matrix3xx

        #region matrix3x2

        /// <summary>Deconstruct<code>var (c0, c1) = bool3x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool3x2 self, out bool3 c0, out bool3 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = float3x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float3x2 self, out float3 c0, out float3 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = double3x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double3x2 self, out double3 c0, out double3 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = int3x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int3x2 self, out int3 c0, out int3 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = uint3x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint3x2 self, out uint3 c0, out uint3 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        #endregion

        #region matrix3x3

        /// <summary>Deconstruct<code>var (c0, c1, c2) = bool3x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool3x3 self, out bool3 c0, out bool3 c1, out bool3 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = float3x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float3x3 self, out float3 c0, out float3 c1, out float3 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = double3x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double3x3 self, out double3 c0, out double3 c1, out double3 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = int3x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int3x3 self, out int3 c0, out int3 c1, out int3 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = uint3x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint3x3 self, out uint3 c0, out uint3 c1, out uint3 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        #endregion

        #region matrix3x4

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = bool3x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool3x4 self, out bool3 c0, out bool3 c1, out bool3 c2, out bool3 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = float3x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float3x4 self, out float3 c0, out float3 c1, out float3 c2, out float3 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = double3x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double3x4 self, out double3 c0, out double3 c1, out double3 c2,
            out double3 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = int3x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int3x4 self, out int3 c0, out int3 c1, out int3 c2, out int3 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = uint3x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint3x4 self, out uint3 c0, out uint3 c1, out uint3 c2, out uint3 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        #endregion

        #endregion

        #region matrix4xx

        #region matrix4x2

        /// <summary>Deconstruct<code>var (c0, c1) = bool4x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool4x2 self, out bool4 c0, out bool4 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = float4x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float4x2 self, out float4 c0, out float4 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = double4x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double4x2 self, out double4 c0, out double4 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = int4x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int4x2 self, out int4 c0, out int4 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        /// <summary>Deconstruct<code>var (c0, c1) = uint4x2</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint4x2 self, out uint4 c0, out uint4 c1)
        {
            c0 = self.c0;
            c1 = self.c1;
        }

        #endregion

        #region matrix4x3

        /// <summary>Deconstruct<code>var (c0, c1, c2) = bool4x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool4x3 self, out bool4 c0, out bool4 c1, out bool4 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = float4x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float4x3 self, out float4 c0, out float4 c1, out float4 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = double4x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double4x3 self, out double4 c0, out double4 c1, out double4 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = int4x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int4x3 self, out int4 c0, out int4 c1, out int4 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2) = uint4x3</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint4x3 self, out uint4 c0, out uint4 c1, out uint4 c2)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
        }

        #endregion

        #region matrix4x4

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = bool4x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this bool4x4 self, out bool4 c0, out bool4 c1, out bool4 c2, out bool4 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = float4x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this float4x4 self, out float4 c0, out float4 c1, out float4 c2, out float4 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = double4x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this double4x4 self, out double4 c0, out double4 c1, out double4 c2,
            out double4 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = int4x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this int4x4 self, out int4 c0, out int4 c1, out int4 c2, out int4 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        /// <summary>Deconstruct<code>var (c0, c1, c2, c3) = uint4x4</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Deconstruct(this uint4x4 self, out uint4 c0, out uint4 c1, out uint4 c2, out uint4 c3)
        {
            c0 = self.c0;
            c1 = self.c1;
            c2 = self.c2;
            c3 = self.c3;
        }

        #endregion

        #endregion
    }

}
