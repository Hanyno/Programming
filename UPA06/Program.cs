using System;

namespace Program
{
    
    /*
    public class Matematika
    {
        //nerekurzivní řešení faktoriálu
        public static int Faktorial (int c)
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
        //rekurzivní řešení faktoriálu
        public static int Faktorial2 (int c)
        {
            if (c <= 1)
                return 1;
            else
                return c *  Faktorial2(c-1);
        }
    }
    */
    internal class app
    {
        
        static void Main(string[] args)
        {           
            //Výpočet faktoriálu ze zadaného čísla
            /*
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
            */

            //Výpočet faktoriálu ze zadaného čísla pomocí metody
            /*
            Console.WriteLine("Zadejte číslo, ze kterého chcete vypočítat faktoriál: ");
            int.TryParse(Console.ReadLine(), out int cislo);
            int vysledek = Matematika.Faktorial(cislo);
            Console.WriteLine(vysledek);
            Console.ReadKey();
            */
            
            //Program, který počítá pocet dnu zbyvajicich do vanoc
            
            //Vypis
            Console.WriteLine("Zadejte datum, od kterého chcete vypocitat pocet dnu do vanoc.");
            Console.Write("Den: ");
            //Nacteni dne
            int.TryParse(Console.ReadLine(), out int den);
            Console.WriteLine();
            Console.Write("Měsíc: ");
            //Nacteni mesice
            int.TryParse(Console.ReadLine(), out int mesic);
            Console.WriteLine();
            //Využití metody odpočtu a vypsání výsledku
            Console.WriteLine(PoctyDnu.PocetDnuDoVanoc(den, mesic));
            Console.WriteLine(PoctyDnu.PocetDnuDoSilvestra(den, mesic));
            Console.ReadKey();
        }
    }
}