using Newtonsoft.Json;
class Entry {
    [JsonProperty("Date")]
    private string _date;
    
    [JsonProperty("Prompt")]
    private string _prompt;
    
    [JsonProperty("Entry")]
    private string _entry;
    public Entry(string date, string prompt, string entry) {
        _date = date;
        _prompt = prompt;
        _entry = entry;
    }
    public string GetDisplayString() {
        return $"Date: {_date}\nPrompt: {_prompt}\nEntry: {_entry}";
    }
    public string GetFileString() {
        return $"{_date}|{_prompt}|{_entry}";
    }
}