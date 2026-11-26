using System.Collections.Generic;
using System.Text;

public class Order
{
    private readonly List<Product> _products;
    private readonly Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal subtotal = 0m;
        foreach (Product product in _products)
        {
            subtotal += product.GetTotalCost();
        }

        decimal shippingCost = _customer.LivesInUSA() ? 5m : 35m;
        return subtotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (Product product in _products)
        {
            label.AppendLine($"{product.GetName()} ({product.GetProductId()})");
        }

        return label.ToString().TrimEnd();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
