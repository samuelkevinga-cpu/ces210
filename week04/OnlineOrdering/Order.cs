public class Order
{
    // Corrected code
    private List<Product> _products = new List<Product>();
    Customer _customer;

    public Order (Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct (Product product)
    {
        _products.Add(product);
    }
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        double shipping = _customer.LivesInUsa() ? 5:35;
        return total + shipping;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetPackingLine() + "\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddressDetails()}\n";
    }
}