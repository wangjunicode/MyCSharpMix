using System.Collections.Generic;
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
    // private string chartType;
    private static string configPath = "obj/config.json";

    public static void CreateConfig()
    {
        if (string.IsNullOrEmpty(configPath))
        {
            return;
        }

        List<ComAlia> config = new List<ComAlia>
        {
            new ComAlia{type_name = "UILabel", type_alias="Lbl"},
            new ComAlia{type_name = "UISprite", type_alias="Spr"},
            new ComAlia{type_name = "UIButton", type_alias="Btn"},
        };

        string jsonStr = JsonSerializer.Serialize(config);

        if (!File.Exists(configPath))
        {
            File.Create(configPath).Close();
        }
        System.Console.WriteLine(jsonStr);

        File.WriteAllText(configPath, jsonStr);
    }

    public static List<ComAlia> GetConfigType()
    {
        string jsonStr = File.ReadAllText(configPath);
        List<ComAlia> config = JsonSerializer.Deserialize<List<ComAlia>>(jsonStr);
        return config;
    }
}

public class ChartConfig
{
    public string ChartType { get; set; }
}

public class ComAlia
{
    public string type_name { get; set; }
    public string type_alias { get; set; }
}