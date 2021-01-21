using DMKit.WebApi;

#nullable enable
public class Product : BaseModel
{
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public int Quantity { get; private set; }
    public string? Photo { get; private set; }

    public decimal Price { get; private set; }

    public Product(string name, string photo, decimal price, string? description = null, int quantity = 1)
    {
        Name = name;
        Description = description;
        Quantity = quantity;
        Photo = photo;
        Price = price;
    }


}