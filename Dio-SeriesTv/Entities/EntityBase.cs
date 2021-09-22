namespace Dio_SeriesTv.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
        public bool Deleted { get; protected set; } = false;

        public int SetId(int id)
            => Id = id;
        
        public void DeleteEntity()
            => Deleted = true;
    }
}