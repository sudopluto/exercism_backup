static class LogLine
{
    public static string Message(string logLine)
    {
        Range msgRng = (logLine.IndexOf(':') + 1)..;
        return logLine[msgRng].Trim();
    }

    public static string LogLevel(string logLine)
    {
        Range levelRng = (logLine.IndexOf('[') + 1)..(logLine.IndexOf(']'));
        return logLine[levelRng].ToLower();
    }

    public static string Reformat(string logLine)
    {
        return String.Format("{0} ({1})", Message(logLine), LogLevel(logLine));
    }
}
