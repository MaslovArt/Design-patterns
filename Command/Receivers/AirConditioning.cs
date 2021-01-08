using System;

namespace Command.Receivers
{
    public class AirConditioning
    {
        public void Start(double temperature)
        {
            Console.WriteLine($"Start air conditioning [{temperature}]");
        }

        public void Stop()
        {
            Console.WriteLine("Stop air conditioning");
        }
    }
}
