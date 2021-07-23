using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idadeMesesHoras
{
    public partial class Form1 : Form
    {
        double idade, meses, dias, horas;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtIdade.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                idade = Convert.ToDouble(txtIdade.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Erro na Conversão de Valores!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            meses = idade * 12;
            dias = idade * 365;
            horas = dias * 24;

            MessageBox.Show("Sua Idade em Meses é : " + meses, "Olá " + txtNome.Text);
            MessageBox.Show("Sua Idade em Dias é : " + dias, "Olá " + txtNome.Text);
            MessageBox.Show("Sua Idade em Horas é : " + horas, "Olá " + txtNome.Text);


        }
    }
}
