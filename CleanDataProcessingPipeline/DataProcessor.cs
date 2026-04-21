using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class DataProcessor
{
    private string inputFilePath;
    private string outputFilePath;
    private int recordsProcessed;
    private int errorCount;
    private List<string> errorMessages = new List<string>();

    public bool ValidateData { get; set; } = true;
    public bool TransformData { get; set; } = true;

    private List<string> rawData = new List<string>();
    private List<Dictionary<string, object>> parsedRecords = new List<Dictionary<string, object>>();

    private StringBuilder logBuffer = new StringBuilder();

    public int RecordsProcessed => recordsProcessed;
    public int ErrorCount => errorCount;
    public List<string> ErrorMessages => errorMessages;

    public DataProcessor(string input, string output)
    {
        inputFilePath = input;
        outputFilePath = output;
    }

    public void ProcessData()
    {
        rawData = new List<string>(File.ReadAllLines(inputFilePath));

        foreach (var line in rawData)
        {
            var parts = line.Split(',');
            if (parts.Length >= 3)
            {
                parsedRecords.Add(new Dictionary<string, object>
                {
                    {"id", parts[0]},
                    {"name", parts[1]},
                    {"value", parts[2]}
                });
            }
        }

        recordsProcessed = parsedRecords.Count;
    }
}