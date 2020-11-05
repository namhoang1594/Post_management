using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Post_management.Models
{
    public class Post
    {
        public int Id { get; set; }

        [DisplayName("Tên Tiêu Đề")]
        public string Title { get; set; }

        [DisplayName("Nội Dung")]
        public string Content { get; set; }

        [DisplayName("Thể Loại")]
        public int CategoriesId { get; set; }
        public Categories Category { get; set; }

        [DisplayName("Tags")]
        public int TagsId { get; set; }
        public Tags Tag { get; set; }
        public List<Post_Tags> Post_Tags { get; set; } = new List<Post_Tags>();
    }
}
