using Microsoft.EntityFrameworkCore;
using UrbanHub.EntityFramework.Models;

namespace UrbanHub.EntityFramework
{
    public class UrbanCartDbContext : DbContext
    {
        public UrbanCartDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) 
        {        
        }

        public DbSet<User> Users { get; set; }

    }
}
