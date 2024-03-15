namespace FirstAPI.Data.Entities;

public class Brand : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public List<Car> Cars { get; set; } = new();
}
