using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPA009
{
    internal static class Program
    {
        public static void KonzolePoCastech(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
            }
        }

        public static void KonzoleVCelku(string s)
        {
            Console.WriteLine(s);
        }

        public static string GeneratorStringu()
        {
            string s1 = "qwertzuiopasdfghjklyxcvbnm";
            string s = "";
            for (int i = 0; i < 100; i++)
            {
                s += s1;
            }
            return s;
        }

        public static void NejvicCetneCislo(int[] pole)
        {
            //seřazení pole
            Array.Sort(pole);
            //
            int cetnostCisla = 1;
            int maxCetnost = 1;
            int cislo = pole[0];
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] == pole[i - 1])
                {
                    cetnostCisla++;
                }
                else if (cetnostCisla > maxCetnost)
                {
                    cislo = pole[i-1];
                    maxCetnost = cetnostCisla;
                    cetnostCisla = 1;
                }
                else
                {
                    cetnostCisla = 1;
                }
            }
            Console.WriteLine("Největší četnost ({0}) má číslo {1}", maxCetnost, cislo);

        }

        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {



            /*
            string s = GeneratorStringu();
            KonzolePoCastech(s);
            KonzoleVCelku(s);
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
