using System;
using System.Threading;

namespace Ronma.Core.Dispatch
{
    public static class Dispatcher
    {
        private static bool _started;
        private static Thread _thdBus;

        public static void Initialize()
        {
            _thdBus = new Thread(_threadMain);
            _thdBus.IsBackground = true;
            _thdBus.Start();
        }

        public static void Kill()
        {
            _started = false;
        }

        public static void Wait()
        {


            _thdBus.Join();
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
