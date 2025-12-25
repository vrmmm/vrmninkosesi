using Microsoft.AspNetCore.Mvc;
using vrmninkosesi.Data;
using System.Linq;

namespace vrmninkosesi.Controllers
{
    public class MediaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MediaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var postsWithMedia = _context.Posts
                .Where(p => p.ImagePath != null && p.ImagePath != "")
                .ToList();

            return View(postsWithMedia);
        }
    }
}

