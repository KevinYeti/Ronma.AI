using Ronma.Core.Dispatch;
using System;

namespace Ronma.Mind
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! I am Ronma!");
            Dispatcher.Initialize();

            Dispatcher.Wait();
        }
    }
}
