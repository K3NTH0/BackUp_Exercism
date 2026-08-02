public static class ScrabbleScore
{
    public static int Score(string input)
    {
        char[] mot = input.Trim().ToLower().ToCharArray();
        int score = 0;

        foreach (var lettre in mot)
        {
            if (lettre == 'q' || lettre == 'z')
            {
                score += 10;
            }
            else if(lettre == 'j' || lettre == 'x')
            {
                score += 8;
            }
            else if (lettre == 'k')
            {
                score += 5;
            }
            else if (lettre == 'f' || lettre == 'h' || lettre == 'v' || lettre == 'w' || lettre == 'y')
            {
                score += 4;
            }
            else if (lettre == 'b' || lettre == 'c' || lettre == 'm' || lettre == 'p')
            {
                score += 3;
            }
            else if (lettre == 'd' || lettre == 'g')
            {
                score += 2;
            }
            else
            {
                score += 1;
            }
        }
        return score;
    }
}