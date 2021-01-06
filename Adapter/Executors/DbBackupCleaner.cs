using System;

namespace Adapter.Executors
{
    public class DbBackupCleaner : IExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Old backups cleaning.");
        }
    }
}
