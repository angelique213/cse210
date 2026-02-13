using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;     // stores the scripture reference
    private List<Word> _words;        // stores all the words in the scripture
    private Random _random;           // used to randomly hide words

    // Constructor: sets the reference and splits the text into Word objects
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _random = new Random();

        _words = text
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(w => new Word(w))
            .ToList();
    }

    // Returns the full scripture (reference + current word display)
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{referenceText}\n{wordsText}";
    }

    // hides a given number of random visible words
    public void HideRandomWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        int numberToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < numberToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    // returns true if all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}