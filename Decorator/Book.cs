using System;

namespace Decorator
{
    public class Book : LibraryItem
    {
        public Book(string title, int copies)
        {
            Title = title;
            Copies = copies;
        }

        public string Title { get; private set; }

        public override void Display()
        {
            Console.WriteLine($"Title: {Title}, copies: {Copies}");
        }
    }
}
