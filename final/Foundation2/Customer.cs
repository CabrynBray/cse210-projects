public class Customer
{
    public string _name { get; private set; }
    public  Address _address { get; private set;}

    public Customer(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool IsUSA()
    {
        return _address.IsUSA();
    }
}