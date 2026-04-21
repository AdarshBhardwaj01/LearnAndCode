class Program
{
    static void Main()
    {
        var processor = new DataProcessor("input.csv", "output.csv");

        processor.ValidateData = true;
        processor.TransformData = true;

        processor.ProcessData();

        Console.WriteLine(processor.RecordsProcessed);
    }
}