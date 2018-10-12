using System;
using System.Threading;

namespace Ronma.Core.Dispatch
{
    public static class Dispatcher
    {
        private static bool _started;

        public static void Initialize()
        {
            
        }

        public static void Kill()
        {
            _started = false;
        }

        public static void Wait()
        {
            Thread thdBus = new Thread(_threadMain);
            thdBus.IsBackground = true;
            thdBus.Priority = ThreadPriority.Lowest;
            thdBus.Start();

            thdBus.Join();
        }

        private static void _threadMain()
        {
            _started = true;
            while (_started)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
