using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine();
    }

    public string GetSaveFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}
