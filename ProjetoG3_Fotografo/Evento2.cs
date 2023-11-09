﻿using System;
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
    public partial class Evento2 : Form
    {
        public Evento2()
        {
            InitializeComponent();
        }

        string connString = @"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string connCasa = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ClickProducoesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;\r\n";

        #region metodos

        public void dadosEvento()
        {
            SqlConnection conn = new SqlConnection(connCasa);

            conn.Open();

            SqlCommand cmd = new SqlCommand("Select *from Calendario", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            BindingSource bs = new BindingSource();

            bs.DataSource = dr;

            gridEventos.DataSource = bs;

        }

        public void RemoverEvento()
        {
            int idEvento = Convert.ToInt32(gridEventos.CurrentRow.Cells["idEvento"].Value);

            using (SqlConnection conn = new SqlConnection(connCasa))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Calendario WHERE idEvento = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idEvento);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        gridEventos.Rows.Remove(gridEventos.CurrentRow);

                    }
                }
                conn.Close();
            }
        }
        #endregion


        private void Evento2_Load(object sender, EventArgs e)
        {
            dadosEvento();
        }

        private void BtnAddEvento_Click(object sender, EventArgs e)
        {
            CriarEvento2 criarEvento2 = new CriarEvento2();
            criarEvento2.Show();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            RemoverEvento();
        }
    }
}