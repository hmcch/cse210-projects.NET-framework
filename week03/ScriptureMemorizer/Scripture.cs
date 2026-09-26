using System;
using System.Collections.Generic;

public class Scripture
{
    // Declaring attributes of Private Type
    // This part keeps the data hidden from Program.cs
    private Reference _reference;
    private List<Word> _words;

    // Declaring Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Splitting main block of text with the use of blank space and give origin to individual words
        foreach (var word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    // Methods

    // Do a random selection and also hide a specif amount of the current words that are still visible
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();

        }
    }


    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (var word in _words)
        {
            result += word.GetDisplayText() + " ";

        }
        return result;
    }
    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}