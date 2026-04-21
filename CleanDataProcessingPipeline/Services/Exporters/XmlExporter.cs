using System.Collections.Generic;
using System.IO;

public class XmlExporter : IExporter
{
    public void Export(string path, List<Dictionary<string, object>> data)
    {
        var lines = new List<string> { "<records>" };

        foreach (var record in data)
        {
            lines.Add("<record>");
            foreach (var kvp in record)
                lines.Add($"<{kvp.Key}>{kvp.Value}</{kvp.Key}>");
            lines.Add("</record>");
        }

        lines.Add("</records>");
        File.WriteAllLines(path, lines);
    }
}