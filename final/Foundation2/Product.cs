public class Product
{
    private string _productName;
    private int _productId;
    private int _productQuantity;
    private double _productPrice;

    public Product(string productName, int productId, int productQuantity, double productPrice)
    {
        _productName = productName;
        _productId = productId;
        _productQuantity = productQuantity;
        _productPrice = productPrice;
    }
    public string productInfo()
    {
        return $"{_productName} - {_productQuantity} - {_productId} - {_productPrice}";
    }

    public double GetPrice()
    {
        double price = _productPrice * _productQuantity;
        return price;
    }
}