public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public void GetStanderdDetails()
    {
        
    }
    public abstract void GetFullDetails();
    public void GetShortDescription()
    {
         
    }
}