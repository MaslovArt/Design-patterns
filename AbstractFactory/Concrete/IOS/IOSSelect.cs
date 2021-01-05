using AbstractFactory.Abstract;
using System;

namespace AbstractFactory.Concrete.IOS
{
    public class IOSSelect : Select
    {
        public override void Render()
        {
            Console.WriteLine("Render ios select");
        }
    }
}
