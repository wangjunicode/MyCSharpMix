using System.Net;
using System.IO;
using System.Text.Json;

public interface IChartable
{
    void Display();
}

public class ChartFactroy
{
    public static IChartable GetChart(string chartType)
    {
        IChartable chartable = null;
        if (chartType == "line")
        {
            chartable = new LineChart();
        }
        else if (chartType == "pie")
        {
            chartable = new PieChart();
        }

        return chartable;
    }
}

public class LineChart : IChartable
{
    public void Display()
    {
        System.Console.WriteLine("LineChart Display");
    }
}

public class PieChart : IChartable
{
    public void Display()
    {
        System.Console.WriteLine("PieChart Display");
    }
}

public class AppConfigHelper
{
    private string chartType;
    private static string configPath = "obj/config.json";

    public static void CreateConfig()
    {
        if (string.IsNullOrEmpty(configPath))
        {
            return;
        }

        ChartConfig config = new ChartConfig
        {
            ChartType = "line"
        };

        string jsonStr = JsonSerializer.Serialize(config);
        System.Console.WriteLine(jsonStr);

        if (!File.Exists(configPath))
        {
            File.Create(configPath).Close();
        }

        File.WriteAllText(configPath, jsonStr);
    }

    public static string GetConfigType()
    {
        string jsonStr = File.ReadAllText(configPath);
        ChartConfig config = JsonSerializer.Deserialize<ChartConfig>(jsonStr);
        return config.ChartType;
    }
}

public class ChartConfig
{
    public string ChartType { get; set; }
}