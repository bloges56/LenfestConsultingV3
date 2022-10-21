using LenfestConsultingV2.Model;
using Microsoft.EntityFrameworkCore;

namespace LenfestConsultingV2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
    }
}
