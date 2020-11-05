using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post_management.Models
{
    public class Post_Tags
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
        public Post Post { get; set; }
        public Tags Tags { get; set; }
    }
}
