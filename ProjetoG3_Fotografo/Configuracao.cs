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

        #endregion

        private void bntCliente_Click(object sender, EventArgs e)
        {
            btn_cliente();
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            btn_Evento();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            btn_Album();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            btn_config();
        }
    }
}
