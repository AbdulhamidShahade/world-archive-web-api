using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class Movie : EntityBase
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }

        public List<MovieLanguage> LanguagesByMovie { get; set; }

    }
}
