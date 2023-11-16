﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoG3_Fotografo
{
    public partial class CadastrarAlbum : Form
    {
        public CadastrarAlbum()
        {
            InitializeComponent();
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
        public void btn_logout()
        {
            AtualizarAlbum atualizarAlbum = new AtualizarAlbum();
            atualizarAlbum.Show();
            this.Hide();
        }
        public void cadastrarAlbum()
        {
            try
            {
                DAL.AlbumDAL AlbumDAL = new DAL.AlbumDAL();
                AlbumDAL.CadastrarAlbum(txtNomeAlbum.Text, txtDescricaoAlbum.Text, Convert.ToInt32(txtIdCliente.Text));
                if (AlbumDAL != null)
                {
                    MessageBox.Show("ALbum cadastrado com sucesso.");
                }
                else
                {
                    MessageBox.Show("ALbum não cadastrado.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }
        }
        #endregion

        #region terror
        private void bntCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            
        }

        private void bntCliente_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnEvento_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnAlbum_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnConfiguracao_Click_1(object sender, EventArgs e)
        {
            
        }
        #endregion

        private void btnCadastrarAlbum_Click(object sender, EventArgs e)
        {
            cadastrarAlbum();
        }

        private void bntCliente_Click_2(object sender, EventArgs e)
        {
            btn_cliente();
        }

        private void btnEvento_Click_2(object sender, EventArgs e)
        {
            btn_Eventos();
        }

        private void btnAlbum_Click_2(object sender, EventArgs e)
        {
            btn_Album();
        }

        private void btnConfiguracao_Click_2(object sender, EventArgs e)
        {
            btn_config();
        }

        private void fotoPerfil_Click(object sender, EventArgs e)
        {
            btn_logout();
        }
    }
}
