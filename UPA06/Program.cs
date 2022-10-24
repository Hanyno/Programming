﻿using System;

namespace Program
{
    internal class app
    {
        public static int Faktorial(int c)
        {
            if (c <= 1)
            {
                return 1;
            }
            else
            {
                //vypocet faktorialu
                int vysledek = 1;
                while (c > 1)
            {
                vysledek = vysledek * c;
                c--;
            }
            return vysledek;
            }
        }
        static void Main(string[] args)
        {           
            Console.WriteLine("Zadejte číslo, ze kterého chcete vypočítat faktoriál: ");
            int.TryParse(Console.ReadLine(), out int cislo);
            /*
            int vysledek = 1;
            while (cislo > 1)
            {
                vysledek = vysledek * cislo;
                cislo--;
            }
            Console.WriteLine(vysledek);
            Console.ReadKey();
            */
            int vysledek = app.Faktorial(cislo);
            Console.WriteLine(vysledek);
            Console.ReadKey();
        }
    }
}