using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Composite : Element
    {
        protected List<Element> _elements;

        public Composite(string name)
            : base(name) 
        {
            _elements = new List<Element>();
        }

        public override bool IsPrimitive => false;

        public override void Add(Element element)
        {
            _elements.Add(element);
        }

        public override void Display(int level)
        {
            base.Display(level);

            foreach (var element in _elements)
                element.Display(level + 3);
        }
    }
}
