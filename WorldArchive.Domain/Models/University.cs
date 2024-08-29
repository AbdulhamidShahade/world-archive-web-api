using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class University : EntityBase
    {
        public string Name { get; set; }
        public int NumberOfStudents { get; set; }
        public int Image { get; set; }

        public City City { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Actress> Actresses { get; set; }
        public List<Player> Players { get; set; }
    }
}
