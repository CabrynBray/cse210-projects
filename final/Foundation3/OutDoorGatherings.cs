public class OutDoorGaterings : Event
{
    private string _wetherForecast;
    public OutDoorGaterings(string title, string description, string date, string time, string address, string weatherForecast)
        : base(title, description, date, time, address)
        {

        }
    public override void GetFullDetails()
    {
        
    }
}