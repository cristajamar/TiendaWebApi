using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Repositorio.ViewModel;
using System.Data.Entity;

namespace Repositorio.Repositorio
{
    public class RepositorioEntity<TModelo, TviewModel> :
        IRepositorio<TModelo, TviewModel> where TModelo : class where TviewModel :
        IViewModel<TModelo>

    {
        private DbContext context;
        protected DbSet<TModelo> Dbset { get; set; }

        public RepositorioEntity(DbContext context)
        {
            this.context = context;
        }

        public int Actualizar(TviewModel model)
        {
            throw new NotImplementedException();
        }

        public TviewModel Add(TviewModel model)
        {
            throw new NotImplementedException();
        }     

        public ICollection<TviewModel> Borrar(Expression<Func<TModelo, bool>> consulta)
        {
            throw new NotImplementedException();
        }

        public int Borrar(TviewModel model)
        {
            throw new NotImplementedException();
        }

        public ICollection<TviewModel> Get()
        {
            throw new NotImplementedException();
        }

        public ICollection<TviewModel> Get(Expression<Func<TModelo, bool>> consulta)
        {
            throw new NotImplementedException();
        }

        public TviewModel Get(params object[] key)
        {
            throw new NotImplementedException();
        }
    }
}
