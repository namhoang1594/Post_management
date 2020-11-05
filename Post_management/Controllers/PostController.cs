using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Post_management.Models;
using Post_management.ViewModels;

namespace Post_management.Controllers
{
    public class PostController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public PostController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Post> post = _appDbContext.Posts;
            return View(post);
        }
        public IActionResult Create()
        {
            PostCreateVM postCreateVM = new PostCreateVM()
            {
                Posts = new Post(),
                CategoriesSelectList = _appDbContext.Category.Select(item => new SelectListItem
                {
                    Text = item.Title,
                    Value = item.Id.ToString()
                }),
                TagsSelectList = _appDbContext.Tag.Select(item => new SelectListItem
                {
                    Text = item.Title,
                    Value = item.Id.ToString()
                })
            };

            return View(postCreateVM);
        }
        [HttpPost]
        public IActionResult Create(PostCreateVM postCreateVM)
        {
            _appDbContext.Posts.Add(postCreateVM.Posts);
            _appDbContext.SaveChanges();
            return View(postCreateVM);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
