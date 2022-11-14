using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA07
{
    internal class Auta
    {
        //explicitní konstruktor
        public Auta(string text, int vykon)
        {
            this.Nazev = text;
            this.Vykon = vykon;
        }

        private string nazev;
        public string Nazev { get => nazev; set => nazev = value; }

        private float spotreba;
        public float Spotreba { get => spotreba; set => spotreba = value; }

        private int vykon;
        public int Vykon { get => vykon; set => vykon = value; }
        //dynamická metoda na přidání turba do auta
        public int pridatTurbo()
        {
            return this.Vykon += 30;
        }
        //dynamická metoda na chipnutí auta
        public int chipnout()
        {
            return this.Vykon += 50;
        }
        //statická metoda na zjištění, zda se ještě další turbo vleze do auta
        public static bool maxTurbo(int a)
        {
            if (a < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
