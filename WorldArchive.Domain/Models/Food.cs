using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldArchive.Domain.Models.Base;

namespace WorldArchive.Domain.Models
{
    public class Food : EntityBase
    {
        public string Name { get; set; }
        public City City { get; set; }
        decimal Price { get; set; }
    }
}
