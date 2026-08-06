public class Player
{
    Random rng = new Random();
    public int RollDie()
    {
        
        return rng.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        return rng.NextDouble()*100.0;
    }
}
