// Video class definition
public class Video
{
    private string title;
    private string author;
    private int length; // length in seconds
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public string GetDetails()
    {
        return $"Title: {title}\nAuthor: {author}\nLength: {length} seconds\nNumber of Comments: {GetNumberOfComments()}";
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}