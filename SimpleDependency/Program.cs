using System;

namespace SimpleDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new MessagePrinterService();
            service.PrintMessage();
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
