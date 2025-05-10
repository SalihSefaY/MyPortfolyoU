using Microsoft.EntityFrameworkCore;
using UdemyPortf.DALL.entities;

namespace UdemyPortf.DALL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=SEFA\\SQLEXPRESS; initial Catalog=MyPortfolioDb;integrated Security =true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<feature> features { get; set; }
        public DbSet<Message>Messages { get; set; }  
        public DbSet<Portfolio>Portfolios { get; set; }
        public DbSet<Skill>Skills { get; set; }
        public DbSet<SocialMedia>SocialMedias { get; set; }
        public DbSet<Testimonial>Testimonials { get; set; }
        public DbSet<ToDoList>ToDoListls { get; set; }




    }
}
