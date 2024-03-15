using FirstAPI.BL.DTOs;
using FirstAPI.Data.Entities;
using FirstAPI.Data.Repositories;

namespace FirstAPI.BL.Services;

public class BrandService(IBrandInterface brandInterface) 
    : IBrandService
{
    private readonly IBrandInterface _brandInterface = brandInterface;

    public void Add(AddBrandDto brend)  
    {
        Brand brand = new()
        {
            Name = brend.Name
        };

        _brandInterface.Add(brand);

    }

    public void Delete(int id)
    {
        var brand = _brandInterface.GetById(id);
        _brandInterface.Delete(brand);
    }

    public List<BrandDto> GetAll()
    {
        var brands = _brandInterface.GetAll();
        var dtos = brands.Select(x => new BrandDto
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();

        return dtos;

    }

    public BrandDto GetById(int id)
    {
        var brand = _brandInterface.GetById(id);
        var dto = new BrandDto
        {
            Id = brand.Id,
            Name = brand.Name
        };
        return dto;
    }

    public void Update(BrandDto brend)
    {
        var brand = _brandInterface.GetById(brend.Id);
        brand.Name = brend.Name;
        _brandInterface.Update(brand);
    }
}
