using System;

public static class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    public static void Main()
    {
        try
        {
            Logger.Info("Info...");
            System.Console.ReadKey();

        }
        catch (Exception ex)
        {
            Logger.Error(ex, "Error...");
            Logger.Fatal(ex, "Fatal...");
        }

        NLog.LogManager.Shutdown();
    }
}  
