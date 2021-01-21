using System.Collections.Generic;
using System.Linq;
using DMKit.WebApi;

#nullable enable
public class Kit : BaseModel
{
    public string Name { get; private set; }
    public List<Product> Products { get; private set; }
    public decimal Price { get; private set; }
    public string? Photo { get; private set; }

    public Kit(string name, List<Product> products, decimal price)
    {
        Name = name;
        Products = products;
        Price = products.Sum(p => p.Price);
    }

}