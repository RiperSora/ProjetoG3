using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoG3_Fotografo
{
    public partial class Configuracao : Form
    {
        public Configuracao()
        {
            InitializeComponent();
        }

        #region metodos
        public void btnClientes()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
            this.Close();
        }

        public void btnEventos()
        {
            Evento2 evento2 = new Evento2();
            evento2.Show();
            this.Close();
        }

        public void btnAlbums()
        {
            Album album = new Album();
            album.Show();
            this.Close();
        }

        public void btnConfigs()
        {
            Configuracao configuracao = new Configuracao();
            configuracao.Show();
            this.Close();
        }
        #endregion

        private void bntCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            btnEventos();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            btnAlbums();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            btnConfigs();
        }

        private void bntCliente_Click_1(object sender, EventArgs e)
        {
            btnClientes();
        }

        private void btnAtualizarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
