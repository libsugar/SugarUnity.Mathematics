using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace LibSugar.Unity.Mathematics
{

    public static partial class MathematicsExt
    {
        /// <summary>AllTrue<code>bool2 == (true, true)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool2 self)
            => self.Equals(true);

        /// <summary>AllTrue<code>bool3 == (true, true, true)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool3 self)
            => self.Equals(true);

        /// <summary>AllTrue<code>bool4 == (true, true, true, true)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool4 self)
            => self.Equals(true);

        /// <summary>AllTrue</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool2x2 self)
            => self.Equals(true);

        /// <summary>AllTrue</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool2x3 self)
            => self.Equals(true);

        /// <summary>AllTrue</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool2x4 self)
            => self.Equals(true);

        /// <summary>AllTrue</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool3x2 self)
            => self.Equals(true);

        /// <summary>AllTrue</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool3x3 self)
            => self.Equals(true);

        /// <summary>AllTrue</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool3x4 self)
            => self.Equals(true);

        /// <summary>AllTrue</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool4x2 self)
            => self.Equals(true);

        /// <summary>AllTrue</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool4x3 self)
            => self.Equals(true);

        /// <summary>AllTrue</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllTrue(this bool4x4 self)
            => self.Equals(true);

        /// <summary>AllFalse<code>bool2 == (false, false)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool2 self)
            => self.Equals(false);

        /// <summary>AllFalse<code>bool3 == (false, false, false)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool3 self)
            => self.Equals(false);

        /// <summary>AllFalse<code>bool4 == (false, false, false, false)</code></summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool4 self)
            => self.Equals(false);

        /// <summary>AllFalse</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool2x2 self)
            => self.Equals(false);

        /// <summary>AllFalse</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool2x3 self)
            => self.Equals(false);

        /// <summary>AllFalse</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool2x4 self)
            => self.Equals(false);

        /// <summary>AllFalse</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool3x2 self)
            => self.Equals(false);

        /// <summary>AllFalse</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool3x3 self)
            => self.Equals(false);

        /// <summary>AllFalse</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool3x4 self)
            => self.Equals(false);

        /// <summary>AllFalse</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool4x2 self)
            => self.Equals(false);

        /// <summary>AllFalse</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool4x3 self)
            => self.Equals(false);

        /// <summary>AllFalse</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AllFalse(this bool4x4 self)
            => self.Equals(false);
    }

}
