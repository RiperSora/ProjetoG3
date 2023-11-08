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

namespace ProjetoG3_Fotografo
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscarData_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from Cliente", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource bs = new BindingSource();

            bs.DataSource = dr;
            gridEvento.DataSource = bs;

            
            if (dr.Read())
            {
                ColunaNome.HeaderText = dr["NomeCliente"].ToString();
                ColunaSenha.HeaderText = dr["Senha"].ToString();
                ColunaRG.HeaderText = dr["RG"].ToString();
                ColunaCpf.HeaderText = dr["CPF"].ToString();
                ColunaEndereco.HeaderText = dr["Endereco"].ToString();
                ColunaTel.HeaderText = dr["Telefone"].ToString();
                ColunaEmail.HeaderText = dr["Email"].ToString();
            }
        }
    }
}
