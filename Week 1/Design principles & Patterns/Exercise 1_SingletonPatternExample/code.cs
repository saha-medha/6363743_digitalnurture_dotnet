using System;
public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    private Logger()
    {
        Console.WriteLine("Logger initialized.");
    }

    public static Logger GetInstance()
    {
        lock (_lock)
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
        }
        return _instance;
    }
    public void Log(string message)
    {
        Console.WriteLine("[LOG] " + message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();
        logger1.Log("First message");
        logger2.Log("Second message");
        if (logger1 == logger2)
        {
            Console.WriteLine("Both logger instances are the same.");
        }
        else
        {
            Console.WriteLine("Logger instances are different!");
        }
    }
}
