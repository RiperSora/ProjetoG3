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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoG3_Fotografo
{
    public partial class CriarEvento2 : Form
    {
        string connString = @"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string connCasa = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ClickProducoesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;\r\n";
        public CriarEvento2()
        {
            InitializeComponent();
        }

        #region Metodo
        public void CriarEvento(string evento,string Hora, string Data)
        {
            DAL.EventoDal eventoDal = new DAL.EventoDal();
            eventoDal.CriarEvento(evento,Hora, Data);
        }
        #endregion

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string data = CbMes.Text + "/" + CbMes.Text + "/" + CbAno.Text;
            string hora = CbHora.Text + ":" + CbMin.Text;
            CriarEvento(TxtEvento.Text,hora ,data);

            MessageBox.Show("Novo Evento Salvo");

            this.Close();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
