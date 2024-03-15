using FirstAPI.BL.DTOs;

namespace FirstAPI.BL.Services;

public interface ICarService
{
    List<CarDto> GetAll();
    CarDto GetById(int id);
    void Add(AddCarDto car);
    void Update(CarDto car);
    void Delete(int id);
}
