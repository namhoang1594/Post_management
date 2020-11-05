using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post_management.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Post_Tags> Post_Tag { get; set; }
        public List<Post> Posts { get; set; }
    }
}
