using System.Diagnostics;

public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ordinal = $"{number}th";

        if (number % 100 >= 11 && number % 100 <= 13)
        {
            ordinal = $"{number}th";
        }
        else
        {
            switch (number % 10)
            {
                case 1:
                    ordinal = $"{number}st";
                    break;
                case 2:
                    ordinal = $"{number}nd";
                    break;
                case 3:
                    ordinal = $"{number}rd";
                    break;
                default:
                    ordinal = $"{number}th";
                    break;
            }
        } 
        return $"{name}, you are the {ordinal} customer we serve today. Thank you!";
    }
}