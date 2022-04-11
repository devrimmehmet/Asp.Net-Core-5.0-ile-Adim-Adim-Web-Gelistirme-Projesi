using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<WriterUser, WriterRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=DEVRIMMEHMET; database=CoreProjeDB; integrated security=true");
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<ToDoList> ToDoLists { get; set; }

        public DbSet<Announcement> Announcements { get; set; }

        public DbSet<WriterMessage> WriterMessages { get; set; }  



    }
}
