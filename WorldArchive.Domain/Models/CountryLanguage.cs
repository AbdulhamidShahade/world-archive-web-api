using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class CountryLanguage : EntityBase
    {
        public int CountryId { get; set; }
        public Country Country { get; set; }


        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
