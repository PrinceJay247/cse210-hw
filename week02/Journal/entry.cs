using System;

public class Entry
{
    // Member variables (fields)
    private string _prompt;
    private string _response;
    private string _date;

    // Constructor
    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    // Display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine(new string('-', 30));
    }

    // Convert entry to a string for saving
    public string ToFileString()
    {
        return $"{_date}~|~{_prompt}~|~{_response}";
    }

    // Static method to create an Entry from a file line
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("~|~");
        if (parts.Length != 3) return null; // safety check
        return new Entry(parts[1], parts[2], parts[0]);
    }
}
