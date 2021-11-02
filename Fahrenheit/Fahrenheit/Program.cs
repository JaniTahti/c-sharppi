using System;

namespace Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Anna celsius astikko");
            int x = int.Parse(Console.ReadLine());

           
            Console.WriteLine(x * 1.8 + 32 + " Farenheit");
        }
    }
}
