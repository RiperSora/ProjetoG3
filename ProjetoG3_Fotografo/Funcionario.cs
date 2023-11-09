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

        #region metodos
        public void btn_cliente()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
            this.Hide();
        }
        public void btn_Evento()
        {
            Evento2 evento2 = new Evento2();
            evento2.Show();
            this.Hide();
        }
        public void btn_Album()
        {
            Album album = new Album();
            album.Show();
            this.Hide();
        }
        public void btn_config()
        {
            Configuracao configuracao = new Configuracao();
            configuracao.Show();
            this.Hide();
        }
        public void addCliente()
        {

        }
        #endregion

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.Show();
            this.Hide();
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
            btn_Evento();
        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {}

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            btn_Album();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            addCliente();
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

        private void bntCliente_Click(object sender, EventArgs e)
        {
            btn_cliente();
        }

        private void btnCadastrarCliente2_Click(object sender, EventArgs e)
        {
            addCliente();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            btn_config();
        }
    }
}
