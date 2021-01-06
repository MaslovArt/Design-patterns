using System;

namespace Bridge.Impl
{
    public class Saw : ITool
    {
        public void Prepare()
        {
            Console.WriteLine("Сhecking saw edge.");
        }

        public void Use()
        {
            Console.WriteLine("Hard sawing.");
        }
    }
}
