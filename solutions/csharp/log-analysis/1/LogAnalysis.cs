using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public static class LogAnalysis
{
    public static string SubstringAfter(this string str,string symbole)
    {
        string masque = @$"{symbole}( )(.*)";
        Match match = Regex.Match(str, masque);

        return match.Groups[1].Value+match.Groups[2].Value;
    }


    public static string SubstringBetween(this string str, string symbole1, string symbole2)
    {
        symbole1 = Regex.Escape(symbole1.Trim());
        symbole2 = Regex.Escape(symbole2.Trim());
        
        string masque = @$"{symbole1}(.*){symbole2}";
        Match match = Regex.Match(str,masque);
        
        return match.Groups[1].Value.Trim();
    }

    public static string Message(this string str) => str.SubstringAfter(":");
    
    public static string LogLevel(this string str) => str.SubstringBetween("[","]");
}