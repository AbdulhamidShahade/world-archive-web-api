using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class MovieActress : EntityBase
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }


        public int ActressId { get; set; }
        public Actress Actress { get; set; }

    }
}
