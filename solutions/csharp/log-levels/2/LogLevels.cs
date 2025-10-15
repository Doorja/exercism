static class LogLine
{
    public static string LogStatus(string logLine){
        int first = logLine.IndexOf("[") + "[".Length;
        int last = logLine.LastIndexOf("]:");
        string logLevel = logLine.Substring(first, last-first);

        return logLevel;
    }
    
    public static string Message(string logLine)
    {
        return logLine.Replace("["+LogStatus(logLine)+"]:", "").Trim();
        
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        return LogStatus(logLine).ToLower();
        
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        int first = logLine.IndexOf("[") + "[".Length;
        int last = logLine.LastIndexOf("]:");
        int lastString = logLine.Length;

        string extraInfo = logLine.Substring(last, lastString-last).Replace("]: ", "");
        extraInfo = extraInfo.Replace("\t", "").Replace("\r", "").Replace("\n", "").Trim();
        
        return $"{extraInfo} ({LogStatus(logLine).ToLower()})";
        
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
