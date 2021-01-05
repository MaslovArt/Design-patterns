using AbstractFactory.Abstract;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawUI(Systems.IOS);
            DrawUI(Systems.Android);
            DrawUI(Systems.MacOS);

            Console.ReadKey();
        }

        static void DrawUI(Systems system)
        {
            Console.WriteLine($"-----{system}-----");

            var ui = UIFactory.Get(system);
            if (ui == null)
            {
                Console.WriteLine($"UI [{system}] not emplemented error!'");
                return;
            }

            var button = ui.CreateButton();
            button.Render();

            var select = ui.CreateSelect();
            select.Render();
        }
    }
}
