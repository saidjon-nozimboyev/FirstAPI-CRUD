using FirstAPI.Data.Entities;
using GenericRepository;

namespace FirstAPI.Data.Repositories;

public class CarRepository (CarsDbContext dbContext)
    : Repository<CarsDbContext, Car>(dbContext), ICarInterface
{
}
