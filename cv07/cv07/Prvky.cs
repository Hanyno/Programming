using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    internal class Prvky
    {
        private const int ZLATO = 79;
        //prvni ukazka prace s tridou, datove polozky public
        /*
        public int protonoveCislo;
        public int atomovaHmotnost;
        */

        //explicitni konstruktor 
        //bez parametru
        public Prvky()
        {
            this.ProtonoveCislo = -1;
        }

        public Prvky(int protonCislo)
        { //konstroktor s jednim parametrem
            this.ProtonoveCislo = protonCislo;   
        }

        //datova polozka
        private int protonoveCislo;
        // vlastnost
        public int ProtonoveCislo
        {
            get { return this.protonoveCislo; }
            // value promena se automaticky vytvori pri volani
            set { this.protonoveCislo = value; }
        }

        private string nazev;

        public string Nazev { get => this.nazev; set => this.nazev = value; }

        //private int atomovaHmotnost;


        

        public int DvojnasobnyPocetProtonu()
        {
            return 2*this.ProtonoveCislo;
        }
        public int OzareniAlfa()
        {
            this.ProtonoveCislo = this.ProtonoveCislo + 2;
            return this.ProtonoveCislo;
        }
        /// <summary>
        /// Overi jestli se jedna o zlato
        /// </summary>
        /// <returns>,
        /// ano, pokud je zlato
        /// </returns>
        public bool JeZlato()
        {
            if (this.ProtonoveCislo == ZLATO)
                return true;
            else
                return false;
        }

        public bool Wizzard()
        {
            this.ProtonoveCislo += 5;
            return JeZlato();
        }
        public bool KamenMudrcu()
        {
            this.ProtonoveCislo = ZLATO;
            return JeZlato();
        }
    }
}
