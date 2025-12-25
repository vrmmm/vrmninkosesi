using Microsoft.AspNetCore.Mvc;
using vrmninkosesi.Data;
using vrmninkosesi.Models;
using System.Linq;

namespace vrmninkosesi.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfileController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new AdminProfileViewModel
            {
                AboutMe = "Ben Evrim. Bilgisayar mühendisliği okuyorum ama kendimi tek bir alana sığdırmayı hiç sevmedim. Liseden beri yazıyorum; bazen bir hikâye, bazen birkaç dize, bazen sadece içimden geçenler. Bu yazılarda genelde VRM adını kullanıyorum." +
                "Burası, yazdıklarımı topladığım ve iz bırakan düşünceleri paylaştığım küçük bir köşe.",

                InstagramUrl = "https://www.instagram.com/evrm.avci",
                LinkedInUrl = "https://www.linkedin.com/in/evrim-avcı-08b020340",
                GitHubUrl = "https://github.com/vrmmm",

                ProfileImagePath = "C:\\Users\\evrim\\source\\repos\\vrmninkosesi\\wwwroot\\images\\foto..png",
                Posts = _context.Posts
                    .OrderByDescending(p => p.CreatedDate)
                    .ToList()
            };

            return View(model);
        }

    }
}

