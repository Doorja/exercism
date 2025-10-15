class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    
    public int RemainingMinutesInOven(int remainingMinutes) => this.ExpectedMinutesInOven()-remainingMinutes;
    
    public int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers*2;

    public int ElapsedTimeInMinutes(int numberOfLayers, int remainingMinutes) => this.PreparationTimeInMinutes(numberOfLayers)+(remainingMinutes);

    
}
