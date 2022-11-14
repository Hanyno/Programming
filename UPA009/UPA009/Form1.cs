using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPA009
{
    public partial class Form1 : Form
    {

        public static int NejvicCetneCislo(int[] pole)
        {
            //seřazení pole
            Array.Sort(pole);
            //zjištění nejčetnějšího čísla
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
                    cislo = pole[i - 1];
                    maxCetnost = cetnostCisla;
                    cetnostCisla = 1;
                }
                else
                {
                    cetnostCisla = 1;
                }
            }
            return cislo;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int pocetCisel;
        private int[] cislo;
        private void tbPocetCisel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bUlozPocetCisel_Click(object sender, EventArgs e)
        {
            pocetCisel = int.Parse(tbPocetCisel.Text);
            tbPocetCisel.Enabled = false;
            bUlozPocetCisel.Enabled = false;
            tbCislo.Enabled = true;
            bUlozCislo.Enabled = true;
            cislo = new int[pocetCisel]; 
        }
        private int i = 0;
        private void bUlozCislo_Click(object sender, EventArgs e)
        {
            
            if (i < pocetCisel)
            {
                cislo[i] = int.Parse(tbCislo.Text);
                i++;
                tbCislo.Text = null;
            }
            else if (i == pocetCisel)
            {
                bUlozCislo.Enabled = false;
                tbCislo.Enabled = false;
                for (int j = 0; j < cislo.Length; j++)
                {
                    tbZadaneCisla.Text = tbZadaneCisla.Text + " " + cislo[j];
                }
            }
            
            /*
            for (i = 0; i < cislo.Length; i++)
            {
                cislo[i] = int.Parse(tbCislo.Text);
            }
            bUlozCislo.Enabled = false;
            tbCislo.Enabled = false;
            for (int j = 0; j < cislo.Length; j++)
            {
                tbZadaneCisla.Text = tbZadaneCisla.Text + " " + cislo[j];
            }
            */
        }

        private void bNejcetnejsiCislo_Click(object sender, EventArgs e)
        {
            lNejcetnejsiCislo.Text = "Nejčetnější číslo je: " + NejvicCetneCislo(cislo);
        }
    }
}
