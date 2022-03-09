using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission7.Models;

namespace Mission7.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private iWaterProjectRepository repo { get; set; }

        public TypesViewComponent (iWaterProjectRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["projectType"];

            var types = repo.Projects
                .Select(x => x.ProjectType)
                .Distinct()
                .OrderBy(x => x);


            return View(types);
        }
    }
}
