using System;

namespace Composite
{
    public abstract class Element
    {
        protected string _name;

        public Element(string name)
        {
            _name = name;
        }

        public virtual void Display(int level)
        {
            Console.WriteLine($"{new string('-', level)}{_name}");
        }
        public abstract void Add(Element element);
        public abstract bool IsPrimitive { get; }
    }
}
