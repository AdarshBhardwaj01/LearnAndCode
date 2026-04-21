using System.Collections.Generic;
using System.Linq;

public class StatisticsCalculator
{
    public Dictionary<string, int> Calculate(List<Dictionary<string, object>> records, int errorCount)
    {
        var stats = new Dictionary<string, int>();

        stats["total_records"] = records.Count;
        stats["error_count"] = errorCount;

        double total = records.Sum(r => double.Parse(r["value"].ToString()));

        stats["total_value"] = (int)total;
        stats["average"] = records.Count > 0 ? (int)(total / records.Count) : 0;

        return stats;
    }
}