using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv07
{
    public partial class Form1 : Form
    {
        // moje promena pro praci v okne
        private Prvky mujPrvek;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zlatoCheck()
        {
            if (mujPrvek.JeZlato())
                lblZlato.Text = "Je zlato!";
            else
                lblZlato.Text = "Není to zlato";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bVytvorit_Click(object sender, EventArgs e)
        {
            mujPrvek = new Prvky((int)this.nudPocetProtonu.Value);
            mujPrvek.Nazev = tbNazev.Text;

            //napiseme co jsme udelali

            lblStav.Text = "Stav: Prvek byl vytvořen!";

            //vypneme tlacitka

            tbNazev.Enabled = false;
            nudPocetProtonu.Enabled = false;
        }

        private void bKouzelnik_Click(object sender, EventArgs e)
        {
            mujPrvek.Wizzard();
            zlatoCheck();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bAlfa_Click(object sender, EventArgs e)
        {
            mujPrvek.OzareniAlfa();
            zlatoCheck();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
