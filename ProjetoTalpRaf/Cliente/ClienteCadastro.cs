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
    public partial class ClienteCadastro : Form
    {
        public ClienteCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "INSERT INTO Cliente VALUES (@Nome, @Telefone, @Email)";


                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Parameters.AddWithValue("@Nome", txtNome.Text);
                    sqlCommand.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                    sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                    sqlCommand.ExecuteNonQuery();


                    //DataSet dt = new DataSet();
                   // SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                    //dtAdapter.Fill(dt);

                    lblResultado.Text = "Cadastrado com sucesso!";
                }
                catch (Exception ex)
                {
                    //lblResultado.Text = "Erro ao cadastrar!";
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
