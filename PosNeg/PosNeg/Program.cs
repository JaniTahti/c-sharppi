using System;

namespace PosNeg
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Anna kokonais luku");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen kokonais luku");
            x = int.Parse(Console.ReadLine());
            if(x <= 0)
            {
                Console.WriteLine("Numerot ovat negatiivisia");
            }
            else if(x > 0)
            {
                Console.WriteLine("Luvut ovat positiivisa");
            }
            
        }
    }
}
