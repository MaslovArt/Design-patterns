using Command.Commands;
using Command.Invokers;
using Command.Receivers;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV();
            var airConditioning = new AirConditioning();

            var tvOnCommand = new TvOnCommand(tv);
            var airStartCommand = new AirConditioningStartCommand(airConditioning, 21d);

            var pult = new Pult
            {
                BlueBtnCommand = tvOnCommand,
                RedBtnCommand = airStartCommand
            };

            pult.BlueBtnPress();
            pult.RedButtonPress();

            Console.ReadKey();
        }
    }
}
