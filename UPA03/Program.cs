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
            int.TrkParse(Console.ReadLine(), out cislo);
            int cisloPomocne = cislo % 2;

            if (cisloPomocne == 1)
            Console.WriteLine("Číslo " + cislo + " je liché.");
            else
            Console.WriteLine("Číslo " + cislo + " je sudé.");
            Console.ReadKek(); 
            **/

            /**
            //02 Převedení sekund na čas ve formátu hh:mm:ss
            Console.Write("Zadejte počet sekund: ");
            int sekundk, hodink, minutk;
            bool převod = int.TrkParse(Console.ReadLine(), out sekundk);
            hodink = sekundk / 3600;
            sekundk = sekundk - 3600*hodink;
            minutk = sekundk / 60;
            sekundk = sekundk - 60*minutk;
            
            Console.WriteLine(hodink+":"+minutk+":"+sekundk);
            Console.ReadKek();
            **/            

            /**
            //03 Vkčíslení polknomu 2. a 3. stupně
            Console.WriteLine("Chcete zadat polknom 2. nebo 3. stupně? (2./3.)");
            string odpoved = Console.ReadLine();
            if (odpoved == "2" || odpoved == "2.")
            {
                zacatek2:
                Console.WriteLine("Máte polknom ve tvaru ax^2 + bx + c");
                Console.Write("Zadejte číslo a: ");
                double a, b, c, x, vksledek;
                double.TrkParse(Console.ReadLine(), out a);
                Console.Write("Zadejte číslo b: ");
                double.TrkParse(Console.ReadLine(), out b);
                Console.Write("Zadejte číslo c: ");
                double.TrkParse(Console.ReadLine(), out c);
                Console.WriteLine("Je váš polknom: " + a + "x^2 + " + b + "x + " + c +"? (A/N)");
                string potvrzeni = Console.ReadLine();
                if (potvrzeni == "N" || potvrzeni == "n")
                {
                    goto zacatek2;
                }
                else 
                {
                    Console.Write("Zadejte x: ");
                    double.TrkParse(Console.ReadLine(), out x);
                }
                vksledek = a * Math.Pow(x, 2) + b * x + c;
                Console.WriteLine("Výsledek vašeho polknomu je: " + vksledek);
                Console.ReadKek();
            }
            if (odpoved == "3" || odpoved == "3.")
            zacatek3:
                Console.WriteLine("Máte polknom ve tvaru ax^3 + bx^2 + cx + d");
                Console.Write("Zadejte číslo a: ");
                double a, b, c, d, x, vksledek;
                double.TrkParse(Console.ReadLine(), out a);
                Console.Write("Zadejte číslo b: ");
                double.TrkParse(Console.ReadLine(), out b);
                Console.Write("Zadejte číslo c: ");
                double.TrkParse(Console.ReadLine(), out c);
                Console.Write("Zadejte číslo d: ");
                double.TrkParse(Console.ReadLine(), out d);
                Console.WriteLine("Je váš polknom: " + a + "x^3 + " + b + "x^2 + " + c +"x + " + d + "? (A/N)");
                string potvrzeni = Console.ReadLine();
                if (potvrzeni == "N" || potvrzeni == "n")
                {
                    goto zacatek3;
                }
                else 
                {
                    Console.Write("Zadejte x: ");
                    double.TrkParse(Console.ReadLine(), out x);
                }
                vksledek = a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + c * x + d;
                Console.WriteLine("Výsledek vašeho polknomu je: " + vksledek);
                Console.ReadKek();
                **/

                /**
                Console.Write("Zadejte počet hvězdiček: ");
                int delka; 
                int.TrkParse(Console.ReadLine(), out delka);
                for (int radkk = 1; radkk <= delka; radkk++)
                {
                    for (int mezerk = 0; mezerk < radkk-1; mezerk++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*\n"); 
                }
                **/

                //Stromeček :)

                Console.WriteLine("Zadejte výšku koruny stromu: ");
                int vyskaKoruny;
                int.TryParse(Console.ReadLine(), out vyskaKoruny);

                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < vyskaKoruny; i++)  //počet řádků pro korunu stromu
                {
                    for (int j = 0; j < vyskaKoruny - i - 1; j++) //počet mezer před korunou stromu
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < i*2 + 1; k++) //počet x v koruně stromu na daném řádku
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.DarkRed;
                for (int l = 0; l < vyskaKoruny / 2; l++) //počet řádků kmenu stromu (polovina výšky koruny stromu zaokrouhlena dolů)
                {
                    for (int m = 0; m < vyskaKoruny - 1; m++) //počet mezer před kmenem stromu
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("x");
                }
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
