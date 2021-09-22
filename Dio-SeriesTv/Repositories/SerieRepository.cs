using System.Collections.Generic;
using System.Linq;
using Dio_SeriesTv.Entities;

namespace Dio_SeriesTv.Repositories
{
    public class SerieRepository : IRepository<SeriesEntity>
    {
        private List<SeriesEntity> ListSerie = new List<SeriesEntity>();

        public void Delete(int id)
            => ListSerie.FirstOrDefault(x => x.Id == id).DeleteEntity();

        public void Insert(SeriesEntity entity)
        {
            entity.SetId(NextId());
            ListSerie.Add(entity);
        }

        public List<SeriesEntity> ListRepository()
            => ListSerie;

        public int NextId()
        {
            var maxId = ListSerie.Select(x => x.Id);
            return maxId.Count() == 0 ? 0 : maxId.Max();
        }

        public SeriesEntity ReturnById(int id)
            => ListSerie.FirstOrDefault(x => x.Id == id);

        public void Update(int id, SeriesEntity entity)
            => ListSerie[id] = entity;
    }
}