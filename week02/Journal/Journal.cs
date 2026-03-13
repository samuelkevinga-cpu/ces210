using System.IO;
using Newtonsoft.Json;
class Journal
{
    private List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetDisplayString());
            Console.WriteLine();
        }
    }
    public void SaveToFile(string filename)
    {   //saving to json instead of text file
        string json = JsonConvert.SerializeObject(_entries, Formatting.Indented);
        File.WriteAllText(filename, json)
    }
    public void LoadFromFile(string filename)
    {   //loading from json instead of text file
    if (File.Exists(filename))
    {
        string json = File.ReadAllText(filename);
        _entries = JsonConvert.DeserializeObject<List<Entry>>(json);
    }
}
}