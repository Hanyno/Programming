using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv07
{
    internal static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            Prvky H = new Prvky(1); // implicitni konstruktor
            Console.WriteLine("Je zlato? " + H.JeZlato());
            H.Wizzard();
            Console.WriteLine("Je zlato? " + H.JeZlato());
            H.OzareniAlfa();
            Console.WriteLine("Je zlato? " + H.JeZlato());
            H.KamenMudrcu();
            Console.WriteLine("Je zlato? " + H.JeZlato());

            Prvky He = new Prvky(2);
            He.OzareniAlfa();

            while(!He.JeZlato())
            {
                He.Wizzard();
                Console.WriteLine("Je zlato? " + He.JeZlato() + " / protonove cislo: " + He.ProtonoveCislo);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
