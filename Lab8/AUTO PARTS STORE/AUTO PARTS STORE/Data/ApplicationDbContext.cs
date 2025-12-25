using AUTO_PARTS_STORE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AUTO_PARTS_STORE.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<CarModel> CarModels { get; set; } = null!;

    }
}
