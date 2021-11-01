using System;

namespace BonusPTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Anna numero niin saat bonus pisteet");
            x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Error");
            }
            else if(x <=3)
            {
                Console.WriteLine("Lukusi on " + x * 10);
            }
            else if(x <=6) 
            {
                Console.WriteLine("Lukusi on " + x * 100);
            }
            else if(x <=8)
            {
                Console.WriteLine("Lukusi on " + x * 1000);
            }
            else if(x == 9)
            {
                Console.WriteLine("Error");
            }
           
           

        }
    }
}
