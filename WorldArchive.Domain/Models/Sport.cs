using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class Sport : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }


        public List<Player> PlayersBySport { get; set; }
    }
}
