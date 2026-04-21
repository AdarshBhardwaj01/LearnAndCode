using System.Collections.Generic;

public class DataValidator
{
    public List<Dictionary<string, object>> Validate(
        List<Dictionary<string, object>> records,
        ref int errorCount)
    {
        var valid = new List<Dictionary<string, object>>();

        foreach (var record in records)
        {
            if (record.ContainsKey("id") &&
                double.TryParse(record["value"].ToString(), out _))
            {
                valid.Add(record);
            }
            else
            {
                errorCount++;
            }
        }

        return valid;
    }
}