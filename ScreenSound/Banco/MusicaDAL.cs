using ScreenSound.Menus;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
	
    internal class MusicaDAL
    {
        private readonly ScreenSoundContext context;
        public MusicaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }
        public IEnumerable<Musica> ListarMusicas()
        {
			try
			{
				return context.Musicas.ToList();
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		public void AddMusica(Musica musica)
		{
			try
			{
				context.Musicas.Add(musica);
				context.SaveChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public void AtualizarMusica(Musica musica)
		{
			try
			{
				context.Musicas.Update(musica);
				context.SaveChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public void ExcluirMusica(Musica musica)
		{
			try
			{
				context.Musicas.Remove(musica);
				context.SaveChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
    }
}
