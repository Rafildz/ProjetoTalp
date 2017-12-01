using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTalpRaf.Cliente
{
    public partial class ClienteAlterar : Form
    {
        public ClienteAlterar()
        {
            InitializeComponent();
        }

        private void ClienteAlterar_Load(object sender, EventArgs e)
        {
            preencherGrid();
        }

        private void preencherGrid()
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = @"SELECT IdCliente, Nome, Telefone, Email FROM Cliente ORDER BY IdCliente";

                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = System.Data.CommandType.Text;

                    DataSet dt = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                    dtAdapter.Fill(dt);

                    this.dtGridCliente.DataSource = dt.Tables[0];
                    preencherCombo(dt.Tables[0]);

                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = @"UPDATE Cliente SET Nome= @Nome, Telefone=@Telefone, Email=@Email WHERE IdCliente = @IdCliente";


                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Parameters.AddWithValue("@IdCliente", lblValor.Text);
                    sqlCommand.Parameters.AddWithValue("@Nome", txtNome.Text);
                    sqlCommand.Parameters.AddWithValue("@Telefone", int.Parse(txtTelefone.Text));
                    sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                    sqlCommand.ExecuteNonQuery();


                    DataSet dt = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                    dtAdapter.Fill(dt);

                    lblResultado.Text = "Alterado com sucesso!";

                    preencherGrid();
                }
                catch (Exception ex)
                {
                    lblResultado.Text = "Erro ao alterar!";
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValor.Text = cmbCliente.SelectedValue.ToString();
        }

        private void preencherCombo(DataTable dataTable)
        {
            this.cmbCliente.DisplayMember = "Nome";
            this.cmbCliente.ValueMember = "IdCliente";
            this.cmbCliente.DataSource = dataTable;
        }
    }
}
