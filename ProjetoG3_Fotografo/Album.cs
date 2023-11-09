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
            this.Hide();
        }
        public void btn_Eventos()
        {
            Evento2 eventos = new Evento2();
            eventos.Show();
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

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            btn_Eventos();
        }

        private void Album_Load(object sender, EventArgs e)
        {

        }

        private void btnFotos_Click(object sender, EventArgs e)
        {
            btn_Album();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            btn_config();
        }
    }
}
