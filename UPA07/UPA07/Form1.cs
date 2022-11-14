using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPA07
{
    //Celkově pasaní programu nebyl problém
    //Jen by to opět chtělo ošetřit uživatelské vstupy
    public partial class Form1 : Form
    {
        private Auta mojeAuto;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bVytvorit_Click(object sender, EventArgs e)
        {
            //uložení hodnot do mé proměnné
            mojeAuto = new Auta(this.tbNazev.Text, int.Parse(this.tbVykon.Text));
            

            lStav.Text = "Stav: Auto bylo vytvořeno";
            //nastavení tlačítek, aby nikdo nevytvářel další auta a nepřepisoval vytvořené auto
            tbNazev.Enabled = false;
            tbVykon.Enabled = false;
            bTurbo.Enabled = true;
            bChip.Enabled = true;
        }
        //proměnná pro počet turb
        int a = 0;
        private void bTurbo_Click(object sender, EventArgs e)
        {
            //volání metody pro přidání turba
            mojeAuto.pridatTurbo();
            a++;
            bool maxTurbo = Auta.maxTurbo(a);
            //zastropování počtu turb
            if (maxTurbo == true)
            {
                bTurbo.Enabled = false;
                bTurbo.Text = "Již nelze přidávat turba.";
            }
            //vypsání nynějšího výkonu auta
            tbVykonUpravenehoAuta.Text = mojeAuto.Vykon.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //volání metody pro chipnutí motoru
            mojeAuto.chipnout();
            //vypsání nynějšího výkonu auta
            tbVykonUpravenehoAuta.Text = mojeAuto.Vykon.ToString();
        }

        private void lVykon_Click(object sender, EventArgs e)
        {

        }

        private void tbVykon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
