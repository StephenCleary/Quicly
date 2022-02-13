using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nito.Quicly
{
    public enum FrameType : ulong
    {
        Padding = 0x0,
        Ping = 0x1,
        Ack = 0x2,
        AckWithExplicitCongestionNotification = 0x3,
        ResetStream = 0x4,
        StopSending = 0x5,
        Crypto = 0x6,
        NewToken = 0x7,
        StreamRangeStart = 0x8,
        StreamRangeEnd = 0x10,
        MaxData = 0x10,
        MaxStreamData = 0x11,
        MaxBidirectionalStreams = 0x12,
        MaxUnidirectionalStreams = 0x13,
        DataBlocked = 0x14,
        StreamDataBlocked = 0x15,
        BidirectionalStreamsBlocked = 0x16,
        UnidirectionalStreamsBlocked = 0x17,
        NewConnectionId = 0x18,
        RetireConnectionId = 0x19,
        PathChallenge = 0x1A,
        PathResponse = 0x1B,
        ConnectionClose = 0x1C,
        ApplicationConnectionClose = 0x1D,
        HandshakeDone = 0x1E,
    }
}
