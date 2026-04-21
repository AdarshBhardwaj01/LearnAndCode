using System.Collections.Generic;

public interface IExporter
{
    void Export(string path, List<Dictionary<string, object>> data);
}