using System;

public class Singleton
{
    private static Singleton instance = null;
    private static readonly object lockObj = new object();
    private Singleton()
    {
        Console.WriteLine("Singleton instance created.");
    }
    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
        }
        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("Hello from Singleton!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Singleton obj1 = Singleton.GetInstance();
        obj1.ShowMessage();

        Singleton obj2 = Singleton.GetInstance();
        obj2.ShowMessage();

        Console.WriteLine("Are both instances the same? " + (obj1 == obj2));
    }
}
