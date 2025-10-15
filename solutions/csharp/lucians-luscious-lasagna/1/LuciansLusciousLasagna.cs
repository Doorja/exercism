class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return 40;
    }
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int remainingMinutes){
        return this.ExpectedMinutesInOven()-remainingMinutes;
    }
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers){
        return numberOfLayers*2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int remainingMinutes){
        return this.PreparationTimeInMinutes(numberOfLayers)+(remainingMinutes);
        //shouldn't it be:
        //return this.PreparationTimeInMinutes(numberOfLayers)+(this.ExpectedMinutesInOven()-remainingMinutes);
    }
    
}
