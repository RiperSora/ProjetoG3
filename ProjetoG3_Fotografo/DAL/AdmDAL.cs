using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoG3_Fotografo.DAL
{
    public class AdmDAL
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }

        public AdmDAL EfetuarLogin(string nome, string senha)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Administrador where NomeAdministrador='" + nome + "' AND Senha ='" + senha + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            AdmDAL usuario = new AdmDAL();
            if (dr.Read())
            {
                usuario.Id = Convert.ToInt32(dr["IdAdministrador"]);
                usuario.Nome = (string)dr["NomeAdministrador"];
                usuario.Senha = (string)dr["Senha"];
            }
            return usuario;
        }
    }
}
