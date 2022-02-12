using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nito.Quicly
{
    /// <summary>
    /// A manager that handles creating stream identifiers for a specific stream space.
    /// </summary>
    public sealed class StreamIdentifierManager
    {
        /// <summary>
        /// Creates a manager for allocating stream identifiers within a specific stream space.
        /// </summary>
        /// <param name="isServerInitiated">Whether stream identifiers created by this manager are server-initiated.</param>
        /// <param name="isUnidirectional">Whether stream identifiers created by this manager are unidirectional.</param>
        public StreamIdentifierManager(bool isServerInitiated, bool isUnidirectional)
        {
            IsServerInitiated = isServerInitiated;
            IsUnidirectional = isUnidirectional;
        }

        /// <summary>
        /// Whether stream identifiers created by this manager are server-initiated.
        /// </summary>
        public bool IsServerInitiated { get; }

        /// <summary>
        /// Whether stream identifiers created by this manager are client-initiated.
        /// </summary>
        public bool IsClientInitiated => !IsServerInitiated;

        /// <summary>
        /// Whether stream identifiers created by this manager are unidirectional.
        /// </summary>
        public bool IsUnidirectional { get; }

        /// <summary>
        /// Whether stream identifiers created by this manager are bidirectional.
        /// </summary>
        public bool IsBidirectional => !IsUnidirectional;

        /// <summary>
        /// Creates the next stream identifier in this space. This method is thread-safe.
        /// </summary>
        public StreamIdentifier CreateStreamIdentifier()
        {
            var counter = Interlocked.Increment(ref _counter);
            return new StreamIdentifier(counter, IsServerInitiated, IsUnidirectional);
        }

        private ulong _counter = ulong.MaxValue;
    }
}
