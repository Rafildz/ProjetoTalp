﻿using System;
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
    public partial class ClientePesquisa : Form
    {
        public ClientePesquisa()
        {
            InitializeComponent();
        }

        private void ClientePesquisa_Load(object sender, EventArgs e)
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
                    var sql = "SELECT IdCliente, Nome, Telefone, Email FROM Cliente ORDER BY IdCliente";

                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();

                    DataSet dt = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                    dtAdapter.Fill(dt);

                    this.dtGridCliente.DataSource = dt.Tables[0];
                    
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
                    var sql = "SELECT IdCliente, Nome, Telefone, Email FROM Cliente WHERE Nome LIKE '%@Nome%'";

                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Parameters.AddWithValue("@Nome", textBox1.Text);
                    sqlCommand.ExecuteNonQuery();

                    DataSet dt = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                    dtAdapter.Fill(dt);

                    this.dtGridCliente.DataSource = dt.Tables[0];
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
