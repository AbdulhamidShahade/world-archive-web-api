using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    internal class MovieActor : EntityBase
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }



        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
