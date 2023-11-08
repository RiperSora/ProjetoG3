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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text) || string.IsNullOrWhiteSpace(TxtSenha.Text) || string.IsNullOrWhiteSpace(TxtRg.Text) || string.IsNullOrWhiteSpace(TxtCpf.Text) || string.IsNullOrWhiteSpace(TxtEndereco.Text) || string.IsNullOrWhiteSpace(TxtTel.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar o cliente.");
            }
            else
            {
                DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
                clienteDAL.CadastrarCliente(TxtNome.Text, TxtSenha.Text, TxtRg.Text, TxtCpf.Text, TxtEndereco.Text, TxtTel.Text, TxtEmail.Text);
            }
        }
    }
}
