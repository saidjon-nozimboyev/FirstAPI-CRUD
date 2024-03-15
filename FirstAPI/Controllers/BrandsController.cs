using FirstAPI.BL.DTOs;
using FirstAPI.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController(IBrandService brandService) : ControllerBase
{
    private readonly IBrandService _brandService = brandService;

    [HttpGet]
    public ActionResult Get()
    {
        var brends = _brandService.GetAll();
        return Ok(brends);
    }

    [HttpGet("{id}")]
    public ActionResult GetById(int id)
    {
        var brend = _brandService.GetById(id);
        return Ok(brend);
    }

    [HttpPost]
    public ActionResult Post(AddBrandDto brend)
    {
        _brandService.Add(brend);
        return Ok();
    }

    [HttpPut]
    public ActionResult Put(BrandDto brend)
    {
        _brandService.Update(brend);
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        _brandService.Delete(id);
        return Ok();
    }
}
