using Dio_SeriesTv.Enum;

namespace Dio_SeriesTv.Entities
{
    public class Series : EntityBase
    {
        public string Name { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Year { get; private set; }
        public EGenero Genre { get; private set; }

        public Series(string name, string title, string description, int year)
        {
            Name = name;
            Title = title;
            Description = description;
            Year = year;
        }



    }
}