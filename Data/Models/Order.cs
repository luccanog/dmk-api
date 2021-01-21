using System;
using System.Collections.Generic;
using System.Linq;
using DMKit.WebApi;

#nullable enable

public enum OrderStatus
{
    Canceled,
    Pending,
    Completed,

}

public class Order : BaseModel
{
    public string? Observation { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime FinishedAt { get; private set; }
    public List<Product> Products { get; private set; }
    public decimal Price { get; private set; }
    public OrderStatus Status { get; private set; }
    public Address Address { get; private set; }
    public decimal DeliveryTax { get; private set; }

    public Order(string? observation, DateTime date, List<Product> products, Address address, decimal deliveryTax)
    {
        Observation = observation;
        CreatedAt = DateTime.Now;
        Products = products;
        Price = products.Sum(p => p.Price);
        Status = OrderStatus.Pending;
        Address = address;
        DeliveryTax = deliveryTax;
    }

    public void CompleteOrder()
    {
        Status = OrderStatus.Completed;
    }

    /** @todo: criar entidades de Sellers e Customers e os relacionamentos, estudar sobre identity server antes disso **/
}