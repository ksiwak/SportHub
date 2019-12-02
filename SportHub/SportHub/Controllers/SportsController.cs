using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using SportHub.Models;
using SportHub.ViewModels;
using Type = System.Type;

namespace SportHub.Controllers
{
    public class SportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SportsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Sports
      //  [Authorize]
        public ActionResult Create()
        {
            var viewModel = new SportFormViewModel
            {
                 Types = _context.Types.ToList()
               // Types =  _context.Types.ToList()
            };

            return View(viewModel);
        }
        
    }
}