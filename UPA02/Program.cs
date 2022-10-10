using System;

namespace Program
{
    internal class app
    {
        static void Main(string[] args)
        {
            zacatek:
            Console.WriteLine("Zvolte datový typ vašeho vstupu: "); //zde si uživatel zvolí jednu ze tří možností datových typů
            Console.Write("1 - celočíselný \n2 - desetinný \n3 - vědecký \n");
            string datovyTyp = Console.ReadLine();

            if(datovyTyp == "1") //zde se sečtou dvě celá čísla
            {
                int prvniCislo, druheCislo, vysledek;
                Console.Write("Zadejte první číslo: ");
                int.TryParse(Console.ReadLine(), out prvniCislo);
                Console.Write("Zadejte druhé číslo: ");
                int.TryParse(Console.ReadLine(), out druheCislo);
                vysledek = prvniCislo + druheCislo;
                Console.WriteLine("Váš výsledek je " + vysledek + ".");
                Console.ReadKey();
            }
            if (datovyTyp == "2") //zde se sečtou dvě desetinná čísla
            {
                double prvniCislo, druheCislo, vysledek;
                Console.Write("Zadejte první číslo: ");
                double.TryParse(Console.ReadLine(), out prvniCislo);
                Console.Write("Zadejte druhé číslo: ");
                double.TryParse(Console.ReadLine(), out druheCislo);
                vysledek = prvniCislo + druheCislo;
                Console.WriteLine("Váš výsledek je " + vysledek + ".");
                Console.ReadKey();
            }
            if (datovyTyp == "3") //zde se sečtou dvě desetinná čísla, ale je to nazvané jako vědecký formát
            {
                decimal prvniCislo, druheCislo, vysledek;
                Console.Write("Zadejte první číslo: ");
                decimal.TryParse(Console.ReadLine(), out prvniCislo);
                Console.Write("Zadejte druhé číslo: ");
                decimal.TryParse(Console.ReadLine(), out druheCislo);
                vysledek = prvniCislo + druheCislo;
                Console.WriteLine("Váš výsledek je " + vysledek + ".");
                Console.ReadKey();
            }
            else //pokud uživatel nezvolí ani jednu správnou možnost program ho požádá znova
            {
                goto zacatek;
            }
        }
    }
}
