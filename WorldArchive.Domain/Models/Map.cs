using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class Map : EntityBase
    {
        public string? GoogleMap { get; set; }
        public string? OpenStreetMap { get; set; }
    }
}
