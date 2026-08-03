

using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder str = new StringBuilder();
        string trimmedIdentifier = identifier.Trim();
        string? resultat = trimmedIdentifier;
        
        // Remplacer les espaces par des underscore 
        resultat = Regex.Replace(resultat, @" ", "_");
        
        // Remplacer Caractere de controle null par "CTRL"
        resultat = resultat.Replace("\0", "CTRL");
        
        // Kebab-case -> kamelCase
        if (resultat.Contains('-'))
        {
            resultat = String.Concat(Regex.Split(resultat, @"-")
                .Select((partie, index) => String.IsNullOrEmpty(partie) ? String.Empty : 
                    index > 0 ? char.ToUpper(partie[0])+partie.Substring(1) : partie));
        }
    
        // Garder seulement les lettres et les underscores
        resultat = new string(resultat.Where(c => char.IsLetter(c) || c == '_').ToArray());
        
        // Retirer les lettres grecques majuscule 
        resultat = Regex.Replace(resultat, @"[\u03B1-\u03C9]", "");
        
        
        return resultat;
    
    }
}
