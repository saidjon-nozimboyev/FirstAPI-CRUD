namespace FirstAPI.Data.Entities;

public class Car : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Year { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public int BrendId { get; set; }
    public Brand Brends { get; set; } = null!;
}
