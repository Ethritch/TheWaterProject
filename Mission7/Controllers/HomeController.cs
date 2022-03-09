using Microsoft.AspNetCore.Mvc;
using Mission7.Models;
using Mission7.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Controllers
{
    public class HomeController : Controller
    {


        private iWaterProjectRepository repo;

        public HomeController (iWaterProjectRepository temp)
        {
            repo = temp;
        }




        //private WaterProjectContext context { get; set; }

        //public HomeController (WaterProjectContext temp)
        //{
        //    context = temp;
        //}
        //same the two above (public and private function = the lambda view
        //public HomeController(WaterProjectContext temp) => context = temp;



        public IActionResult Index(string projectType, int pageNum = 1)
        {

            int pageSize = 5;

            var x = new ProjectsViewModel
            {
                Projects = repo.Projects
                .Where(p => p.ProjectType == projectType || projectType == null)
                .OrderBy(p => p.ProjectName)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumProjects = (projectType == null 
                    ? repo.Projects.Count()
                    : repo.Projects.Where(x => x.ProjectType == projectType).Count()),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

          

            return View(x);
        }

        
    }
}
