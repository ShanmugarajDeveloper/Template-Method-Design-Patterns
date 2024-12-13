public abstract class DataProcessor
{
    public void ProcessData()
    {
        ReadData();
        ProcessDataSpecific();
        SaveData();
    }

    protected abstract void ReadData();
    protected abstract void ProcessDataSpecific();
    protected virtual void SaveData()
    {
        Console.WriteLine("Saving data to the database...");
        // Common save logic
    }
}
public class CsvDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Reading CSV file...");
        // Specific logic to read CSV
    }

    protected override void ProcessDataSpecific()
    {
        Console.WriteLine("Processing CSV data...");
        // Specific logic for processing CSV
    }
}

public class JsonDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Reading JSON file...");
        // Specific logic to read JSON
    }

    protected override void ProcessDataSpecific()
    {
        Console.WriteLine("Processing JSON data...");
        // Specific logic for processing JSON
    }
}

public class XmlDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Reading XML file...");
        // Specific logic to read XML
    }

    protected override void ProcessDataSpecific()
    {
        Console.WriteLine("Processing XML data...");
        // Specific logic for processing XML
    }
}
class Program
{
    static void Main(string[] args)
    {
        DataProcessor csvProcessor = new CsvDataProcessor();
        csvProcessor.ProcessData();

        DataProcessor jsonProcessor = new JsonDataProcessor();
        jsonProcessor.ProcessData();

        DataProcessor xmlProcessor = new XmlDataProcessor();
        xmlProcessor.ProcessData();
    }
}
