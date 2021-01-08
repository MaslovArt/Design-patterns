using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var synchronizers = new Synchronizer[]
            {
                new LotsSynchronizer()
            };

            RunSynchonization(synchronizers);

            Console.ReadKey();
        }

        static void RunSynchonization(params Synchronizer[] synchronizers)
        {
            foreach (var synchronizer in synchronizers)
                synchronizer.Sync();
        }
    }
}
