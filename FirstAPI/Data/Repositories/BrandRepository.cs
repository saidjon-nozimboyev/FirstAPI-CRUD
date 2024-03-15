using FirstAPI.BL.Services;
using FirstAPI.Data.Entities;
using GenericRepository;

namespace FirstAPI.Data.Repositories;

public class BrandRepository(CarsDbContext dbContext)
    : Repository<CarsDbContext, Brand>(dbContext), IBrandInterface
{
}
