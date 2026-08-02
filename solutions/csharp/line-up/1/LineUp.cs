using System.Diagnostics;

public static class LineUp
{
    public static string Format(string name, int number)
    {
        int lastDigit = Math.Abs(number%10);
        string ordinal;

        if (lastDigit == 1 && lastDigit != 11) { ordinal = $"{number}st"; }
        else if (lastDigit == 2 && lastDigit != 12) { ordinal = $"{number}nd"; }
        else if (lastDigit == 3 && lastDigit != 13) { ordinal = $"{number}rd"; }
        else { ordinal = $"{number}th"; }

        return $"{name}, you are the {ordinal} customer we serve today. Thank you!";
    }
}
