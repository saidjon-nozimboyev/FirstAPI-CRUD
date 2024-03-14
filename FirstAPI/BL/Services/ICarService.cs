using FirstAPI.BL.CarDTOs;

namespace FirstAPI.BL.Services;

public interface ICarService
{
    List<CarDto> GetAll();
    CarDto GetById(int id);
    void Add(CarDto car);
    void Update(CarDto car);
    void Delete(int id);
}
