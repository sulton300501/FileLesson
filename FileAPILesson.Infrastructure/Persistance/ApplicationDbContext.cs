using FileAPILesson.Domain.Entities.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;


namespace FileAPILesson.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            Database.Migrate();
        }




        public DbSet<UserProfile> Users { get; set; }

        
    }
}




