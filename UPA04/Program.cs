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

            string[] hry = new string[] {"League of Bugs", "Counter-Strike:Local Defensive", "Snowdriver", "DOOM not eternal", "The Italian plumber"};
            foreach (string polozka in hry)
            {
                Console.WriteLine(polozka);
            }
            Console.ReadKey();
        }
    }
}
