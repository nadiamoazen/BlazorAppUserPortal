using Microsoft.EntityFrameworkCore;
namespace BlazorAppUserPortal.DataContext








{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        /// A table(Users) with the User entity
    }
}
