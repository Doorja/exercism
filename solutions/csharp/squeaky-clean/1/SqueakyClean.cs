using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var result = new StringBuilder();
        bool capitalizeNext = false;
        
        foreach(char symbol in identifier){
            if(Char.IsLetter(symbol) && !(symbol>='α' && symbol<='ω')){
                if(capitalizeNext){
                    result.Append(Char.ToUpper(symbol));
                }
                else{
                    result.Append(symbol);
                }
            }
            else if(symbol == ' '){
                result.Append('_');
            }
            else if(Char.IsControl(symbol)){
                result.Append("CTRL");
            }

            capitalizeNext = false;
            if(symbol == '-'){
                capitalizeNext = true;
            }
        }

        return result.ToString();
        throw new NotImplementedException($"Please implement the (static) Identifier.Clean() method");
    }
}
