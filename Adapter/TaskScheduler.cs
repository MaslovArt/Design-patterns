using Adapter.Executors;

namespace Adapter
{
    public class TaskScheduler
    {
        public void Run(params IExecutable[] executables)
        {
            foreach (var executable in executables) 
                executable.Execute();
        }
    }
}
