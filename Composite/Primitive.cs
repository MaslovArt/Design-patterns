using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Primitive : Element
    {
        public Primitive(string name)
            : base(name) { }

        public override bool IsPrimitive => true;

        public override void Add(Element element)
        {
            Console.WriteLine("Can't add to primitive.");
        }
    }
}
