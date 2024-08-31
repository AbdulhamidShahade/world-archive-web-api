using System.ComponentModel.DataAnnotations.Schema;

namespace WorldArchive.Domain.Models
{
    public class Actress : Person
    {
        [NotMapped]
        public override int Age
        {
            get
            {
                var today = DateTime.Today;

                var age = today.Year - BirthDate.Year;

                if (BirthDate.Date > today.AddYears(-age)) age--;

                return age;
            }
        }

        public override string GetFullName(bool reversed = false)
        {
            return (reversed) ? LastName + " " + FirstName : FirstName + " " + LastName;
        }

        public List<MovieActress> Movies { get; set; }


        
    }
}
