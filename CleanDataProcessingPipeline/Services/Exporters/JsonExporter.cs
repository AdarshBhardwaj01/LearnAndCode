using System.Collections.Generic;
using System.IO;
using System.Linq;

public class JsonExporter : IExporter
{
    public void Export(string path, List<Dictionary<string, object>> data)
    {
        var lines = new List<string> { "[" };

        foreach (var record in data)
        {
            var props = record.Select(kvp => $"\"{kvp.Key}\": \"{kvp.Value}\"");
            lines.Add("{" + string.Join(",", props) + "},");
        }

        lines.Add("]");
        File.WriteAllLines(path, lines);
    }
}