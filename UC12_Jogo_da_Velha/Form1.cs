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


        private void JogoDaVelha()
        {
            if (Class1.marcador == 1 && Class1.marcador2 == 1 && Class1.marcador3 == 1)
            {
                fechar();
            }

           

            if (Class1.marcador == 1 && Class1.marcador4 == 1 && Class1.marcador7 == 1)
            {


                fechar();


            }
            if (Class1.marcador == 1 && Class1.marcador5 == 1 && Class1.marcador9 == 1)
            {

                fechar();
            }
            if (Class1.marcador3 == 1 && Class1.marcador5 == 1 && Class1.marcador7 == 1)
            {

                fechar();
            }
            if (Class1.marcador9 == 1 && Class1.marcador6 == 1 && Class1.marcador3 == 1)
            {

                fechar();
            }
            if (Class1.marcador7 == 1 && Class1.marcador8 == 1 && Class1.marcador9 == 1)
            {

                fechar();
            }
            if (Class1.marcador2 == 1 && Class1.marcador5 == 1 && Class1.marcador8 == 1)
            {

                fechar();
            }
            if (Class1.marcador == 2 && Class1.marcador2 == 2 && Class1.marcador3 == 2)
            {

                fechar();
            }
            if (Class1.marcador == 2 && Class1.marcador4 == 2 && Class1.marcador7 == 2)
            {

                fechar();
            }
            if (Class1.marcador == 2 && Class1.marcador5 == 2 && Class1.marcador9 == 2)
            {

                fechar();
            }
            if (Class1.marcador3 == 2 && Class1.marcador5 == 2 && Class1.marcador7 == 2)
            {

                fechar();
            }
            if (Class1.marcador9 == 2 && Class1.marcador6 == 2 && Class1.marcador3 == 2)
            {

                fechar();
            }
            if (Class1.marcador7 == 2 && Class1.marcador8 == 2 && Class1.marcador9 == 2)
            {

                fechar();
            }
            if (Class1.marcador2 == 2 && Class1.marcador5 == 2 && Class1.marcador8 == 2)
            {

                fechar();
            }
            
            if (Class1.marcador4 == 2 && Class1.marcador5 == 2 && Class1.marcador6 == 2)
            {

                fechar();
            }
            if (Class1.marcador4 == 1 && Class1.marcador5 == 1 && Class1.marcador6 == 1)
            {

                fechar();
            }
        }

        private void fechar()
        {
            DialogResult ganhou = MessageBox.Show("Voce ganhou, Deseja continuar?", "", MessageBoxButtons.YesNo);
            if (ganhou == DialogResult.Yes)
            {
                Form FormInicial = new Form_INICIO();
                FormInicial.Show();

                this.Close();

            }
            else
            {
                this.Close();
            }
            
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
                Class1.marcador = 1;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
                Class1.marcador = 2;
            }

            JogoDaVelha();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox2.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
                Class1.marcador2 = 1;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
                Class1.marcador2 = 2;
            }
            JogoDaVelha();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox3.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
                Class1.marcador3 = 1;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
                Class1.marcador3 = 2;
            }
            JogoDaVelha();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox4.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
                Class1.marcador4 = 1;
            }
            else
            {
                pictureBox4.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
                Class1.marcador4 = 2;
            }
            JogoDaVelha();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox5.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
                Class1.marcador5 = 1;
            }
            else
            {
                pictureBox5.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
                Class1.marcador5 = 2;
            }
            JogoDaVelha();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox6.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
                Class1.marcador6 = 1;
            }
            else
            {
                pictureBox6.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
                Class1.marcador6 = 2;
            }
            JogoDaVelha();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (Class1.turn1 == "O")
            {
                pictureBox7.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
                Class1.marcador7 = 1;
            }
            else
            {
                pictureBox7.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
                Class1.marcador7 = 2;
            }
            JogoDaVelha();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Class1.turn1 == "O")
            {
                pictureBox8.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
                Class1.marcador8 = 1;
            }
            else
            {
                pictureBox8.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
                Class1.marcador8 = 2;
            }
            JogoDaVelha();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (Class1.turn1 == "O")
            {
                pictureBox9.Image = Properties.Resources.fechar;
                Class1.turn1 = "X";
                Class1.marcador9 = 1;
            }
            else
            {
                pictureBox9.Image = Properties.Resources.alfabeto;
                Class1.turn1 = "O";
                Class1.marcador9 = 2;
            }
            JogoDaVelha();
        }

        private void Form_JOGO_Load(object sender, EventArgs e)
        {

        }

        private void Form_JOGO_FormClosed(object sender, FormClosedEventArgs e)
        {
           


        }
    }
}
