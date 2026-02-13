public class Reference
{
    private string _book; //name of the book ex. 1 Nephi
    private int _chapter; //Chapter number
    private int  _startVerse; // Starting verse 
    private int _endVerse; // Ending verse same as the start if just single verse


    // This is the constructor fo a single verse reference ex. 1 Nephi 2:5
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    // This is the constructor for a verse range reference  ex. 1 Nephi 2:1-5
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // This returns the refernece as a formatted string for display.
    public string GetDisplayText()
    {
        // If it is a single verse diplay it normally
        if(_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        // if it is a verse range diplay the range
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        
        }
    }
}