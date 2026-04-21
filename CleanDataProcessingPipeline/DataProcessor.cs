private Logger logger = new Logger();
private StatisticsCalculator stats = new StatisticsCalculator();

public void ProcessData()
{
    logger.Log("Processing started");

    var raw = reader.Read("input.csv");
    parsedRecords = parser.Parse(raw);

    if (ValidateData)
        parsedRecords = validator.Validate(parsedRecords, ref errorCount);

    var statistics = stats.Calculate(parsedRecords, errorCount);

    logger.Log("Processing completed");
    logger.Save("log.txt");
}