using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var html_1 = new HtmlTextBuilder()
                .AddMainHeader("Main")
                .AddSubHeader("Sub-1")
                .AddParagraph("Some text in p-1")
                .AddParagraph("Some text in p-2")
                .AddDelimiter()
                .AddSubHeader("Sub-2")
                .AddParagraph("Some text in p-3")
                .AddDelimiter()
                .Build();
            Console.WriteLine(html_1);

            var html_2 = new HtmlTextBuilder()
                .AddMainHeader("Main-2")
                .AddParagraph("Par1")
                .AddDelimiter()
                .Build();
            Console.WriteLine(html_2);

            Console.ReadKey();
        }
    }
}
