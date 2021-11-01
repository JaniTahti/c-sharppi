using System;

namespace Kokonaisluku
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Mikä on ikäsi?:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(x + "?" + " Näytät ikäistäsi nuoremalta.");
        }
    }
}
