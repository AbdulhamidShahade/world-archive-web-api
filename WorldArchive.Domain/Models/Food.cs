using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class Food : EntityBase
    {
        public string Name { get; set; }
        public City City { get; set; }
    }
}
