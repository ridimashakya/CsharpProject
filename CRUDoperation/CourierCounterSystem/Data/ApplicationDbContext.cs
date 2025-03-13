using CRUDoperation.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDoperation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Workers> AllWorkers { get; set; }
    }
}
