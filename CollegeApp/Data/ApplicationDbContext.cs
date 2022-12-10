using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using CollegeApp.Models;

namespace CollegeApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
        public DbSet<CollegeApp.Models.Product> Product { get; set; }
        public DbSet<CollegeApp.Models.Mobile> Mobile { get; set; }
    }
}