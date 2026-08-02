using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        string reponse;

        statement = statement.Trim();

        if (statement == String.Empty)
        {
            reponse = "Fine. Be that way!";
            
        } 
        else if (statement.EndsWith("?")) // Verifier la présence d'un point d'interrogation 
        {
            if (statement.IsUpper()) // verifier si c'est full maj
            {
                reponse = "Calm down, I know what I'm doing!";

            }
            else // pas de minuscule 
            {
                reponse = "Sure." ;
            }
            
        }else if (statement.IsUpper()) // verifier si c'est full maj
        {
            reponse = "Whoa, chill out!";
        }
        else
        {
            reponse = "Whatever.";
        }

        return reponse;
    }

    private static bool IsUpper(this string str)
    {
        return str.Any(char.IsLetter) && !str.Any(char.IsLower); // Utilisation de LINQ 
    }
}