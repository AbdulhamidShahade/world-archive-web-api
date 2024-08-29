using System;
using System.Collections.Generic;
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

        //reversed: LastName + FirstName
        public abstract string GetFullName(bool reversed = false);

    }
}
