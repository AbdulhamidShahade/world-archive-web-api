using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class MovieLanguage : EntityBase
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }


        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
