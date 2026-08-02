using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        // [a-z]+ \? pour chaine minuscule qui finit par un ? 4
        // [A-Z]+ \? same but pour maj 3
        // [A-Z]+$ pour MAJ 2
        // .Empty ou String.IsNullOrEmpty pour verif si une chaine est vide 1
        // le reste c'est assez ez 

        string reponse = "Whatever.";

        statement = statement.Trim();

        if (statement == String.Empty)
        {
            reponse = "Fine. Be that way!";
            
        } 
        else if (Regex.IsMatch(statement, @"\?$")) // Verifier la présence d'un point d'interrogation 
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