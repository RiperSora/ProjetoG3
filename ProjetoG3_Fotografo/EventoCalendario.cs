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
        public void SalvarEvento()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Calendario values('" + TxtData.Text + "','" + TxtEvento.Text + "')", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        #endregion
        private void EventoCalendario_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarEvento();
            MessageBox.Show("Evento Salvo");
        }
    }
}
