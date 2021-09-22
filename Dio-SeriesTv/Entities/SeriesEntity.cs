using System;
using Dio_SeriesTv.Enums;

namespace Dio_SeriesTv.Entities
{
    public class SeriesEntity : EntityBase
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Year { get; private set; }
        public EGenre Genre { get; private set; }

        public SeriesEntity(string title, string description, int year, EGenre genre)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
        }

        public string ReturnTitle()
            => Title;

        public override string ToString()
            => $@"Gênero: {Genre}
Título: {Title}
Descrição: {Description}
Ano de Inicio: {Year}
Excluído: {(Deleted ? "Sim" : "Não")}";
    }
}