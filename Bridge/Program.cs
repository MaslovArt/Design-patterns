using Bridge.Abstraction;
using Bridge.Impl;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var saw = new Saw();
            var chainsaw = new Сhainsaw();

            Console.WriteLine("Oldschool");
            var oldShcoolWorker = new OldSchoolWorker(saw);
            oldShcoolWorker.Work();
            oldShcoolWorker.Earn();

            Console.WriteLine("\nModern");
            var modernWorker = new ModernWorker(chainsaw);
            modernWorker.Work();
            modernWorker.Earn();

            Console.ReadKey();
        }
    }
}
