using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator
{
    public class Borrowable : Decorator
    {
        protected List<string> _borrowers = new List<string>();

        public Borrowable(LibraryItem item)
            : base(item) { }

        public void Borrow(string name)
        {
            if (_item.Copies > 0)
            {
                _borrowers.Add(name);
                _item.Copies--;
            }
            else
            {
                Console.WriteLine("No copies!");
            }
        }

        public void Return(string name)
        {
            _borrowers.Remove(name);
        }

        public override void Display()
        {
            _item.Display();
            foreach (var borrow in _borrowers)
            {
                Console.WriteLine($"Borrowed by {borrow}");
            }
        }
    }
}
