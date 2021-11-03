using System;

namespace PosNeg
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anna kokonais luku");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen kokonais luku");
            int y = int.Parse(Console.ReadLine());
            if(x <= 0)
            {
                Console.WriteLine("Numerot ovat negatiivisia");
            }
            else if(y > 0)
            {
                Console.WriteLine("Luvut ovat positiivisa");
            }

            { 
            if (x > 0 && y < 0)
                Console.WriteLine("Toinen on positiivinen ja toinen on negatiivinen");
            if (x < 0 && y > 0)
                Console.WriteLine("Toinen on positiivinen ja toinen on negatiivinen");
            }
        }
    }
}
