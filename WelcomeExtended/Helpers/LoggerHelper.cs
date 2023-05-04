using WelcomeExtended.Loggers;

namespace WelcomeExtended.Helpers;

public static class LoggerHelper
{
    public static ILogger GetLogger(string categoryName)
    {
        var loggerFactory = new LoggerFactory();

        loggerFactory.AddProvider(new LoggerProvider(categoryName));
        return loggerFactory.CreateLogger(categoryName);
    }
}

internal class LoggerFactory
{
    public LoggerFactory()
    {
    }

    internal void AddProvider(LoggerProvider loggerProvider)
    {
        throw new NotImplementedException();
    }

    internal ILogger CreateLogger(string categoryName)
    {
        throw new NotImplementedException();
    }
}