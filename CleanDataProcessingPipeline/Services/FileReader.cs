using System.Collections.Generic;
using System.IO;

public class FileReader
{
    public List<string> Read(string path)
    {
        return new List<string>(File.ReadAllLines(path));
    }
}