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
    public partial class GastoExcluir : Form
    {
        public GastoExcluir()
        {
            InitializeComponent();
        }

        private void GastoExcluir_Load(object sender, EventArgs e)
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

        private void preencherCombo(DataTable dataTable)
        {
            this.cmbGasto.DisplayMember = "IdGastos";
            this.cmbGasto.ValueMember = "IdGastos";
            this.cmbGasto.DataSource = dataTable;
        }

        private void cmbGasto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValor.Text = cmbGasto.SelectedValue.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = @"DELETE FROM Gasto WHERE IdGastos = @IdGastos";


                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Parameters.AddWithValue("@IdGastos", lblValor.Text);
                    sqlCommand.ExecuteNonQuery();


                    DataSet dt = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                    dtAdapter.Fill(dt);

                    //this.dtGridGasto.DataSource = dt.Tables[0];
                    //preencherCombo(dt.Tables[0]);

                    lblValor.Text = "Excluido com sucesso!";

                    preencherGrid();
                }
                catch (Exception ex)
                {
                    lblValor.Text = "Erro ao excluir!";
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
