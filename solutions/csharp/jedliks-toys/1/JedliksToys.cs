class RemoteControlCar
{
    private int wasDriven=0;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
        
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
    }

    public string DistanceDisplay()
    {
        return $"Driven {wasDriven} meters";
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {
        if(100-(wasDriven/20) > 0){
            return $"Battery at {100-(wasDriven/20)}%";
        } else {return "Battery empty";}
        
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

    public void Drive()
    {
        if (wasDriven<2000){
            this.wasDriven+=20;
        }
        //throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
        Console.WriteLine("Vroom vroom");
    }
}
