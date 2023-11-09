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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource bs = new BindingSource();

            bs.DataSource = dr;
            gridCliente.DataSource = bs;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Eventos eventos = new Eventos();
            eventos.Show();
            this.Hide();
        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {}

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            album.Show();
            this.Hide();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE NomeDoCliente LIKE '" + guna2TextBox1.Text + "%'", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource bs = new BindingSource();

            bs.DataSource = dr;
            gridCliente.DataSource = bs;
        }
    }
}
