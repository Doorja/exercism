public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] inputChar = input.ToCharArray();
        Array.Reverse(inputChar);

        return new string(inputChar);
        
        throw new NotImplementedException("You need to implement this method.");
    }
}