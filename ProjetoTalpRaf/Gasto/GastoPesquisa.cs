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
    public partial class GastoPesquisa : Form
    {
        public GastoPesquisa()
        {
            InitializeComponent();
        }

        private void GastoPesquisa_Load(object sender, EventArgs e)
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
                    sqlCommand.ExecuteNonQuery();

                    DataSet dt = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                    dtAdapter.Fill(dt);

                    this.dtGridGastos.DataSource = dt.Tables[0];
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = @"SELECT IdGastos, Tipo, Preco FROM Gasto WHERE Tipo LIKE '%@Tipo%' ";

                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Parameters.AddWithValue("@Tipo", textBox1.Text);
                    sqlCommand.ExecuteNonQuery();

                    DataSet dt = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                    dtAdapter.Fill(dt);

                    this.dtGridGastos.DataSource = dt.Tables[0];
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
    }
}
