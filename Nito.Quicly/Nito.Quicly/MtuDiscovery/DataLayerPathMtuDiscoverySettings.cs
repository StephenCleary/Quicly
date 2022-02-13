using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nito.Quicly.MtuDiscovery
{
    public sealed class DataLayerPathMtuDiscoverySettings
    {
        public int MaxProbes { get; init; } = 3;
        public Mtu MinPlpMtu { get; init; }
        public Mtu MaxPlpMtu { get; init; }
        public Mtu BasePlpMtu { get; init; } = new(1200);

        public TimeSpan ProbeTimeSpan { get; init; } = TimeSpan.FromSeconds(15);
        public TimeSpan PlpMtuRaiseTimeSpan { get; init; } = TimeSpan.FromSeconds(600);
    }
}
