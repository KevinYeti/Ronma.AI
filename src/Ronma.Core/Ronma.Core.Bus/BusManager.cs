using Ronma.Core.Protocol.Enums.Service.Bus;
using Ronma.Core.Protocol.Interface.Service.Control.Bus;
using Ronma.Core.Protocol.Structure.Bus;
using Ronma.Core.Service.Control.RabbitBus;
using System;

namespace Ronma.Core.Bus
{
    public static class BusManager
    {
        public static IBus _bus { get; set; }

        static BusManager()
        {
            _bus = new RabbitBus();
            //_bus = new InternalBus();
        }

        public static void Publish(Packet packet)
        {
            _bus.Publish(packet);
        }

        public static bool Subscribe(ServiceQueue queue, Func<Packet, bool> process)
        {
            return _bus.Subscribe(queue, process);
        }
    }
}
