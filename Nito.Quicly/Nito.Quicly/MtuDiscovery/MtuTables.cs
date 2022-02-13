using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nito.Quicly.MtuDiscovery
{
    public static class MtuTables
    {
        public static Mtu[] Default { get; } = new[] {
            new Mtu(1480), // https://blog.apnic.net/2019/07/31/tcp-mss-values-whats-changed/
            new Mtu(9000), // https://en.wikipedia.org/wiki/Jumbo_frame
        };
    }
}
