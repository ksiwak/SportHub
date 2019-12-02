using System;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using SportHub.Models;
using SportHub.ViewModels;

namespace SportHub.Controllers
{
    public class SportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SportsController()
        {
            _context = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new SportFormViewModel
            {
                 Types = _context.Types.ToList()
              
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SportFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Types = _context.Types.ToList();
                return View("Create", viewModel);
            }
            var sport = new Sport
            {
                PlayerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                TypeId = viewModel.Type,
                Complex = viewModel.Complex

            };
            _context.Sports.Add(sport);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        
    }
}