using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpolecnyDelitel
{
    public partial class Form1 : Form
    {
        //Určitě by šel program nějak ošetřit proti špatným uživatelským vstupům, jenom jsem nepřišel na to jak.
        //Také by šlo přidat tlačítko na ukončení programu a lépe nadesignovat samotné okno.
        //Jinak bylo všechno vcelku jednoduché.
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vypocet_Click(object sender, EventArgs e)
        {
            //načtení zadaných čísel
            int prvniCislo = int.Parse(tbCislo1.Text);
            int druheCislo = int.Parse(tbCislo2.Text);
            //seřazení čísel pro správný chod programu
            if (druheCislo > prvniCislo)
            {
                int pomocneCislo = druheCislo;
                druheCislo = prvniCislo;
                prvniCislo = pomocneCislo;
            }
            //výpočet největšího společného dělitele pomocí třídy Vypocty a zároveň vypsání výsledku do TextBoxu 
            tbVysledek.Text = Convert.ToString(Vypocty.Euklid(prvniCislo, druheCislo));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
