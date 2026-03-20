public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    //Constructor that takes the scripture and split it
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
    //Method to display the scripture with the hidden words
    public string GetDisplayText()
    {
        List<string> wordTexts = new List<string>();

        foreach (Word word in _words)
        {
            wordTexts.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", wordTexts);
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }
    // Method to hide random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                visibleWords.Add(word);
        }

        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleWords.Count == 0) break;

            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide(); 
            visibleWords.RemoveAt(index);
        }
    }
    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}