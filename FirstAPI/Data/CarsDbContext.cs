using FirstAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Data;

public class CarsDbContext (DbContextOptions<CarsDbContext> options) 
    : DbContext (options)
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Brand> Brands { get; set; }
}
