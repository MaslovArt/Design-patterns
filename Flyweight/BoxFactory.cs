using Flyweight.Items;
using System.Collections.Generic;

namespace Flyweight
{
    public class BoxFactory
    {
        private Dictionary<string, Box> _boxes = new Dictionary<string, Box>();

        public Box GetBox(string color, int size)
        {
            var key = color + size;

            Box box = null;
            if (_boxes.TryGetValue(key, out box)) {
                return box;
            }

            box = new Box(color, size);
            _boxes.Add(key, box);
            return box;
        }
    }
}
