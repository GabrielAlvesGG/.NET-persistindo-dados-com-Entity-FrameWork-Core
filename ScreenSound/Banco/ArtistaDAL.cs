using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL
    {
        public IEnumerable<Artista> Listar()
        {

            using var context = new ScreenSoundContext();

            return context.Artistas.ToList();

        }

        //public static void AddArtista(Artista artista)
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";

        //    SqlCommand command = new SqlCommand(sql, connection);

        //    command.Parameters.AddWithValue("@nome", artista.Nome);
        //    command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        //    command.Parameters.AddWithValue("@bio", artista.Bio);

        //    int retorno = command.ExecuteNonQuery();

        //    Console.WriteLine($"Linhas afetadas: {retorno}");
        //}
        //public static string DeleteArtista(int id)
        //{
        //    try
        //    {
        //        using var connection = new ScreenSoundContext().ObterConexao();
        //        connection.Open();

        //        string sql = $"DELETE FROM Artistas WHERE Id={id}";

        //        SqlCommand command = new SqlCommand(sql, connection);

        //        int executeCount =  command.ExecuteNonQuery();

        //        return $"Excluído com sucesso. Linhas afetadas: {executeCount}";

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public  string UpdateArtista(Artista artista)
        //{
        //    try
        //    {
        //        var connection = new ScreenSoundContext().ObterConexao();
        //        connection.Open();

        //        string sql = $"UPDATE Artistas SET  Nome='{artista.Nome}', Bio='{artista.Bio}' WHERE Id={artista.Id} ";

        //        SqlCommand command = new SqlCommand(sql, connection);

        //        command.Parameters.AddWithValue("@nome", artista.Nome);
        //        command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        //        command.Parameters.AddWithValue("@bio", artista.Bio);

        //       int returnValue = command.ExecuteNonQuery();



        //        return $"Atualizado com sucesso. Linhas afetadas: {returnValue}";
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
