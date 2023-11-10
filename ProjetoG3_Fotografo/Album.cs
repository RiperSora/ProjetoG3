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
    public partial class Album : Form
    {
        public Album()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region metodos
        public void btn_cliente()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
            this.Close();
        }
        public void btn_Eventos()
        {
            Evento2 eventos = new Evento2();
            eventos.Show();
            this.Close();
        }
        public void btn_Album()
        {
            Album album = new Album();  
            album.Show();
            this.Close();
        }
        public void btn_config()
        {
            Configuracao configuracao = new Configuracao();
            configuracao.Show();
            this.Close();
        }
        public void btn_addAlbum()
        {
            CadastrarAlbum cadastrarAlbum = new CadastrarAlbum();
            cadastrarAlbum.Show();
            this.Close();
        }

        public void excluir()
        {
            DAL.AlbumDAL usuarioDAL = new DAL.AlbumDAL();
            if (gridAlbum.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }
            else
            {
                DataGridViewRow selectedRow = gridAlbum.SelectedRows[0];
                usuarioDAL.ExcluirAlbum(Convert.ToInt32(selectedRow.Cells[0].Value));
                List<DAL.AlbumDAL> album = new DAL.AlbumDAL().ListarAlbum();
                BindingSource bs = new BindingSource();
                bs.DataSource = album;
                gridAlbum.DataSource = bs;
            }
        }

        public void grid_Album()
        {
            List<DAL.AlbumDAL> album = new DAL.AlbumDAL().ListarAlbum();
            BindingSource bs = new BindingSource();
            bs.DataSource = album;
            gridAlbum.DataSource = bs;
        }

        public void pesquisa(string categoria, string pesquisa)
        {
            string stringSql = DAL.AdmDAL.stringSQL;
            SqlConnection conn = new SqlConnection(stringSql);
            conn.Open();
            if (categoria == "")
            {
                categoria = "NomeAlbum";
                SqlCommand cmd = new SqlCommand("select * from Album where " + categoria + " like '%" + pesquisa + "%' order by datahoracadastro desc", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dr;
                    gridAlbum.DataSource = bs;
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from Album where " + categoria + " like '%" + pesquisa + "%' order by datahoracadastro desc", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dr;
                    gridAlbum.DataSource = bs;
                }
            }
        }
        #endregion


        private void bntCliente_Click(object sender, EventArgs e)
        {
            btn_cliente();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            btn_Eventos();
        }

        private void Album_Load(object sender, EventArgs e)
        {
            grid_Album();
            //List<DAL.AlbumDAL> album = new DAL.AlbumDAL().ListarAlbum();
            //BindingSource bs = new BindingSource();
            //bs.DataSource = album;
            //gridAlbum.DataSource = bs;
        }

        private void btnExcluirAlbum_Click(object sender, EventArgs e)
        {
            excluir();
            //DAL.AlbumDAL usuarioDAL = new DAL.AlbumDAL();
            //if (gridAlbum.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Selecione uma linha");
            //    return;
            //}
            //else
            //{
            //    DataGridViewRow selectedRow = gridAlbum.SelectedRows[0];
            //    usuarioDAL.ExcluirAlbum(Convert.ToInt32(selectedRow.Cells[0].Value));
            //    List<DAL.AlbumDAL> album = new DAL.AlbumDAL().ListarAlbum();
            //    BindingSource bs = new BindingSource();
            //    bs.DataSource = album;
            //    gridAlbum.DataSource = bs;
            //}
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            pesquisa(txtCategoria.Text,txtPesquisa.Text);
            //string stringSql = DAL.AdmDAL.stringSQL;
            //SqlConnection conn = new SqlConnection(stringSql);
            //conn.Open();
            //if (txtCategoria.Text == "")
            //{
            //    txtCategoria.Text = "NomeAlbum";
            //    SqlCommand cmd = new SqlCommand("select * from Album where " + txtCategoria.Text + " like '%" + txtPesquisa.Text + "%' order by datahoracadastro desc", conn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        BindingSource bs = new BindingSource();
            //        bs.DataSource = dr;
            //        gridAlbum.DataSource = bs;
            //    }
            //}
            //else
            //{
            //    SqlCommand cmd = new SqlCommand("select * from Album where " + txtCategoria.Text + " like '%" + txtPesquisa.Text + "%' order by datahoracadastro desc", conn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        BindingSource bs = new BindingSource();
            //        bs.DataSource = dr;
            //        gridAlbum.DataSource = bs;
            //    }
            //}
        }

        private void btnFotos_Click(object sender, EventArgs e)
        {
            btn_Album();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            btn_config();
        }

        private void btnCadastrarAlbum_Click(object sender, EventArgs e)
        {
            btn_addAlbum();
        }

        private void btnCadastrarAlbum2_Click(object sender, EventArgs e)
        {
            btn_addAlbum();
        }
    }
}
