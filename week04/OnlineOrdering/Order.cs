using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order (Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalPriceOrder(bool LiveInUsa)
    {
      double _totalCost = 0;

      foreach (var product in _products)
      {
        _totalCost += product.CalculateProductCost();
      }

      Console.WriteLine($"Subtotal: ${_totalCost}");
      if (LiveInUsa == true)
      {
        Console.WriteLine("Shipping Cost: $5");
        _totalCost += 5;
      }
      else{
        Console.WriteLine("Shipping Cost: $35");
        _totalCost += 35;
      }
      return _totalCost;
    }
      
    public string GetPackingLabel()
    {
      string label = "Packing Label:";
      foreach(var product in _products)
      {
        label += $"{product.GetName()} | ID: {product.GetID()}\n";
      }
      return label;
    }

    public string GetShippingLabel()
    {
      return $"Shipping Label: \n{_customer.GetName()} | {_customer.GetAddress()}";
    }


}