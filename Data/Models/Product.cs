using DMKit.WebApi;

#nullable enable
public class Product : BaseModel
{
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public int Quantity { get; private set; }
    public string? Photo { get; private set; }
    public short Amount { get; private set; }
    public Unit Unit { get; private set; }
    public Product()
    {
    }

    public Product(string name, string photo, short amount,
    Unit unit, string? description = null, int quantity = 1)
    {
        Name = name;
        Description = description;
        Quantity = quantity;
        Photo = photo;
        Amount = amount;
        Unit = unit;
    }


}