using System;

namespace Program
{
    internal class app
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Zadejte číslo, ze kterého chcete vypočítat faktoriál: ");
            int.TryParse(Console.ReadLine(), out int cislo);
            int vysledek = 1;
            while (cislo > 1)
            {
                vysledek = vysledek * cislo;
                cislo--;
            }
            Console.WriteLine(vysledek);
            Console.ReadKey();
        }
    }
}