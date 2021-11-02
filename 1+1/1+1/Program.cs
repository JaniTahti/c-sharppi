using System;

namespace _1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna numero");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen numero");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Antamasi numero yhteen laskettuna on " +(x += y));
        }
    }
}
