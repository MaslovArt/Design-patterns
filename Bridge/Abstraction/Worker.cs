using Bridge.Impl;

namespace Bridge.Abstraction
{
    public abstract class Worker
    {
        protected ITool _tool;

        public Worker(ITool tool)
        {
            _tool = tool;
        }

        public virtual void Work()
        {
            _tool.Prepare();
            _tool.Use();
        }

        public abstract void Earn();
    }
}
