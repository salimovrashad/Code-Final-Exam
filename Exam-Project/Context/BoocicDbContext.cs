using Exam_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Net;
using System.Reflection.Emit;

namespace Exam_Project.Context
{
    public class BoocicDbContext : IdentityDbContext
    {
        public BoocicDbContext(DbContextOptions opt) : base (opt)
        {
        }
        public DbSet<Service> Services { get; set; }
        public DbSet<Settings> Settings { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Settings>().HasData(
            new { Id = 1, Address = "Address1111" });
            base.OnModelCreating(builder);
        }
    }
}
