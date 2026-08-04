public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string resultat = "";
    
        foreach (var l in text)
        {
            resultat += GiveLetterRotated(l, shiftKey);           
        }
        
        return resultat;
    }

    private static char GiveLetterRotated(char letter, int shiftKey)
    {
        char result = ' ';
        if (char.IsLetter(letter))
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            if (char.IsUpper(letter))
            {
                alphabet = alphabet.ToUpper();
            }
            int index  = alphabet.IndexOf(letter);
            int shiftedIndex =  (shiftKey + index) >= 26 ?  shiftKey + index - 26 : shiftKey + index;
            result = alphabet[shiftedIndex];
        }
        else
        {
            result = letter;
        }
        return result;
    }
}