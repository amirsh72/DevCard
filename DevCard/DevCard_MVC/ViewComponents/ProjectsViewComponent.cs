using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
            new Project(1,"تاکسی","سفارش تاکسی","project-1.jpg","atriya"),
            new Project(2, "غذا", "سفارش غذا","project-2.jpg","atriya"),
            new Project(3, "تاکسی", "سفارش تاکسی","project-3.jpg", "atriya"),
            new Project(4, "تاکسی", "سفارش تاکسی","project-4.jpg", "atriya"),
            };





            return View("_Projects", projects);
        }
    }
}
