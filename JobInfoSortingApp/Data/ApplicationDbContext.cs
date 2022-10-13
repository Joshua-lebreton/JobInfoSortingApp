using JobInfoSortingApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobInfoSortingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Skills> skills { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}