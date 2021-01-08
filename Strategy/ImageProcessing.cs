using Strategy.Strats;
using System;

namespace Strategy
{
    public class ImageProcessing
    {
        public void Blur(string imageName, IBlurable blurable)
        {
            Console.WriteLine("Process image " + imageName);
            blurable.Blur();
        }
    }
}
