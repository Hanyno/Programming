using System;

namespace Program
{
    internal class app
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte celé číslo pro určení zda je sudé nebo liché:");
            int cislo = int.TryParse(Console.ReadLine());
            int cisloPomocne = cislo % 2;

            if (cisloPomocne == 1)
            Console.WriteLine("Číslo " + cislo + " je liché.");
            else
            Console.WriteLine("Číslo " + cislo + " je sudé.");
            Console.ReadKey();
        }
    }
}