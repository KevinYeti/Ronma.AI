using System;
using Ronma.Core.Protocol.Enums.Service.Bus;
using Ronma.Core.Protocol.Interface.Service.Control.Bus;
using Ronma.Core.Protocol.Structure.Bus;

namespace Ronma.Core.Bus
{
    internal class InternalBus : IBus
    {
        public void Publish(Packet packet)
        {
            throw new NotImplementedException();
        }

        public bool Subscribe(ServiceQueue queue, Func<Packet, bool> process)
        {
            throw new NotImplementedException();
        }
    }
}
