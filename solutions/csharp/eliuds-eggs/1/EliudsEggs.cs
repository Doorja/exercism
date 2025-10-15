public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int count = 0;
        string binaryEggs = Convert.ToString(encodedCount, 2);

        for(int i=0; i<binaryEggs.Length; i++){
            if(binaryEggs[i]=='1'){
                count++;
            }
        }
        
        return count;
    }
}



/* 
public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int count = 0;
        while (encodedCount > 0)
        {
            count += encodedCount & 1; 
            encodedCount >>= 1;
        }
        return count;
    }
}
*/