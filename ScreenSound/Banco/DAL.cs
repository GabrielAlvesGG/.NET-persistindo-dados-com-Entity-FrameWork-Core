using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal abstract class DAL<T> where T : class
    {
        protected readonly ScreenSoundContext context;

        protected DAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public  IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList();
        }

        public  void Add(T objeto)
        {
            try
            {
                context.Set<T>().Add(objeto);
                context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(T objeto)
        {
            try
            {
                context.Set<T>().Remove(objeto);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Atualizar(T objeto)
        {
            try
            {
                context.Set<T>().Update(artista);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
