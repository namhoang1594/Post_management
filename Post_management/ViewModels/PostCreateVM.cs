using Microsoft.AspNetCore.Mvc.Rendering;
using Post_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post_management.ViewModels
{
    public class PostCreateVM
    {
        public Post Posts { get; set; }

        public IEnumerable<Categories> Category { get; set; }
        public IEnumerable<SelectListItem> CategoriesSelectList { get; set; }
        public IEnumerable<Tags> Tag { get; set; }
        public IEnumerable<SelectListItem> TagsSelectList { get; set; }
    }
}
