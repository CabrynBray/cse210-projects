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
    public string AddressInfo()
    {
        return $"{_country} - {_stateProvince} - {_city} - {_streetAddress}";
    }
    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string DisplayAddress()
    {
        // Console.WriteLine($"Street: {_streetAddress}, City: {_city}, State/Province: {_stateProvince}, Country: {_country}");
        string fullAddress = $"Street: {_streetAddress}, City: {_city}, State/Province: {_stateProvince}, Country: {_country}";
        return fullAddress;
    }
}