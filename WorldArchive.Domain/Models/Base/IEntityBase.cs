﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldArchive.Domain.Models.Base
{
    public interface IEntityBase
    {
        int Id { get; set; }
        DateTime CreatedAt { get; }
        DateTime? UpdatedAt { get; }
    }
}
