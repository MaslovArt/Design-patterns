using Adapter.Adaptee;
using Adapter.Executors;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var backuper = new DbBackuper();
            var dbCleaner = new DbBackupCleaner();
            var logCleaner = new LogsCleanerExecutor();

            var scheduler = new TaskScheduler();
            scheduler.Run(backuper, dbCleaner, logCleaner);

            Console.ReadKey();
        }
    }
}
