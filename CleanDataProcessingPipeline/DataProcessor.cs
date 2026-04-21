private Dictionary<string, IExporter> exporters = new Dictionary<string, IExporter>
{
    {"json", new JsonExporter()},
    {"xml", new XmlExporter()}
};

public void Export(string path, string format)
{
    exporters[format].Export(path, parsedRecords);
}