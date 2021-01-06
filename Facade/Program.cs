using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Ivan");

            var mortgage = new Mortgage();
            var result = mortgage.IsEligible(user);

            Console.WriteLine(result ? "Ok" : "Nooo");

            Console.ReadKey();
        }
    }
}
