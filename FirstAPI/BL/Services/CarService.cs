using FirstAPI.BL.CarDTOs;
using FirstAPI.Data.Entities;
using FirstAPI.Data.Repositories;

namespace FirstAPI.BL.Services;

public class CarService (ICarInterface carInterface)
    : ICarService
{
    private readonly ICarInterface _carInterface = carInterface;

    public void Add(AddCarDto newCar)
    {
        Car car = new()
        {
            Name = newCar.Name,
            Model = newCar.Model,
            Year = newCar.Year,
            Price = newCar.Price,
            Color = newCar.Color,
            Image = newCar.Image
        };

        _carInterface.Add(car);
    }

    public void Delete(int id)
    {
        var car = _carInterface.GetById(id);
        _carInterface.Delete(car!);
    }

    public List<CarDto> GetAll()
    {
        var cars = _carInterface.GetAll();
        var dtos = cars.Select(car => new CarDto
        {
            Id = car.Id,
            Name = car.Name,
            Model = car.Model,
            Year = car.Year,
            Price = car.Price,
            Color = car.Color,
            Image = car.Image
        }).ToList();

        return dtos;
    }

    public CarDto GetById(int id)
    {
        var car = _carInterface.GetById(id);
        var dto = new CarDto
        {
            Id = car.Id,
            Name = car.Name,
            Model = car.Model,
            Year = car.Year,
            Price = car.Price,
            Color = car.Color,
            Image = car.Image
        };

        return dto;
    }

    public void Update(CarDto dto)
    {
        var car = _carInterface.GetById(dto.Id);
        car.Name = dto.Name;
        car.Model = dto.Model;
        car.Year = dto.Year;
        car.Price = dto.Price;
        car.Color = dto.Color;
        car.Image = dto.Image;

        _carInterface.Update(car);
    }
}
