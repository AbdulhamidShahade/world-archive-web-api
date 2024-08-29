using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class Region : EntityBase
    {
        public string Name { get; set; }


        public List<Country> CountriesByRegion { get; set; }
    }
}
