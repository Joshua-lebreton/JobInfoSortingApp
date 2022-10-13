using JobInfoSortingApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobInfoSortingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}