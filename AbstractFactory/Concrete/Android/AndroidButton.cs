using AbstractFactory.Abstract;
using System;

namespace AbstractFactory.Concrete.Android
{
    public class AndroidButton : Button
    {
        public override void Render()
        {
            Console.WriteLine("Render android button");
        }
    }
}
