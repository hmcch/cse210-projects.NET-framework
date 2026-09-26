using System.Data;

public class Reference
{
    // Declaring attributes Private Type
    private string _book;
    private int _chapter;
    private int _verseBegin;
    private int _verFinish;

    // Declaring First Constructor to handle single verse references (1 Nephi 3:7)
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseBegin = verse;
        _verFinish = verse;
    }
    // Declaring Second Constructor to handle multiple verses (2 Nephi 9:28-29)
    public Reference(string book, int chapter, int verseBegin, int verseFinish)
    {
        _book = book;
        _chapter = chapter;
        _verseBegin = verseBegin;
        _verFinish = verseFinish;
    }

    // Declaring Methods

    public string GetDisplayText()
    {
        // First case: Citation has single verse format (there is no hyphen)
        if (_verseBegin == _verFinish)
        {
            return $"{_book} {_chapter}:{_verseBegin}";
        }
        else// Second case: Citation is larger than single verse, (to append the last verse using hyphen)
        {
            return $"{_book} {_chapter}:{_verseBegin} - {_verFinish}";
        }
    }

}