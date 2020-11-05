using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post_management.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Categories> Category { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tags> Tag { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categories>().HasData(new Categories { Id = 1, Title = "Đời sống" });
            modelBuilder.Entity<Categories>().HasData(new Categories { Id = 2, Title = "Xã hội" });
            modelBuilder.Entity<Categories>().HasData(new Categories { Id = 3, Title = "Kinh tế" });

            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 1,
                Title = "Codegym Huế",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoriesId = 1,
                TagsId = 1
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 2,
                Title = "Nguyễn Tri Phương",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoriesId = 2,
                TagsId = 2
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 3,
                Title = "Lễ Bế Giảng",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                CategoriesId = 3,
                TagsId = 2
            });

            modelBuilder.Entity<Post_Tags>().HasKey(postTag => new { postTag.PostId, postTag.TagId });
            modelBuilder.Entity<Tags>().HasData(new Tags
            {
                Id = 1,
                Title = "Hot",
            });
            modelBuilder.Entity<Tags>().HasData(new Tags
            {
                Id = 2,
                Title = "News",
            });
            modelBuilder.Entity<Tags>().HasData(new Tags
            {
                Id = 3,
                Title = "Shock",
            });
        }
    }
}
