public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country == "USA";
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Street: {_streetAddress}, City: {_city}, State/Province: {_stateProvince}, Country: {_country}");
    }
}
