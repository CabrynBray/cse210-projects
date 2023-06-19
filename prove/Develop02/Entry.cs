
class Entry
{
    public string date, prompText, entryText;

    public Entry(string _date, string _prompText, string _entryText)
    {
        date = _date;
        prompText = _prompText;
        entryText = _entryText;

    }
    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {prompText}");
        Console.WriteLine(entryText);
    }
}