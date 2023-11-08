﻿using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        try
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
        catch (SqlException ex)
        {
            Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
        }
        Console.ReadKey();
    }
}