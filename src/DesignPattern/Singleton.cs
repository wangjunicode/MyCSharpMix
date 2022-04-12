public class Singleton
{
    private static Singleton s_instance;

    private Singleton()
    {

    }

    public static Singleton GetInstance()
    {
        if (s_instance == null)
        {
            s_instance = new Singleton();
        }

        return s_instance;
    }

    public void Print()
    {
        System.Console.WriteLine("Print");
    }
}