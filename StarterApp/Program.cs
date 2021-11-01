using System;

namespace StarterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write the text");
            var text = Console.ReadLine();
            foreach (var ch in text)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
