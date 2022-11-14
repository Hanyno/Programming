using System;

namespace Program
{
public class PoctyDnu
    {
        private static int PocetDnuDoVyznamneho(int d, int m, string vyznamnyDen)
        {
            int den = 1;
            if (vyznamnyDen == "Vanoce")
            {
                den = 24;
            }
            else
            {
                den = 31;
            }

            //definujeme si dny v jednotlivych mesicich
            int[] mesice = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            //init vysledku
            int vysledek = 0;
            //vypocitame pocet dnu do konce aktualniho mesice + Vanoce
            vysledek = (mesice[m-1] - d) + den;
            for (int i = m; i < 11; i++)
                vysledek += mesice[i];
            return vysledek;
        }
        public static int PocetDnuDoSilvestra(int d, int m)
        {
            return PocetDnuDoVyznamneho(d,m,"Silvestr");
        }
        public static int PocetDnuDoVanoc(int d, int m)
        {
            return PocetDnuDoVyznamneho(d,m,"Vanoce");
        }
    }
}