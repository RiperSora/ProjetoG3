using System;
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
    public partial class EventoCalendario : Form
    {
        public EventoCalendario()
        {
            InitializeComponent();
        }

        #region Metodos
        public void SalvarEvento(string data, string evento)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Calendario('" + data + "','" + evento + "')", conn);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();

        }
        #endregion
        private void EventoCalendario_Load(object sender, EventArgs e)
        {
            int dia = Convert.ToInt32(UserControlDias.static_dia);
            int mes = Eventos.static_mes;
            int ano = Eventos.static_ano;

            TxtData.Text = dia + "/" + Eventos.static_mes + "/" + Eventos.static_ano;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarEvento(TxtData.Text,TxtData.Text);
            MessageBox.Show("Evento Salvo");
        }
    }
}
