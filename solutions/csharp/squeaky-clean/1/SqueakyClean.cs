

using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder str = new StringBuilder();
        string trimmedIdentifier = identifier.Trim();
        string? resultat = trimmedIdentifier;

        if (Regex.IsMatch(trimmedIdentifier, @"[a-zA-Z]+\s+[a-zA-Z]+"))
        {
            resultat = trimmedIdentifier.Replace(" ", "_");
        }else if (Regex.IsMatch(trimmedIdentifier, @"[a-zA-Z]+\0[a-zA-Z]+"))
        {
            resultat =  trimmedIdentifier.Replace("\0", "CTRL");
        }else if (trimmedIdentifier.Any( c => c == '-'))
        {
            
            resultat = String.Concat(Regex.Split(trimmedIdentifier, @"-")
                .Select((partie, index) => String.IsNullOrEmpty(partie) ? String.Empty : 
                    index > 0 ? char.ToUpper(partie[0])+partie.Substring(1) : partie));
            
        }else if (trimmedIdentifier.Any( c => !char.IsLetter(c)))
        {
            
            resultat = new string(trimmedIdentifier.Where(c => char.IsLetterOrDigit(c)).ToArray());
            
        }else if (Regex.IsMatch(trimmedIdentifier, @"[\u0370-\u03FF]"))
        {
            
            resultat = Regex.Replace(trimmedIdentifier, @"[\u03B1-\u03C9]", "");
           
        }
        
        return resultat;
    
    }
}
