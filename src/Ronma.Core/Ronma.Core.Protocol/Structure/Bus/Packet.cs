using System;
using System.Collections.Generic;
using System.Text;

namespace Ronma.Core.Protocol.Structure.Bus
{
    public struct Packet
    {
        public string Service { get; set; }
        public string Command { get; set; }
        public string Args { get; set; }

        public int Length { get; set; }

    }
}
