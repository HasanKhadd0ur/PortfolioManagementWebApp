using cleanArchWebApp.ApplicationCore.Enities;
using cleanArchWebApp.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using cleanArchWebApp.WebPresentation.ViewModel;
namespace cleanArchWebApp.WebPresentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<Project> _projects;

        public HomeController(IUnitOfWork<Owner> owner 
                            , IUnitOfWork<Project> projects )
        {
            _owner = owner;
            _projects = projects;

        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll(p=>p.Address).First(),
                Projects = _projects.Entity.GetAll(p=>p.Owner)

            };

            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
