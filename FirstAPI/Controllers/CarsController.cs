using FirstAPI.BL.CarDTOs;
using FirstAPI.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarsController(ICarService carService)
    : ControllerBase
{
    private readonly ICarService _carService = carService;

    [HttpGet]
    public IActionResult Get()
    {
        var cars = _carService.GetAll();
        return Ok(cars);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var car = _carService.GetById(id);
        return Ok(car);
    }

    [HttpPost]
    public IActionResult Post(CarDto dto)
    {
        _carService.Add(dto);
        return Ok();
    }

    [HttpPut]
    public IActionResult Put(CarDto dto) 
    {
        _carService.Update(dto);
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        _carService.Delete(id);
        return Ok();
    }
}
