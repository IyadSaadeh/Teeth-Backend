﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teeth.Domain.Interfaces
{
    public interface IAuditableEntity
    {
        DateTime CreatedAt { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedAt { get; set; }
        string UpdatedBy { get; set; }
        bool IsDeleted { get; set; }
        bool IsActived { get; set; }
    }

}
