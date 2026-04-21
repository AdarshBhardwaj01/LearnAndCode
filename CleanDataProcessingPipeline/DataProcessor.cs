public class DataProcessor
{
    private FileReader reader = new FileReader();
    private DataParser parser = new DataParser();
    private DataValidator validator = new DataValidator();

    private List<Dictionary<string, object>> parsedRecords;
    private int errorCount;

    public bool ValidateData { get; set; } = true;

    public void ProcessData()
    {
        var raw = reader.Read("input.csv");
        parsedRecords = parser.Parse(raw);

        if (ValidateData)
        {
            parsedRecords = validator.Validate(parsedRecords, ref errorCount);
        }
    }
}