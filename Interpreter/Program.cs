using Interpreter.Interpreters;
using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context() { Input = "MCMXXVIII", Output = 0 };

            var exprs = new Expression[]
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TexExpression(),
                new OneExpression()
            };

            foreach (var expr in exprs)
                expr.Interprete(context);

            Console.WriteLine(context.Output);

            Console.ReadKey();
        }
    }
}
