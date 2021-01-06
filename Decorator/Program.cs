using Decorator.Decorator;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book("Book 1", 5);
            book1.Display();

            var book2 = new Book("Book 2", 7);
            var borrowBook = new Borrowable(book2);
            borrowBook.Borrow("User 1");
            borrowBook.Borrow("User 2");
            borrowBook.Display();

            Console.ReadKey();
        }
    }
}
