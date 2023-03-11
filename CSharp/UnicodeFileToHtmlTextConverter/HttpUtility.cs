namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter;

public static class HttpUtility
{
    public static string HtmlEncode(string line)
    {
        return line
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("&", "&amp;")
            .Replace("\"", "&quot;")
            .Replace("\'", "&quot;");
    }
}