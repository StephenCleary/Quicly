using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nito.Quicly.MtuDiscovery
{
    public interface IPacketizationLayer
    {
        /// <summary>
        /// Notification from the DPLPMTUD that the MTU has changed.
        /// </summary>
        void MtuChanged();

        ValueTask SendProbeAsync(ushort probeSize);
    }
}
