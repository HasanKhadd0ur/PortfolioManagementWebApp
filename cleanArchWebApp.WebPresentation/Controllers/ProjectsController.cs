using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cleanArchWebApp.ApplicationCore.Enities;
using cleanArchWebApp.Infrastructure;
using cleanArchWebApp.ApplicationCore.Interfaces;

namespace cleanArchWebApp.WebPresentation.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<Project> _projects;

        public ProjectsController(IUnitOfWork<Owner> owner
                            , IUnitOfWork<Project> projects)
        {
            _owner = owner;
            _projects = projects;

        }

        // GET: Projects
        public  IActionResult Index()
        {
            return View( _projects.Entity.GetAll(p=>p.Owner,prop=>prop.Owner.Address));
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project =  _projects.Entity.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectName,Description,ImagePath,Budget,Id")] Project project)
        {
            if (ModelState.IsValid)
            {
                _projects.Entity.Insert(project);
                _projects.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = _projects.Entity.GetById(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectName,Description,ImagePath,Budget,Id")] Project project)
        {
            if (id != project.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _projects.Entity.Update(project);
                    _projects.Save();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = _projects.Entity.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project =  _projects.Entity.GetById(id);
            _projects.Entity.Delete(project);
            _projects.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
            return _projects.Entity.GetById(id) is null ? false : true;
        }
    }
}
