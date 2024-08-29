using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldArchive.Domain.Models.Base
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get => DateTime.UtcNow; }
        public DateTime? UpdatedAt { get => DateTime.UtcNow; }
    }
}
