using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace impares_de_1a100___multiplo_de__5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?","Sair", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lsbSoma.Items.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double soma = 0;

            for (int i = 0; i <= 100; i+=2)
            {
                soma = soma + i;
                lsbSoma.Items.Add(i);
            }

            
        }

    }
}
