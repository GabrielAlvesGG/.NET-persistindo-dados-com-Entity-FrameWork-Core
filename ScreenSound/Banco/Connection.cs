using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class Connection
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public SqlConnection ObterConexao() { 
            return new SqlConnection(connectionString);
        }

        public IEnumerable<Artista> Listar()
        {
            List<Artista> lista = new List<Artista>();
            using var connection = ObterConexao();
            connection.Open();

            string slq = "SELECT * FROM Artistas";
            SqlCommand command = new SqlCommand(slq, connection);
            using SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int idArtista = Convert.ToInt32(dataReader["Id"]);
                string bioArtista = Convert.ToString(dataReader["Bio"]);
                string nomeArtista = Convert.ToString(dataReader["Nome"]);
                Artista artista = new Artista(nomeArtista, bioArtista) { Id = idArtista};

                lista.Add(artista);
            }

            return lista;

    }
    }


    
}
