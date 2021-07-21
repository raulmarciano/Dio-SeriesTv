using System.Collections.Generic;
using System.Linq;
using Dio_SeriesTv.Entities;

namespace Dio_SeriesTv.Repositories
{
    public abstract class Repository<> : IRepository<T> where T : new()
    {
        private List<T> ListEntity { get; }

        public Repository()
            => ListEntity = new();

        public void Delete(int id)
        {
            var entity = ListEntity.Where(e => e.Id == id).FirstOrDefault();

            if(entity != null)
                entity.DeleteEntity();
        }

        public void Insert(T entity)
        {
            entity.SetIdByInsert(NextId());
            ListEntity.Add(entity);
        }

        public List<T> ListRepository()
            => ListEntity;

        public int NextId()
            => ListEntity.Max(e => e.Id) + 1;

        public T ReturnById(int id)
            => ListEntity.Where(e => e.Id == id).FirstOrDefault();

        public void Update(int id, T entity)
        {
            var entityModified = ReturnById(id);

            if(entityModified != null)
                entityModified = entity;
        }

    }
}