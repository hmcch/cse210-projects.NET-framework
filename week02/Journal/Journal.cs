using System;
using System.Collections.Generic;
using System.IO;

//Exceeded requirements, I added the option to erase the latest entry, lines of code  71-84
public class Journal
{
    // Member variable is inside the class
    public List<Entry> _entries = new List<Entry>();

    private List<string> _prompts = new List<string>()
    {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was a moment today when I felt truly at peace or content?",
            "What is one thing I improved today so now I am 1% better than yesterday?",
            "Which is the greatest blessing I received today?",
    };

    // Public methods are inside the class
    public void AddEntry()
    {
        Random randomSentence = new Random();
        string prompt = _prompts[randomSentence.Next(0, _prompts.Count)];
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._promptText = prompt;
        newEntry._entryText = response;
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] sections = line.Split('|');
            Entry entry = new Entry();
            entry._date = sections[0];
            entry._promptText = sections[1];
            entry._entryText = sections[2];
            _entries.Add(entry);
        }
    }

    public void EraseLatest()
    {
        if (_entries.Count > 0)
        {
            int last = _entries.Count - 1;
            _entries.RemoveAt(last);
            Console.WriteLine("Latest entry has been erased.");
            Console.WriteLine("If you want to keep the file updated, select option 4 to update the journal.");
        }
        else
        {
            Console.WriteLine("No entries founded. Nothing to delete.");
        }
    }
}