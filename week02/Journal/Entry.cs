using System;
class Entry
{
    private readonly string _date;
    private readonly string _promptText;
    private readonly string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}
