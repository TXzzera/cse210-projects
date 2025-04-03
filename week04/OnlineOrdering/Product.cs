using System;

public class Product
{
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _productQuantity;
    public Product(string productName, string productID, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public double CalculateProductCost()
    {
        return _productPrice * _productQuantity; 
    }

    public string GetName()
    {
        return _productName;
    }
    public string GetID()
    {
        return _productID;
    }
}