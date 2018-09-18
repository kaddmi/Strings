using System;

namespace TaskString
{
    class Program
    {
        static void Main(string[] args)
        {
            TextTransformer textTransf = new TextTransformer();
            string text = Console.ReadLine();
            Console.WriteLine(textTransf.Transform(text));
            Console.ReadLine();
        }
    }
}
