using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Composite("fileSystem");

            var folder1 = new Composite("folder-1");
            folder1.Add(new Primitive("file-1"));
            folder1.Add(new Primitive("file-2"));
            root.Add(folder1);

            var folder2 = new Composite("folder-2");
            folder2.Add(new Primitive("file-3"));
            root.Add(folder2);

            root.Add(new Primitive("file-4"));
            root.Add(new Primitive("file-5"));

            root.Add(new Composite("folder-3"));

            root.Display(0);

            Console.ReadKey();
        }
    }
}
