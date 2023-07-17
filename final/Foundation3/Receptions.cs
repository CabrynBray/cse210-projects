public class Receptions : Event
{
    private string _rsvp;
    public Receptions(string title, string description, string date, string time, string address, string rsvp)
        : base(title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public override void GetFullDetails()
    {
        
    }
}