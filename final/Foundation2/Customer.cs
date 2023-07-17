public class Customer
{
    private string _name;
    private string streetAddress, city, stateProvince, country;
    private Address _addressInfo;
    public Customer(string name)
    {
        _name = name; 
        _addressInfo = new Address(streetAddress, city, stateProvince, country);
    }

    public Address GetAddress()
    {
        return _addressInfo;
    }
    public string GetName()
    {
        return _name;
    }

    public bool IsUSA()
    {
        return _addressInfo.IsUSA();
    }
}