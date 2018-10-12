using Ronma.Core.Protocol.Interface.Service.Bus;
using Ronma.Core.Protocol.Structure.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ronma.Core.Bus
{
    internal class InternalBus : IBus
    {
        public void Publish(Packet packet)
        {
            throw new NotImplementedException();
        }

        public bool Subscribe(string service, Func<Packet, bool> process)
        {
            throw new NotImplementedException();
        }
    }
}
