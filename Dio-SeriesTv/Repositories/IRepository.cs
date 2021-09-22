using System.Collections.Generic;

namespace Dio_SeriesTv.Repositories
{
    public interface IRepository<T>
    {
        public List<T> ListRepository();
        public T ReturnById(int id);
        public void Insert(T entity);
        public void Delete(int id);
        public void Update(int id, T entity);
        public int NextId();
    }
}