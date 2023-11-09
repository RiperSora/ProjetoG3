using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoG3_Fotografo.DAL
{
    public class AlbumDAL
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdCliente { get; set; }

        public void CadastrarAlbum(string nome, string descricao, int idCliente)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                string stringSql = AdmDAL.stringSQL;
                conn = new SqlConnection(stringSql);
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Album VALUES ('" + nome + "','" + descricao + "',  getdate() ," + idCliente+ ");", conn);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public void ExcluirAlbum(string nome)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                string stringSql = AdmDAL.stringSQL;
                conn = new SqlConnection(stringSql);
                conn.Open();
                cmd = new SqlCommand("delete from Album where NomeAlbum = '" + nome+"'", conn);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public void AtualizarAlbum(int id, string nome, string descricao, int idCliente)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                string stringSql = AdmDAL.stringSQL;
                conn = new SqlConnection(stringSql);
                conn.Open();
                cmd = new SqlCommand("update Album set NomeAlbum='" + nome + "', Descricao='" + descricao + "', DataHoraCadastro= getdate(), FkCliente= "+idCliente+ " WHERE IdAlbum =" + id, conn);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
    }
}