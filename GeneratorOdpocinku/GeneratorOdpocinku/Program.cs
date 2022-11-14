using System;

namespace GeneratorOdpocinku
{
    internal class Program
    {
        //celkově se program psal v pohodě, kromě neznámé chyby ve switch (vyber), kdy se bez parametru default vyskytovala nějaká chyba na 53. řádku (podtrhnutí proměnné zpusob)
        static void Main(string[] args)
        {
            //přivítání uživatele
            Console.WriteLine("Dobrý den. Vítejte v generátoru volby aktivity pro volný čas. (stiskněte cokoliv pro pokračování)");
            Console.ReadKey();
            //while cyklus pro možné opakování výběru aktivity pro volý čas
            bool pokracovani = true;
            while(pokracovani)
            {
                //vyčištění konzole pro lepší orientaci
                Console.Clear();
                //načtení všech možností z .txt souboru
                string[] moznosti = File.ReadAllLines("moznosti.txt");
                Console.WriteLine("Vyberte si prosím způsob, jakým chcete trávit volný čas.");
                //vypsání možných způsobů trávení volného času
                for(int i = 0; i < moznosti.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + moznosti[i]);
                }
                //ošetření vstupu, aby uživatel nemohl zadat jiný formát než int a aby nemohl zadat jiné čísla, než jsou ve výběru
                int vyber;
                while (!int.TryParse(Console.ReadLine(), out vyber) || vyber < 1 || vyber > moznosti.Length)
                {
                    Console.WriteLine("Zadejte prosím platnou možnost.");
                }
                //vybrání názvu souboru, ze kterého se načtou možné aktivity daného způsobu
                string zpusob;
                switch (vyber)
                {
                    case 1:
                        zpusob = "sport";
                        break;
                    case 2:
                        zpusob = "odpocinek";
                        break;
                    case 3:
                        zpusob = "vzdelavani";
                        break;
                    default:                        //bez defaultu mi to házelo chybu u promměné na 53. řádku, tato situace díky ošetření nemůže nastat
                        zpusob = "";
                        break;
                }
                
                Console.WriteLine("Svůj volný čas chcete trávit " + moznosti[vyber - 1]);
                //načtení aktivit z daného souboru
                string[] aktivita = File.ReadAllLines(zpusob + ".txt");

                Console.WriteLine("Způsob {0} můžete trávit těmito aktivitami: ", moznosti[vyber - 1]);
                //vypsání aktivit z daného souboru
                for (int i = 0; i < aktivita.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + aktivita[i]);
                }
                int vyber2;
                //ošetření vstupu, aby uživatel nemohl zadat jiný formát než int a aby nemohl zadat jiné čísla, než jsou ve výběru
                while (!int.TryParse(Console.ReadLine(), out vyber2) || vyber2 < 1 || vyber2 > aktivita.Length)
                {
                    Console.WriteLine("Zadejte prosím platnou možnost.");
                }
                //vypsání aktivity, kterou si uživatel vybral
                Console.WriteLine("Vybral jste si jako aktivitu " + aktivita[vyber2 - 1] + "(stiskněte cokoliv pro pokračování)");
                Console.ReadKey();
                //možnost uživatele si vybrat, zda si chce zkusit jinou aktivitu nebo ukončit program
                Console.WriteLine("Přejete si vybrat jinou činnost nebo si dannou činnost zopakovat?");
                Console.WriteLine("1 - ano");
                Console.WriteLine("2 - ne");
                int odpoved;
                //ošetření vstupu, aby uživatel nemohl zadat jiný formát než int a aby nemohl zadat jiné čísla, než jsou ve výběru
                while (!int.TryParse(Console.ReadLine(), out odpoved) || odpoved < 1 || odpoved > 2)
                {
                    Console.WriteLine("Zadejte prosím platnou možnost.");
                }

                if (odpoved == 2)
                    pokracovani = false;
            }
            
        }
    }
}

