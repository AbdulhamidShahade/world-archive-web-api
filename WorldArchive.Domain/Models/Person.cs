using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public abstract class Person : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int? Height { get; set; }
        public abstract int Age { get; }

        public int CityId { get; set; }
        public City City { get; set; }


        //reversed: LastName + FirstName
        public abstract string GetFullName(bool reversed = false);


        public int UniversityId { get; set; }
        public University University { get; set; }

    }
}
