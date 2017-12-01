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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblLogin.Text = System.Configuration.ConfigurationManager.AppSettings["nome"].ToString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void planilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planilha pl = new Planilha();
            pl.Show();
        }

        private void clienteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Cliente.ClienteCadastro cc = new Cliente.ClienteCadastro();
            cc.Show();
        }

        private void gastoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Gasto.GastoCadastro gc = new Gasto.GastoCadastro();
            gc.Show();
        }

        private void clienteToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Cliente.ClienteAlterar ca = new Cliente.ClienteAlterar();
            ca.Show();
        }

        private void gastoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Gasto.GastoAlterar ga = new Gasto.GastoAlterar();
            ga.Show();
        }

        private void clienteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Cliente.ClienteExcluir ce = new Cliente.ClienteExcluir();
            ce.Show();
        }

        private void gastoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Gasto.GastoExcluir ge = new Gasto.GastoExcluir();
            ge.Show();
        }

        private void clienteToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Cliente.ClienteBuscar cb = new Cliente.ClienteBuscar();
            cb.Show();
        }

        private void gastoToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Gasto.GastoBuscar gb = new Gasto.GastoBuscar();
            gb.Show();
        }

        private void clienteToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Cliente.ClientePesquisa cb = new Cliente.ClientePesquisa();
            cb.Show();
        }

        private void gastoToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Gasto.GastoPesquisa gb = new Gasto.GastoPesquisa();
            gb.Show();
        }
    }
}
