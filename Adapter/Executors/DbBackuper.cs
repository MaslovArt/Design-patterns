using System;

namespace Adapter.Executors
{
    public class DbBackuper : IExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Backup creating.");
        }
    }
}
