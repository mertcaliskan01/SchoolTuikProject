using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentSystemWeb.Models;
using TuikProject.Models;

namespace TuikProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Title> Titles { get; set; }
        public DbSet<IssizlikOrani> IssizlikOraniTablo1 { get; set; }
        public DbSet<IssizlikOraniT2> IssizlikOraniTablo2 { get; set; }


    }
}
