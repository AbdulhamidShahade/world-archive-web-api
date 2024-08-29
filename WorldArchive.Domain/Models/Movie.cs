using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class Movie : EntityBase
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public List<MovieLanguage> Languages { get; set; }
        public List<MovieActor> Actors { get; set; }
        public List<MovieActress> Actresses { get; set; }
    }
}
