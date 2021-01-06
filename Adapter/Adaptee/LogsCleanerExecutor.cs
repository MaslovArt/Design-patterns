using Adapter.Executors;

namespace Adapter.Adaptee
{
    public class LogsCleanerExecutor : IExecutable
    {
        private LogsCleaner _logsCleaner = new LogsCleaner();

        public void Execute()
        {
            _logsCleaner.Clean();
        }
    }
}
