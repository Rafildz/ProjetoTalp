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

namespace ProjetoTalpRaf.Gasto
{
    public partial class GastoAlterar : Form
    {
        public GastoAlterar()
        {
            InitializeComponent();
        }

        private void GastoAlterar_Load(object sender, EventArgs e)
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
                    var sql = @"SELECT IdGastos, Tipo, Preco FROM Gasto ORDER BY IdGastos";

                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = System.Data.CommandType.Text;

                    DataSet dt = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                    dtAdapter.Fill(dt);

                    this.dtGridGasto.DataSource = dt.Tables[0];
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
                    var sql = "UPDATE Gasto SET Tipo = @Tipo, Preco=@Preco WHERE IdGastos = @IdGastos";


                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Parameters.AddWithValue("@IdGastos", lblValor.Text);
                    sqlCommand.Parameters.AddWithValue("@Tipo", txtTipo.Text);
                    sqlCommand.Parameters.AddWithValue("@Preco", txtPreco.Text);
                    sqlCommand.ExecuteNonQuery();


                    DataSet dt = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                    dtAdapter.Fill(dt);

                    //this.dtGridGasto.DataSource = dt.Tables[0];
                    //preencherCombo(dt.Tables[0]);

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

        private void cmbGasto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValor.Text = cmbGasto.SelectedValue.ToString();
        }

        private void preencherCombo(DataTable dataTable)
        {
            this.cmbGasto.DisplayMember = "IdGastos";
            this.cmbGasto.ValueMember = "IdGastos";
            this.cmbGasto.DataSource = dataTable;
        }
    }
}
