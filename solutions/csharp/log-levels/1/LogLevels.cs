static class LogLine
{
    public static string Message(string logLine) => logLine.Substring(logLine.IndexOf(':') + 1).Trim();

    //public static string LogLevel(string logLine) => logLine.Substring(logLine.IndexOf('[') +1, logLine.LastIndexOf(']')-2-logLine.IndexOf('[')+1).ToLower().Trim();
    public static string LogLevel(string logLine) => logLine.Substring(logLine.IndexOf('[')+1,logLine.IndexOf(']')-1).ToLower().Trim();
    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";

}
