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
    public partial class Form_INICIO : Form
    {
        public Form_INICIO()
        {
            InitializeComponent();
        }

        private void button_selecionar1_Click(object sender, EventArgs e)
        {
            Class1.turn1 = "O";
            Class1.jogador1 = Class1.nome1;
            Class1.jogador2 = Class1.nome2;

        }

        private void button_selecionar2_Click(object sender, EventArgs e)
        {
            Class1.turn1 = "X";
            Class1.jogador1 = Class1.nome1;
            Class1.jogador2 = Class1.nome2;
        }

        private void button_comecar_Click(object sender, EventArgs e)
        {
            Class1.nome1 = textBox_nome1.Text;
            Class1.nome2 = textBox_nome2.Text;

            Form Form_JOGO = new Form_JOGO();
            Form_JOGO.Show();

            this.Hide();
            Form Form_INICIO = new Form_INICIO();
            Form_INICIO.Closed += (s, args) => this.Close();


            Class1.marcador = 0;
            Class1.marcador2 = 0;
            Class1.marcador3 = 0;
            Class1.marcador4 = 0;
            Class1.marcador5 = 0;
            Class1.marcador6 = 0;
            Class1.marcador7 = 0;
            Class1.marcador8 = 0;
            Class1.marcador9 = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
