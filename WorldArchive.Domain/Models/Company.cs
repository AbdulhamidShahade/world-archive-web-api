using System;
using System.Collections.Generic;
using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class Company : EntityBase
    {
        public string Name { get; set; }
        public int NumberOfWorkers { get; set; }


        public int CityId { get; set; }
        public City City { get; set; }
    }
}
