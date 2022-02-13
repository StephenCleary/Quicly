using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nito.Quicly
{
    [Flags]
    public enum StreamFrameFlags : ulong
    {
        EndOfStream = 0x1,
        LengthPresent = 0x2,
        OffsetPresent = 0x4,
    }
}
