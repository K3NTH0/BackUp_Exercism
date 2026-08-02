using System.Diagnostics;

public static class LineUp
{
    public static string Format(string name, int number)
    {
        string numberInString = number.ToString();
        char lastDigit = numberInString[^1];
        char secondToLastDigit;
        string ordinal = "";

        if (numberInString.Length > 1)
        {
            secondToLastDigit = numberInString[^2];
            if (secondToLastDigit != '1')
            {
                switch (lastDigit)
                {
                    case '1':
                        ordinal = $"{number}st";
                        break;
                    case '2':
                        ordinal = $"{number}nd";
                        break;
                    case '3':
                        ordinal = $"{number}rd";
                        break;
                    default:
                        ordinal = $"{number}th";
                        break;
                }
            }
            else
            {
                ordinal = $"{number}th";
            }
        }
        else
        {
            switch (lastDigit)
            {
                case '1':
                    ordinal = $"{number}st";
                    break;
                case '2':
                    ordinal = $"{number}nd";
                    break;
                case '3':
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
