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
    }
}
