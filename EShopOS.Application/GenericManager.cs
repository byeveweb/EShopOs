using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{
    //Clase Genérica del Manager
    public class GenericManager<T>
        where T : class
    {
        /// <summary>
        /// Contexto de datos del manager
        /// </summary>
        public ApplicationDbContext Context { get; private set; }

        /// <summary>
        /// Constructor del manager
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public GenericManager(ApplicationDbContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Añade una entidad al contexto de datos
        /// </summary>
        /// <param name="entity">Entidad a añadir</param>
        /// <returns>Entidad Añadida</returns>
        public T Add(T entity)
        {
            return Context.Set<T>().Add(entity);
        }

        /// <summary>
        /// Eliminar una entidad al contexto de datos
        /// </summary>
        /// <param name="entity">Entidad a eliminar</param>
        /// <returns>Entidad Elimina</returns>
        public T Remove(T entity)
        {
            return Context.Set<T>().Remove(entity);
        }



        /// <summary>
        /// Obtenemos una entidad por sus posibles claves
        /// </summary>
        /// <param name="entity">Claves por objetos</param>
        /// <returns>Entidad si es encontrada</returns>
        public T GetById(object[] key)
        {
            return Context.Set<T>().Find(key);
        }

        /// <summary>
        /// Obtenemos una entidad por su clave int
        /// </summary>
        /// <param name="entity">Id</param>
        /// <returns>Entidad si es encontrada</returns>


        public T GetById(int id)
        {
            return GetById(new object[] { id });
        }

    }
}
