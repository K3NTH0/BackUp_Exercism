static class AssemblyLine
{
    public static double SuccessRate(int speed) =>
        speed == 0 ? 0 : speed < 5 ? 1 : speed < 9 ? 0.9 : speed < 10 ? 0.8 : 0.77;
    
    public static double ProductionRatePerHour(int speed) => (speed*221)*SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed)=> (int)(ProductionRatePerHour(speed))/60;
}
