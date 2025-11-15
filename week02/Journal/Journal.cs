using System;
using System.Collections.Generic;
using System.IO;
class Journal
{
    private readonly List<Entry> _entries = [];

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter outputFile = new(filename);
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine(entry.ToFileString());
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length >= 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string entryText = parts[2];

                Entry entry = new(date, prompt, entryText);
                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded.");
    }
}
