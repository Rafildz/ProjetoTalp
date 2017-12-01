using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTalpRaf
{
    public partial class Planilha : Form
    {
        public Planilha()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
                label1.Text = "R$500,00";
                label2.Text = "Adicional por foto: R$5,50";
            } else if (radioButton2.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
                label1.Text = "R$600,00";
                label2.Text = "Adicional por foto: R$5,25";
            } else if (radioButton3.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
                label1.Text = "R$700,00";
                label2.Text = "Adicional por foto: R$5,00";
            } else
            {
                MessageBox.Show("Escolha uma quantidade de fotos!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
