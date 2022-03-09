using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public class EFWaterProjectRepository : iWaterProjectRepository
    {

        private WaterProjectContext context { get; set; }

        public EFWaterProjectRepository (WaterProjectContext temp)
        {
            context = temp;
        }
        public IQueryable<Project> Projects => context.Projects;
    }
}
