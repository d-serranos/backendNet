using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace backendNet.Core.Interfaces.Repositories
{
    public interface IBaseRepositorio<TEntity> where TEntity : class
    {
        ValueTask<TEntity> GetbyIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includePropertie = "");
        Task<TEntity> SimpleOPorDefectoAsync(Expression<Func<TEntity, bool>> predicate);

        Task AgregarAsync(TEntity entity);
        Task AgregarRangosAsync(IEnumerable<TEntity> entities);
        void Eliminar(TEntity entity);
        void EliminarRango(IEnumerable<TEntity> entities);
        Task Actualizar(TEntity entity);
        Task ActualizarRango(IEnumerable<TEntity> entities);

    }
}
