public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
         return new string(text.Select(GiveLetterRotated).ToArray()); // 2eme iteration, LINQ pour parcourir le texte.
        
        char GiveLetterRotated(char letter)
        {
            char result;
            if (char.IsLetter(letter))
            {
                int a = char.IsUpper(letter)? 'A' : 'a';
                result = (char)(a + ((letter - a + shiftKey) % 26)); // 2eme iteration, on utilise le code ASCII.
            }
            else
            {
                result = letter;
            }
            return result;
        }
        
    }

    
}