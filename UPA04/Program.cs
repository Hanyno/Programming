using System;

namespace Program
{
    internal class app
    {
        static void Main(string[] args)
        {
            /**
            Console.WriteLine("Vyberte váš OS, který právě používáte:");
            Console.WriteLine("1 - Windows \n2 - MacOS \n3 - Linux");
            int vyber;
            int.TryParse(Console.ReadLine(), out vyber);
            switch (vyber)
            {
                case 1:
                    Console.WriteLine("Používáte Windows.");
                    break;
                case 2:
                    Console.WriteLine("Používáte MacOS.");
                    break;
                case 3:
                    Console.WriteLine("Používáte Linux.");
                    break;
                default:
                    Console.WriteLine("Nepoužíváte ani jeden z výše zmíněných OS nebo jste špatně zadal výběr.");
                    break;
            }
            **/

            /**
            string[] hry = new string[] {"League of Bugs", "Counter-Strike:Local Defensive", "Snowdriver", "DOOM not eternal", "The Italian plumber"};
            foreach (string polozka in hry)
            {
                Console.WriteLine(polozka);
            }
            **/
            
            string[] otazky = new string[] {"Jaké je hlavní město Madagaskaru?", "Kolik je 2+2?", "Jaká je šance, že tohle bude fungovat?"};
            string[,] odpovedi = new string[3,2] {{"1 - Madagaskar", "2 - Antananarivo"}, {"1 - 5", "2 - 4"}, {"1 - 50%" ,"2 - 30%"}};
            int body = 0;
            for (int i = 0; i<=2; i++)
            {
                Console.Clear();
                Console.WriteLine(otazky[i]);
                for (int j = 0; j<=1; j++)
                {
                    Console.WriteLine(odpovedi[i,j]);
                }
                int odpoved = int.Parse(Console.ReadLine());
                
                switch (i, odpoved)
                {
                    case (0,2):
                        body++;
                        break;
                    case (1,2):
                        body++;
                        break;
                    case (2,1):
                        body++;
                        break;
                    default:
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Máte celkem {0} bodů.", body);
            Console.ReadKey();
        }
    }
}
