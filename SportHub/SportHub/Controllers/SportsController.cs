using System.Linq;
using System.Web.Mvc;
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
      //  [Authorize]
        public ActionResult Create()
        {
            var viewModel = new SportFormViewModel
            {
                 Types = _context.Types.ToList()
              
            };

            return View(viewModel);
        }
        
    }
}