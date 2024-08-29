using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class City : EntityBase
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public Map Map { get; set; }
        public Country Country { get; set; }


        public List<University> Universities { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Actress> Actress { get; set; }
        public List<Company> Companies { get; set; }
        public List<Food> Foods { get; set; }
        public List<Player> Players { get; set; }
    }
}
