using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
        lines.Add($"{entry._date}|{entry._promptText}|{entry._entryText}");
        }

        File.WriteAllLines(file, lines);
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        List<Entry> loadedEntries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                loadedEntries.Add(entry);
            }
        }

    _entries = loadedEntries;
    }
}