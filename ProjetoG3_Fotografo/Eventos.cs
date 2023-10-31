using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoG3_Fotografo
{
    public partial class Eventos : Form
    {
        int month, year;
        public Eventos()
        {
            InitializeComponent();
        }


        #region Metodos
        public void MostrarDias()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;


            String NomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbData.Text = NomeMes + " " + year;

            //primeiro dia do mes
            DateTime ComecoSemana = new DateTime(year, month, 1);

            //contagem dos dias do mes
            int Dias = DateTime.DaysInMonth(year, month);

            int DiaSemana = Convert.ToInt32(ComecoSemana.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < DiaSemana; i++)
            {
                UserControlCampos ucCampos = new UserControlCampos();
                DatasContainer.Controls.Add(ucCampos);
            }

            for (int i = 1; i <= Dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.days(i);
                DatasContainer.Controls.Add(ucdias);
            }
        }
        #endregion

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            //limpa o conteiner

            DatasContainer.Controls.Clear();
            //passa os meses
            month++;

            String NomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbData.Text = NomeMes + " " + year;

            DateTime ComecoSemana = new DateTime(year, month, 1);

            //contagem dos dias do mes
            int Dias = DateTime.DaysInMonth(year, month);

            int DiaSemana = Convert.ToInt32(ComecoSemana.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < DiaSemana; i++)
            {
                UserControlCampos ucCampos = new UserControlCampos();
                DatasContainer.Controls.Add(ucCampos);
            }

            for (int i = 1; i <= Dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.days(i);
                DatasContainer.Controls.Add(ucdias);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            //limpa o conteiner

            DatasContainer.Controls.Clear();
            //passa os meses
            month--;

            String NomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbData.Text = NomeMes + " " + year;

            DateTime ComecoSemana = new DateTime(year, month, 1);

            //contagem dos dias do mes
            int Dias = DateTime.DaysInMonth(year, month);

            int DiaSemana = Convert.ToInt32(ComecoSemana.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < DiaSemana; i++)
            {
                UserControlCampos ucCampos = new UserControlCampos();
                DatasContainer.Controls.Add(ucCampos);
            }

            for (int i = 1; i <= Dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.days(i);
                DatasContainer.Controls.Add(ucdias);
            }
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            MostrarDias();
        }


    }
}
