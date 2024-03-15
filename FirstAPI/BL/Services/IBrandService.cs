using FirstAPI.BL.DTOs;

namespace FirstAPI.BL.Services;

public interface IBrandService
{
    List<BrandDto> GetAll();
    BrandDto GetById(int id);
    void Add(AddBrandDto brend);
    void Update(BrandDto brend);
    void Delete(int id);
}
