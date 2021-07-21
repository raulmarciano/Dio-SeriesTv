namespace Dio_SeriesTv.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; private set; }
        public bool Deleted { get; private set; } = false;

        public void SetIdByInsert(int id)
            => Id = id;
        
        public void DeleteEntity()
            => Deleted = true;
    }
}