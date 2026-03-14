using System;

public class Entry
{
     private string _prompt;
    private string _response;
    private string _date;

     public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

      public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine(new string('-', 30));
    }

     public string ToFileString()
    {
        return $"{_date}~|~{_prompt}~|~{_response}";
    }

     public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("~|~");
        if (parts.Length != 3) return null;
        return new Entry(parts[1], parts[2], parts[0]);
    }
}
