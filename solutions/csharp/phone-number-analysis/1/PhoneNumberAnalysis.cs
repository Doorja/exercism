public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {        
        (bool IsNewYork, bool IsFake, string LocalNumber) result = (false, false, "123");
        
        if(phoneNumber.Substring(0, 3) == "212"){
            result.IsNewYork = true;
        }else{result.IsNewYork = false;}  
        
        if(phoneNumber.Substring(4, 3) == "555"){
            result.IsFake = true;
        }else{result.IsFake = false;}
        
        result.LocalNumber = phoneNumber.Substring(8,4);

        return result;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
