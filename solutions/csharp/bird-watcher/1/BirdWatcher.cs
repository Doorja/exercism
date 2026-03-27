class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new[] {0, 2, 5, 3, 7, 8, 4};
        throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    }

    public int Today()
    {
        return birdsPerDay.Last();
        
        throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
        int lastIndex = birdsPerDay.Length;
        birdsPerDay[lastIndex-1]++;
            
        //throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int bird in birdsPerDay){
            if(bird == 0){return true;}
        }
        return false;
        throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int totalBirds=0;
        for(int i=0; i<numberOfDays; i++){
            totalBirds += birdsPerDay[i];
        }
        return totalBirds;
        
        throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        int busyDays=0;

        foreach(int bird in birdsPerDay){
            if(bird>=5){
                busyDays++;
            }
        }
        return busyDays;
        
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}
