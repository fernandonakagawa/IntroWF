using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05_WF_01
{
    public partial class Form1 : Form
    {
        private bool travar;
        public Form1()
        {
            InitializeComponent();
            this.travar = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label1.Text.Equals("Bom dia!"))
            {
                label1.Text = "Olá Mundo!";
            }
            else
            {
                label1.Text = "Bom dia!";
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (!this.travar)
            {
                label1.Text = "HAHA!";
                if (button1.Location.X < 560)
                {
                    button1.Location = new Point(560, 210);
                }
                else
                {
                    button1.Location = new Point(30, 210);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbSenha.Text.Equals("Senai"))
            {
                this.travar = true;
                MessageBox.Show("Parabéns! Você conseguiu travar o botão!");
                label1.Text = "Parabéns";
            }
            else
            {
                this.travar = false;
                MessageBox.Show("SENHA INCORRETA!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbSenha.Visible = checkBox1.Checked;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbDesabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDesabilitado.Checked) tbSenha.Enabled = false;
            else tbSenha.Enabled = true;
        }
    }
}
