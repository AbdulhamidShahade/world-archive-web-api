using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class Language : EntityBase
    {
        public string Name { get; set; }
        public int SpokenBy { get; set; }

        public List<CountryLanguage> CountriesSpokenByLanguage { get; set; }
        public List<MovieLanguage> MoviesByLanguage { get; set; }
    }
}
