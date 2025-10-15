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
    }

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
        int lastIndex = birdsPerDay.Length;
        birdsPerDay[lastIndex-1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int bird in birdsPerDay){
            if(bird == 0){return true;}
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int totalBirds=0;
        for(int i=0; i<numberOfDays; i++){
            totalBirds += birdsPerDay[i];
        }
        return totalBirds;
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
    }
}
