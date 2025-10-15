class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int metersDriven = 0;
    private int batteryCapacity = 100;
    
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if(batteryCapacity < batteryDrain){
            return true;
        }
        return false;
    }

    public int DistanceDriven()
    {
        return metersDriven;
    }

    public void Drive()
    {
        if(batteryCapacity >= batteryDrain){
            metersDriven += speed;
            batteryCapacity -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }

    public int BatteryDrain {
        get {return batteryDrain;}
    }
    
    public int BatteryCapacity {
        get {return batteryCapacity;}
    }

    public int Speed {
        get {return speed;}
    }
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance){
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        if((float)(((float)distance / (float)car.Speed) * (float)car.BatteryDrain) <= car.BatteryCapacity){
            return true;
        }
        return false;
    }
}
