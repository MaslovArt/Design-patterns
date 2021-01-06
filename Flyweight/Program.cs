using Flyweight.Items;
using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxFactory = new BoxFactory();

            var sceneItems = new List<Box>();
            sceneItems.Add(boxFactory.GetBox("red", 3));
            sceneItems.Add(boxFactory.GetBox("red", 4));
            sceneItems.Add(boxFactory.GetBox("red", 3));
            sceneItems.Add(boxFactory.GetBox("blue", 3));

            foreach (var item in sceneItems)
                item.Render();

            Console.WriteLine(sceneItems[0] == sceneItems[1]);
            Console.WriteLine(sceneItems[0] == sceneItems[2]);

            Console.ReadKey();
        }
    }
}
