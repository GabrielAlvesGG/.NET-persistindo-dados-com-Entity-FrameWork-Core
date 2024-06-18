using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
        private readonly ScreenSoundContext context;

        public ArtistaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public IEnumerable<Artista> Listar()
        {
            return context.Artistas.ToList();
        }

        public void AddArtista(Artista artista)
        {
            try
            {
                context.Artistas.Add(artista);
                context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public void DeleteArtista(Artista artista)
        {
            try
            {
                context.Artistas.Remove(artista);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateArtista(Artista artista)
        {
            try
            {
                context.Artistas.Update(artista);
                context.SaveChanges ();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Artista RecuperarPeloNome(string nome)
        {
            return context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome));
            
        }
    }
}
