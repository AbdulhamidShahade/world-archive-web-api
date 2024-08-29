using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class Language : EntityBase
    {
        public string Name { get; set; }
        public int SpokenBy { get; set; }

        public List<CountryLanguage> Countries { get; set; }
        public List<MovieLanguage> Movies { get; set; }
    }
}
