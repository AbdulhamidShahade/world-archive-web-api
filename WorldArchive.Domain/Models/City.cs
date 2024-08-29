using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class City : EntityBase
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public Map Map { get; set; }
        public Country Country { get; set; }


        public List<University> UniversitesByCity { get; set; }
    }
}
