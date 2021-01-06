using Bridge.Impl;
using System;

namespace Bridge.Abstraction
{
    public class OldSchoolWorker : Worker
    {
        public OldSchoolWorker(ITool tool)
            : base(tool) { }

        public override void Earn()
        {
            Console.WriteLine("Get cash.");
        }
    }
}
