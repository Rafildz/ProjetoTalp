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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var _nome = System.Configuration.ConfigurationManager.AppSettings["nome"].ToString();
            var _senha = System.Configuration.ConfigurationManager.AppSettings["senha"].ToString();

            if(txtNome.Text.Equals(_nome) && txtSenha.Text.Equals(_senha))
            {
                this.Hide();

                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                MessageBox.Show("Informe o usuario e senha corretamente!","Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
    }
}
