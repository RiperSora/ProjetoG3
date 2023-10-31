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
        int mes, ano;
        public Eventos()
        {
            InitializeComponent();
        }


        #region Metodos
        public void MostrarDias()
        {
            DateTime now = DateTime.Now;
            mes = now.Month;
            ano = now.Year;


            String NomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = NomeMes + " " + ano;

            //primeiro dia do mes
            DateTime ComecoSemana = new DateTime(ano, mes, 1);

            //contagem dos dias do mes
            int Dias = DateTime.DaysInMonth(ano, mes);

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
        
        public void AvancarMes()
        {
            //limpa o conteiner

            DatasContainer.Controls.Clear();
            //passa os meses
            mes++;

            String NomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = NomeMes + " " + ano;

            DateTime ComecoSemana = new DateTime(ano, mes, 1);

            //contagem dos dias do mes
            int Dias = DateTime.DaysInMonth(ano, mes);

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

        public void RetrocederMes()
        {
            //limpa o conteiner

            DatasContainer.Controls.Clear();
            //passa os meses
            mes--;

            String NomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = NomeMes + " " + ano;

            DateTime ComecoSemana = new DateTime(ano, mes, 1);

            //contagem dos dias do mes
            int Dias = DateTime.DaysInMonth(ano, mes);

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
            AvancarMes();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            RetrocederMes();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            MostrarDias();
        }


    }
}
