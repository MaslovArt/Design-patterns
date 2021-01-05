using AbstractFactory.Abstract;
using System;

namespace AbstractFactory.Concrete.Android
{
    public class AndroidSelect : Select
    {
        public override void Render()
        {
            Console.WriteLine("Render android select");
        }
    }
}
