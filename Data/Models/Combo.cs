using System.Collections.Generic;
using System.Linq;
using DMKit.WebApi;

#nullable enable
public class Combo : BaseModel
{
    public string Name { get; private set; }
    public List<Product> Products { get; private set; }
    public decimal Price { get; private set; }
    public string? Photo { get; private set; }

    public Combo(string name, List<Product> products, decimal price = 0)
    {
        Name = name;
        Products = products;
        Price = price.Equals(0) ? products.Sum(p => p.Price) : price;
    }

}