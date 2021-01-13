using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{
   public class GenericManager<T>
        where T: class
    {
        /// <summary>
        /// Contexto de datos
        /// </summary>
        public ApplicationDbContext Context { get; private set; }

        /// <summary>
        /// Clase Constructora
        /// </summary>
        /// <param name="context"></param>
        public GenericManager(ApplicationDbContext context)
        {
            Context = context;
        }
        /// <summary>
        /// Añade una entidad al contexto
        /// </summary>
        /// <param name="entity">La entidad a añadir</param>
        /// <returns>La entidad Añadida</returns>
        public T Add(T entity)
        {
            return Context.Set<T>().Add(entity);
        }


        /// <summary>
        /// Elimina una entidad al contexto
        /// </summary>
        /// <param name="entity">La entidad a eliminar</param>
        /// <returns>La entidad eliminada</returns>
        public T Remove(T entity)
        {
            return Context.Set<T>().Remove(entity);
        }

        /// <summary>
        /// Busca una entidad por su clave int
        /// </summary>
        /// <param name="entity">Identificador</param>
        /// <returns>Entidad si es encontrada</returns>
        public T GetById(object[] key)
        {
            return Context.Set<T>().Find(key);
        }

        /// <summary>
        /// Obtiene una entidad por su clave int
        /// </summary>
        /// <param name="entity">Identificador</param>
        /// <returns>Entidad si es encontrada</returns>
        public T GetById(int id)
        {
            return GetById(new object[] { id });
        }

    }
}
