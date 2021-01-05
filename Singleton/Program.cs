using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger1 = ConsoleLogger.Instance;
            var logger2 = ConsoleLogger.Instance;
            var logger3 = ConsoleLogger.Instance;
            
            if (logger1 == logger2 && logger2 == logger3)
                Console.WriteLine("Same logger objects.");

            Console.ReadKey();
        }
    }
}
