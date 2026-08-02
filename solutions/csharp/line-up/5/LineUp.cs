using System.Diagnostics;

public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ordinal = $"{number}th";
        
        switch (number % 10, number % 100)
        {
            case (1, not 11):
                ordinal = $"{number}st";
                break;
            case (2, not 12):
                ordinal = $"{number}nd";
                break;
            case (3, not 13):
                ordinal = $"{number}rd";
                break;
            default:
                ordinal = $"{number}th";
                break;
        }

        return $"{name}, you are the {ordinal} customer we serve today. Thank you!";
    }
}