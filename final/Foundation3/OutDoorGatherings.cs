public class OutDoorGaterings : Event
{
    private string _wetherForecast;
    public OutDoorGaterings(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
        {

        }
    public override string GetFullDetails()
    {
        return $"WetherForecast: {_wetherForecast}";
    }
}