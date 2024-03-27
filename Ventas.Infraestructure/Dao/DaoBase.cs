using Microsoft.EntityFrameworkCore;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Dao
{
    public abstract class DaoBase<TEntity> : IDaoBase<TEntity> where TEntity : class
    {
        public readonly VentasContext context;
        private DbSet<TEntity> entities;

        public DaoBase(VentasContext context)
        {
            this.context = context;
            entities = context.Set<TEntity>();
        }
        public virtual async Task<int> Commit()
        {
            return this.context.SaveChanges();
        }

        public bool Exists(Func<TEntity, bool> filter)
        {
            return this.entities.Any(filter);
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return entities.ToList();
        }

        public async Task<TEntity> GetById(int id)
        {
            return entities.Find(id);
        }

        public async virtual Task<List<TEntity>> GetTentitiesWithFilters(Func<TEntity, bool> filter) => this.entities.Where(filter).ToList();

        public async virtual Task<DataResult> Save(TEntity entity)
        {
            DataResult result = new DataResult();

            this.entities.Add(entity);

            await this.Commit();

            result.Success = true;

            return result;
        }

        public async Task<DataResult> Update(TEntity entity)
        {
            DataResult result = new DataResult();

            this.entities.Update(entity);

            await this.Commit();

            result.Success = true;

            return result;
        }
    }
}
