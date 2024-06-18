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
            List<Artista> lista = new List<Artista>();
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string slq = "SELECT * FROM Artistas";
            SqlCommand command = new SqlCommand(slq, connection);
            using SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int idArtista = Convert.ToInt32(dataReader["Id"]);
                string bioArtista = Convert.ToString(dataReader["Bio"]);
                string nomeArtista = Convert.ToString(dataReader["Nome"]);
                Artista artista = new Artista(nomeArtista, bioArtista) { Id = idArtista };

                lista.Add(artista);
            }

            return lista;

        }

        public static void AddArtista(Artista artista)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@nome", artista.Nome);
            command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
            command.Parameters.AddWithValue("@bio", artista.Bio);

            int retorno = command.ExecuteNonQuery();

            Console.WriteLine($"Linhas afetadas: {retorno}");
        }
        public static string DeleteArtista(int id)
        {
            try
            {
                using var connection = new Connection().ObterConexao();
                connection.Open();

                string sql = $"DELETE FROM Artistas WHERE Id={id}";

                SqlCommand command = new SqlCommand(sql, connection);

                int executeCount =  command.ExecuteNonQuery();

                return $"Excluído com sucesso. Linhas afetadas: {executeCount}";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public  string UpdateArtista(Artista artista)
        {
            try
            {
                var connection = new Connection().ObterConexao();
                connection.Open();

                string sql = $"UPDATE Artistas SET  Nome='{artista.Nome}', Bio='{artista.Bio}' WHERE Id={artista.Id} ";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@nome", artista.Nome);
                command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
                command.Parameters.AddWithValue("@bio", artista.Bio);

               int returnValue = command.ExecuteNonQuery();



                return $"Atualizado com sucesso. Linhas afetadas: {returnValue}";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
