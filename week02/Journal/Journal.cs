using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry (Entry newEntry)
    {
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();

    newEntry._date = dateText;
    _entries.Add(newEntry);
    
    }

    public void DisplayAll()
    {
    foreach (Entry entry in _entries)
    {
    entry.Display();
    } 
    }

    public void SaveToFile(string file)
    {
    using (StreamWriter textUser = new StreamWriter(file))
    {
      foreach (Entry entry in _entries)
        {
          textUser.Write($"{entry._date}: {entry._promptText} | {entry._entryText}");
        }
    }
    }

    public void LoadFromFile(string file)
    {
      string[] lines = File.ReadAllLines(file);
        _entries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            AddEntry(entry);
        }
    }
}
