// Comment class definition
public class Comment
{
    private string commenterName;
    private string text;

    public Comment(string commenterName, string text)
    {
        this.commenterName = commenterName;
        this.text = text;
    }

    public string GetCommentDetails()
    {
        return $"{commenterName}: {text}";
    }
}