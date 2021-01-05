using AbstractFactory.Abstract;
using System;

namespace AbstractFactory.Concrete.IOS
{
    public class IOSButton : Button
    {
        public override void Render()
        {
            Console.WriteLine("Render ios button");
        }
    }
}
