using Strategy.Strats;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageProcessing = new ImageProcessing();
            imageProcessing.Blur("img-1", new Gauss());

            Console.ReadKey();
        }
    }
}
