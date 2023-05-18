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
            
        }

        private void button_selecionar2_Click(object sender, EventArgs e)
        {
            Class1.turn1 = "X";
            
        }

        private void button_comecar_Click(object sender, EventArgs e)
        {
            Class1.nome1 = textBox_nome1.Text;
            Class1.nome2 = textBox_nome2.Text;

            Form Form_JOGO = new Form_JOGO();
            Form_JOGO.Show();
        }
    }
}
