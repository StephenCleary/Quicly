using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nito.Quicly
{
    /// <summary>
    /// A 62-bit unsigned integer.
    /// </summary>
    public readonly record struct UInt62
    {
        /// <summary>
        /// Creates a UInt62 and does a bounds check.
        /// </summary>
        public UInt62(ulong value)
        {
            if (value >= ExclusiveUpperBound)
                throw new ArgumentOutOfRangeException(nameof(value));
            Value = value;
        }

        /// <summary>
        /// The underlying value of the UInt62.
        /// </summary>
        public ulong Value { get; init; }

        /// <summary>
        /// The maximum value of a UInt62.
        /// </summary>
        public static UInt62 MaxValue { get; } = new UInt62 { Value = ExclusiveUpperBound - 1 };

        /// <summary>
        /// 2**62
        /// </summary>
        private const ulong ExclusiveUpperBound = 4611686018427387904;
    }
}
