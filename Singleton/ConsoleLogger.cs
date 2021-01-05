namespace Singleton
{
    public class ConsoleLogger
    {
        private static ConsoleLogger _logger;
        private ConsoleLogger() { }

        static ConsoleLogger()
        {
            _logger = new ConsoleLogger();
        }

        public static ConsoleLogger Instance => _logger;
    }
}
