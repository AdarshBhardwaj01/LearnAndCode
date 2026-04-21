using System.Collections.Generic;

public class DataParser
{
    public List<Dictionary<string, object>> Parse(List<string> rawData)
    {
        var parsed = new List<Dictionary<string, object>>();

        foreach (var line in rawData)
        {
            var parts = line.Split(',');
            if (parts.Length >= 3)
            {
                parsed.Add(new Dictionary<string, object>
                {
                    {"id", parts[0]},
                    {"name", parts[1]},
                    {"value", parts[2]}
                });
            }
        }

        return parsed;
    }
}