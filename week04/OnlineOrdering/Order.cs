using System.Collections.Generic;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double productTotal = 0;

        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;

        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        List<string> lines = new List<string>();

        foreach (Product product in _products)
        {
            lines.Add($"{product.GetName()} ({product.GetProductId()})");
        }

        return string.Join("\n", lines);
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
