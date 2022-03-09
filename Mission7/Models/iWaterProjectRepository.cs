﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public interface iWaterProjectRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
