using System;

namespace Strategy.Strats
{
    public class Gauss : IBlurable
    {
        public void Blur()
        {
            Console.WriteLine("Gaussian blur");
        }
    }
}
