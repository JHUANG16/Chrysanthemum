using System.Linq;
using System.Web.Mvc;
using Chrysanthemum.Models;
using Chrysanthemum.ViewModels;

namespace Chrysanthemum.Controllers
{
    public class GigsController : Controller
    {
        private readonly ToDoDbContext _context;

        public GigsController()
        {
            _context = new ToDoDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel()
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}