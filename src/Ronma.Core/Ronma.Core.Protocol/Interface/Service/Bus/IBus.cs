using Ronma.Core.Protocol.Structure.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ronma.Core.Protocol.Interface.Service.Bus
{
    public interface IBus : IService
    {
        void Publish(Packet packet);

        bool Subscribe(string service, Func<Packet, bool> process);
    }
}
