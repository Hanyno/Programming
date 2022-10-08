using System;

namespace Program
{
    internal class app
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zvolte datový typ vašeho vstupu: ");
            Console.Write("1 - celočíselný \n2 - desetinný \n3 - vědecký \n");
            string datovyTyp = Console.ReadLine();

            if(datovyTyp == "1")
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
            if (datovyTyp == "2")
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
            if (datovyTyp == "3")
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
        }
    }
}
