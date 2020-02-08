using Microsoft.EntityFrameworkCore;
using WebGoat.NetCore.Data.Entities;

namespace WebGoat.NetCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public User User { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
