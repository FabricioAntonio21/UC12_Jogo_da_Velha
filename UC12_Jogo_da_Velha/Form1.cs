using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_Jogo_da_Velha
{
    public partial class Form_JOGO : Form
    {
        public Form_JOGO()
        {
            InitializeComponent();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Class1.turn1 == "O")
            {
                pictureBox1.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
            }
            else 
            {
                pictureBox1.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox2.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
            }
            else
            {
                pictureBox2.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox3.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
            }
            else
            {
                pictureBox3.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox4.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
            }
            else
            {
                pictureBox4.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox5.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
            }
            else
            {
                pictureBox5.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox6.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
            }
            else
            {
                pictureBox6.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox7.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
            }
            else
            {
                pictureBox7.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Class1.turn1 == "O")
            {
                pictureBox8.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
            }
            else
            {
                pictureBox8.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (Class1.turn1 == "O")
            {
                pictureBox9.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
            }
            else
            {
                pictureBox9.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
            }
        }
    }
}
