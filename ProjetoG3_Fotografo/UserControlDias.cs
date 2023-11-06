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
    public partial class UserControlDias : UserControl
    {
        public static string static_dia;
        public UserControlDias()
        {
            InitializeComponent();
        }

        private void UserControlDias_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbDias.Text = numday + "";
        }

        private void UserControlDias_Click(object sender, EventArgs e)
        {
            static_dia = lbDias.Text;
            EventoCalendario eventoCalendario = new EventoCalendario();
            eventoCalendario.Show();
        }

        //public void MostrarEvento()
        //{
        //    MySqlConnection conn = new MySqlConnection(connString);
        //    conn.Open();

        //    string sql = "select *from Calendario where DataCalendario=?";
        //    SqlConnection cmd = conn.CreateCommand();
        //    cmd.commandText = sql;
        //    cmd.Parameters.AddWithValue("DataCalendario", UserControlDias.static_dia + "/" + Eventos.static_mes + "/" + Eventos.static_ano);
        //    MySqlConnection reader = cmd.ExecuteReader(); 
        //}
    }
}
