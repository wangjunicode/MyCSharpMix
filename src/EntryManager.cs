public class EntryManager
{
    public static void Init()
    {
        // System.Console.WriteLine("Init");

        // Singleton.GetInstance().Print();

        string typeStr = AppConfigHelper.GetConfigType();
        IChartable chartable = ChartFactroy.GetChart(typeStr);
        if (chartable != null)
        {
            chartable.Display();
        }
        else
        {
            System.Console.WriteLine("not found type:" + typeStr);
        }

        //AppConfigHelper.CreateConfig();
    }

}