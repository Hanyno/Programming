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
            
            //kvíz
            /*
            string[] otazky = new string[] {"Jaké je hlavní město Madagaskaru?", "Kolik je 2+2?", "Jaká je šance, že tohle bude fungovat?"};
            string[,] odpovedi = new string[3,2] {{"1 - Madagaskar", "2 - Antananarivo"}, {"1 - 5", "2 - 4"}, {"1 - 50%" ,"2 - 30%"}};
            int body = 0;
            for (int i = 0; i<=otazky.Length; i++)
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
            */

            //kniha jízd

            //Deklarace polí a potřebných proměnných
            Console.WriteLine("Dobrý den. Vítejte v knize jízd.");
            Console.WriteLine("Kolik aut chcete zapasat do knihy jízd?");
            int.TryParse(Console.ReadLine(), out int pocetAut);
            string[] auto = new string[pocetAut];
            string[] palivo = new string[pocetAut];
            double[] spotreba = new double[pocetAut];
            double[] cenaPaliva = new double[pocetAut];
            double[] celkovaCena = new double [pocetAut];
            double[] celkovaVzdalenost2 = new double[pocetAut];
            double celkovaVzalenost = 0;
            double celkovaCenaFinal = 0;

            //Vyplnění pořebných dat od uživatele pro každé auto
            for (int i = 0; i < pocetAut; i++)
            {
                celkovaVzalenost = 0;
                Console.Clear();
                Console.WriteLine("Jaké je vaše {0}. auto?", i+1);
                auto[i] = "ford";                                                       //readline
                Console.Clear();
                Console.WriteLine("Na jaké palivo {0} jezdí?", auto[i]);
                palivo[i] = "nafta";                                                    //readline
                Console.Clear();
                Console.WriteLine("Jaká je spotřeba auta {0} v l/100km?", auto[i]);
                double.TryParse(Console.ReadLine(), out spotreba[i]);
                Console.Clear();
                Console.WriteLine("Jaká je nynější cena paliva {0}?", palivo[i]);
                double.TryParse(Console.ReadLine(), out cenaPaliva[i]);
                Console.Clear();
                Console.WriteLine("Kolikrát jste s tímto autem jel tento měsíc?");
                int.TryParse(Console.ReadLine(),out int pocetJizd);
                double[,] najeteKilometry = new double[pocetAut,pocetJizd];

                //Vyplnění vzdáleností jednotlivých cest uživatele
                for (int j = 0; j < pocetJizd; j++)
                {
                    Console.Clear();
                    Console.WriteLine("Zadejte vzdálenost {0}. cesty v km.", j+1);
                    double.TryParse(Console.ReadLine(), out najeteKilometry[i,j]);
                    celkovaVzalenost = celkovaVzalenost + najeteKilometry[i,j];
                }
                //Výpočet celkové vzdálenosti s daným autem a daná cena paliva, kteréauto projezdilo 
                celkovaVzdalenost2[i] = celkovaVzalenost;
                celkovaCena[i] = (celkovaVzdalenost2[i]/100) * spotreba[i] * cenaPaliva[i];
            }
            
            //vypsání celkových vzdáleností jednotlivých aut a celkové útráty
            for (int k = 0; k < pocetAut; k++)
            {
                Console.WriteLine("S autem {0} jste najezdil celkem {1} a stálo vás to celkem {2},- Kč.", auto[k], celkovaVzdalenost2[k], celkovaCena[k]);
                celkovaVzalenost = celkovaVzalenost + celkovaVzdalenost2[k];
                celkovaCenaFinal = celkovaCenaFinal + celkovaCena[k];
            }

            //vypsání celkové sumarizace všech cest
            Console.WriteLine("Celkem jste dohromady s {0} auty(autem) najezdil celkem {1} km a stálo vás to celkem {2},- Kč", pocetAut, celkovaVzalenost, celkovaCenaFinal);
            Console.ReadKey();
        }
    }
}
