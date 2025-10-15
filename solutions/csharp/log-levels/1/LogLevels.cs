static class LogLine
{
    
    public static string Message(string logLine)
    {
        int first = logLine.IndexOf("[") + "[".Length;
        int last = logLine.LastIndexOf("]:");
        string logLevel = logLine.Substring(first, last-first);

        return logLine.Replace("["+logLevel+"]:", "").Trim();
        
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int first = logLine.IndexOf("[") + "[".Length;
        int last = logLine.LastIndexOf("]:");
        string logLevel = logLine.Substring(first, last-first);

        return logLevel.ToLower();
        
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        int first = logLine.IndexOf("[") + "[".Length;
        int last = logLine.LastIndexOf("]:");
        string logLevel = logLine.Substring(first, last-first).ToLower();

        int lastString = logLine.Length;
        Console.WriteLine(last);
        Console.WriteLine(lastString);
        Console.WriteLine(lastString-last);
        string extraInfo = logLine.Substring(last, lastString-last).Replace("]: ", "");
        extraInfo = extraInfo.Replace("\t", "").Replace("\r", "").Replace("\n", "").Trim();
        
        return $"{extraInfo} ({logLevel})";
        
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
