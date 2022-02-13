using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nito.Quicly.MtuDiscovery
{
    /// <summary>
    /// An implementation of RFC8899, assuming an acknowledged packetization layer.
    /// </summary>
    public sealed class DataLayerPathMtuDiscovery
    {


        public Mtu PlpMtu { get; private set; }

        public void ProbeAcknowledged(ushort probeSize);

        public void ValidatedPtbReceived(ushort plPtbSize);
    }
}
