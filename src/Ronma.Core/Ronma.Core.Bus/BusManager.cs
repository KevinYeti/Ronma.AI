using Ronma.Core.Protocol.Interface.Service.Bus;
using Ronma.Core.Protocol.Structure.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ronma.Core.Bus
{
    public static class BusManager
    {
        public static IBus Bus { get; set; }

        static BusManager()
        {
            Bus = new InternalBus();
        }

        public static void Publish(Packet packet)
        {
            Bus.Publish(packet);
        }

        public static bool Subscribe(string service, Func<Packet, bool> process)
        {
            return Bus.Subscribe(service, process);
        }
    }
}
