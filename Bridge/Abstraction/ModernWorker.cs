using Bridge.Impl;
using System;

namespace Bridge.Abstraction
{
    public class ModernWorker : Worker
    {
        public ModernWorker(ITool tool)
            : base(tool) { }

        public override void Earn()
        {
            Console.WriteLine("Get money on the debit card.");
        }
    }
}
