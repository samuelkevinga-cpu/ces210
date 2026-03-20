public class Word
    {
    private string _text;
    private bool _isHidden;

    //constructor to set the text
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Words are visible by default
    }
    public void Show()
    {
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true; // makes word hidden
    }
    //Method to see if it's hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
    //display method
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
    
}