class RemoteControlCar
{
    internal int speed { get; set; }

    internal int batteryDrain { get; set; }
    internal int battery { get; set; }
    private int distanceDriven { get; set; }


    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        distanceDriven = 0;
        battery = 100;
    }

    public int GetBattery() => battery;
    
    public bool BatteryDrained()
    {
        return battery <= 0 || batteryDrain > battery;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
        
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance { get; set; }

    public RaceTrack(int distance)
    {  
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        return ((double)distance / (double)car.speed) <= ((double)car.battery / (double)car.batteryDrain);
    }
}
