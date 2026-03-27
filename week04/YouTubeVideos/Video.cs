public class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    private List<Comment> _comments;

    //Your program should have a class for a Video that has the responsibility to track the title, author, 
    // and length (in seconds) of the video. Each video also has responsibility to store a list of comments, 
    // and should have a method to return the number of comments. A comment should be defined by the Comment 
    // class which has the responsibility for tracking both the name of the person who made the comment and the text of the comment.
    public Video (string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;

        _comments = new List<Comment>();
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLenght()
    {
        return _lenght;
    }
    public void AddComment(Comment Comment)
    {
        _comments.Add(Comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
}