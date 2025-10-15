public static class LogAnalysis 
{
    public static string SubstringAfter (this string fullMessage, string breakingPoint){
        int indexOfSpace = fullMessage.IndexOf(breakingPoint);
        
        return fullMessage.Substring(indexOfSpace+breakingPoint.Length);
    }

    public static string SubstringBetween
        (this string fullMessage, string symbolStart, string symbolEnd){
        int indexStart = fullMessage.IndexOf(symbolStart);
        int indexEnd = fullMessage.IndexOf(symbolEnd);
        
        return fullMessage.Substring
            (indexStart+symbolStart.Length, indexEnd-(indexStart+symbolStart.Length));
    }
    
    public static string Message(this string fullMessage){
        return SubstringAfter(fullMessage, "]: ");
    }

    public static string LogLevel(this string fullMessage){
        return SubstringBetween(fullMessage, "[", "]");
    }
}