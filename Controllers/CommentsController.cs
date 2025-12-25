using Microsoft.AspNetCore.Mvc;
using vrmninkosesi.Data;
using vrmninkosesi.Models;
using System;

namespace vrmninkosesi.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CommentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int postId, string authorName, string content)
        {
            if (string.IsNullOrWhiteSpace(authorName) || string.IsNullOrWhiteSpace(content))
            {
                return RedirectToAction("Details", "Posts", new { id = postId });
            }

            var comment = new Comment
            {
                AuthorName = authorName,
                Content = content,
                PostId = postId,
                CreatedDate = DateTime.Now
            };

            _context.Comments.Add(comment);
            _context.SaveChanges();

            return RedirectToAction("Details", "Posts", new { id = postId });
        }
    }
}

