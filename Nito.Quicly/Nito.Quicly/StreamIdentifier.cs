namespace Nito.Quicly
{
    /// <summary>
    /// Represents a stream identifier. This is a 62-bit unsigned integer, which is comprised of a 60-bit unsigned counter and two bits of stream attributes.
    /// </summary>
    public readonly record struct StreamIdentifier
    {
        /// <summary>
        /// Creates a new stream identifier with the specified value.
        /// </summary>
        public StreamIdentifier(ulong value)
        {
            if (value >= (CounterExclusiveUpperBound << 2))
                throw new ArgumentOutOfRangeException(nameof(value));

            Value = value;
        }

        /// <summary>
        /// Creates a new stream identifier from a counter within a stream space specified by the stream attributes.
        /// </summary>
        public StreamIdentifier(ulong counter, bool isServerInitiated, bool isUnidirectional)
        {
            if (counter >= CounterExclusiveUpperBound)
                throw new ArgumentOutOfRangeException(nameof(counter));

            Value = (counter << 2) | (isServerInitiated ? 0x1 : 0x0ul) | (isUnidirectional ? 0x2 : 0x0ul);
        }

        /// <summary>
        /// The underlying value.
        /// </summary>
        public ulong Value { get; }

        /// <summary>
        /// The integer counter of the stream identifier within its stream space.
        /// </summary>
        public ulong Counter => Value >> 2;

        /// <summary>
        /// Whether this stream is server-initiated. If <c>false</c>, then this stream is client-initiated.
        /// </summary>
        public bool IsServerInitiated => (Value & 0x1) != 0;

        /// <summary>
        /// Whether this stream is client-initiated. If <c>false</c>, then this stream is server-initiated.
        /// </summary>
        public bool IsClientInitiated => !IsServerInitiated;

        /// <summary>
        /// Whether this stream is unidirectional. If <c>false</c>, then this stream is bidirectional.
        /// </summary>
        public bool IsUnidirectional => (Value & 0x2) != 0;

        /// <summary>
        /// Whether this stream is bidirectional. If <c>false</c>, then this stream is unidirectional.
        /// </summary>
        public bool IsBidirectional => !IsUnidirectional;

        /// <summary>
        /// 2**60
        /// </summary>
        private const ulong CounterExclusiveUpperBound = 1152921504606846976;
    }
}