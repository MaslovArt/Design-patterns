using System;

namespace Bridge.Impl
{
    public class Сhainsaw : ITool
    {
        public void Prepare()
        {
            Console.WriteLine("Сhecking oil, fuel, chains.");
        }

        public void Use()
        {
            Console.WriteLine("Start engine.");
            Console.WriteLine("Easy sawing.");
        }
    }
}
