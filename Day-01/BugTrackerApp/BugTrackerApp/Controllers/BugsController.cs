using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugTrackerApp.Models;
using BugTrackerApp.Services;

namespace BugTrackerApp.Controllers
{
    public class BugsController : Controller
    {
        private readonly IBugService _bugService;
        //
        // GET: /Bugs/
        public BugsController()
        {
            _bugService = new BugService();
        }

        public BugsController(IBugService bugService)
        {
            _bugService = bugService;
        }

     
        public ViewResult List()
        {
            //ViewData["bugs"] = _bugService;
            var viewModel = new BugListViewModel()
            {
                Bugs = _bugService.Bugs,
                Total = _bugService.Count,
                ClosedCount = _bugService.Bugs.Count(b => b.IsClosed)
            };
            return View(viewModel);
        }

        public ViewResult New()
        {
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult New(string newBugName)
        {
            _bugService.Add(newBugName);
            return RedirectToAction("List");
        }
    }
}
