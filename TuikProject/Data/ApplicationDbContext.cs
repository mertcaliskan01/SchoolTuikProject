using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TuikProject.Models;

namespace TuikProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<IssizlikOrani> IssizlikOrani { get; set; }
        public DbSet<IssizlikOraniT1> IssizlikOraniT1 { get; set; }
        public DbSet<IssizlikOraniT2> IssizlikOraniT2 { get; set; }
    }
}
