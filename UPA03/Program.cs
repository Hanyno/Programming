using System;

namespace Program
{
    internal class app
    {
        static void Main(string[] args)
        {
            /**
            //01 Zjištění zda je zadané číslo uživatelem sudé nebo liché
            Console.Write("Zadejte celé číslo pro určení zda je sudé nebo liché:");
            int cislo;
            int.TryParse(Console.ReadLine(), out cislo);
            int cisloPomocne = cislo % 2;

            if (cisloPomocne == 1)
            Console.WriteLine("Číslo " + cislo + " je liché.");
            else
            Console.WriteLine("Číslo " + cislo + " je sudé.");
            Console.ReadKey(); 
            **/

            /**
            //02 Převedení sekund na čas ve formátu hh:mm:ss
            Console.Write("Zadejte počet sekund: ");
            int sekundy, hodiny, minuty;
            bool převod = int.TryParse(Console.ReadLine(), out sekundy);
            hodiny = sekundy / 3600;
            sekundy = sekundy - 3600*hodiny;
            minuty = sekundy / 60;
            sekundy = sekundy - 60*minuty;
            
            Console.WriteLine(hodiny+":"+minuty+":"+sekundy);
            Console.ReadKey();
            **/            

            /**
            //03 Vyčíslení polynomu 2. a 3. stupně
            Console.WriteLine("Chcete zadat polynom 2. nebo 3. stupně? (2./3.)");
            string odpoved = Console.ReadLine();
            if (odpoved == "2" || odpoved == "2.")
            {
                zacatek2:
                Console.WriteLine("Máte polynom ve tvaru ax^2 + bx + c");
                Console.Write("Zadejte číslo a: ");
                double a, b, c, x, vysledek;
                double.TryParse(Console.ReadLine(), out a);
                Console.Write("Zadejte číslo b: ");
                double.TryParse(Console.ReadLine(), out b);
                Console.Write("Zadejte číslo c: ");
                double.TryParse(Console.ReadLine(), out c);
                Console.WriteLine("Je váš polynom: " + a + "x^2 + " + b + "x + " + c +"? (A/N)");
                string potvrzeni = Console.ReadLine();
                if (potvrzeni == "N" || potvrzeni == "n")
                {
                    goto zacatek2;
                }
                else 
                {
                    Console.Write("Zadejte x: ");
                    double.TryParse(Console.ReadLine(), out x);
                }
                vysledek = a * Math.Pow(x, 2) + b * x + c;
                Console.WriteLine("Výsledek vašeho polynomu je: " + vysledek);
                Console.ReadKey();
            }
            if (odpoved == "3" || odpoved == "3.")
            zacatek3:
                Console.WriteLine("Máte polynom ve tvaru ax^3 + bx^2 + cx + d");
                Console.Write("Zadejte číslo a: ");
                double a, b, c, d, x, vysledek;
                double.TryParse(Console.ReadLine(), out a);
                Console.Write("Zadejte číslo b: ");
                double.TryParse(Console.ReadLine(), out b);
                Console.Write("Zadejte číslo c: ");
                double.TryParse(Console.ReadLine(), out c);
                Console.Write("Zadejte číslo d: ");
                double.TryParse(Console.ReadLine(), out d);
                Console.WriteLine("Je váš polynom: " + a + "x^3 + " + b + "x^2 + " + c +"x + " + d + "? (A/N)");
                string potvrzeni = Console.ReadLine();
                if (potvrzeni == "N" || potvrzeni == "n")
                {
                    goto zacatek3;
                }
                else 
                {
                    Console.Write("Zadejte x: ");
                    double.TryParse(Console.ReadLine(), out x);
                }
                vysledek = a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + c * x + d;
                Console.WriteLine("Výsledek vašeho polynomu je: " + vysledek);
                Console.ReadKey();
                **/

                Console.Write("Zadejte počet hvězdiček: ");
                int delka = int.Parse(Console.ReadLine());
                for (int radky = 1; radky <= delka; radky++)
                {
                    for (int mezery = 0; mezery < radky-1; mezery++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*\n"); 
                }
            }
        }
    }
