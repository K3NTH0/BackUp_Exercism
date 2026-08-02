class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        bool empty = false;
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] == 0)
            {
                empty = true;
            }
            
        }
        return empty;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            count += birdsPerDay[i];
        }

        return count;
    }

    public int BusyDays()
    {
        int count = 0;
        foreach (var birds in birdsPerDay )
        {
            if (birds > 4)
            {
                count++;
            }
        }

        return count;
    }
}
