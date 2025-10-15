class Lasagna
{
    public int ExpectedMinutesInOven(){
        return 40;
    }
    
    public int RemainingMinutesInOven(int remainingMinutes){
        return this.ExpectedMinutesInOven()-remainingMinutes;
    }
    
    public int PreparationTimeInMinutes(int numberOfLayers){
        return numberOfLayers*2;
    }

    public int ElapsedTimeInMinutes(int numberOfLayers, int remainingMinutes) => this.PreparationTimeInMinutes(numberOfLayers)+(remainingMinutes);

    
}
