public class Word
{
    private string _text; //stores the actual word text
    private bool _isHidden; // tracks if the word is hidden or not

    // constructor it sets the word text and makes it visible at first
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // hides word by setting the hidden flag to true
    public void Hide()
    {
        _isHidden = true;
    }

    // returns true if the word is hidde

    public bool IsHidden()
    {
        return _isHidden;
    }

    // returns the word for display (underscores if hidden)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string ('_', _text.Length);
        }
        return _text;
    }
}