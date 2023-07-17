public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int NumberComments()
    {
        return _comments.Count();
    }
    public void DisplaySummary()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of Comments: {NumberComments()}");
        int i = 1;
        foreach (Comment comment in _comments)
        {
            Console.Write($"{i}. ");
            comment.CommentDisplay();
            i = i ++;
        }
        Console.WriteLine();
    }

}