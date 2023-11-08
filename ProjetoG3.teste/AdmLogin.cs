using System;
using System.Data.SqlClient;

class AdmLogin
{
    static void Main(string[] args)
    {
        string nome = "Wesley";
        string senha = "123";
        ProjetoG3_Fotografo.DAL.AdmDAL usuario = new ProjetoG3_Fotografo.DAL.AdmDAL().EfetuarLogin(nome, senha);
        if (usuario.Nome != null && usuario.Senha != null)
        {
            Console.WriteLine("Adm logado com sucesso.");
        }
        else
        {
            Console.WriteLine("Adm não encontrado.");
        }
    }
}
