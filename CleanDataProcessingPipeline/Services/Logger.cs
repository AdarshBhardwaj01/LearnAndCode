using System;
using System.IO;
using System.Text;

public class Logger
{
    private StringBuilder buffer = new StringBuilder();

    public void Log(string message)
    {
        buffer.AppendLine($"[{DateTime.Now}] {message}");
    }

    public void Save(string path)
    {
        File.WriteAllText(path, buffer.ToString());
    }
}