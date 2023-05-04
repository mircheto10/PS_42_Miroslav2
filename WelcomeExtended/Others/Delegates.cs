using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Helpers;
using WelcomeExtended.Loggers;

namespace WelcomeExtended.Others
{
   public class Delegates
{
    private static readonly ILogger Logger = LoggerHelper.GetLogger("Hello!");

    public static void Log(string error)
    {
        Logger.LogError(error);
    } 
    
    public static void Log2(string error)
    {
        Console.WriteLine("- DELEGATES -");
        Console.WriteLine($"{error}");
        Console.WriteLine("- DELEGATES -");
    }

    public delegate void ActionOnError(string errorMessage);
    
}
}
