using System.IO;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter;

public record UnicodeFileToHtmlTextConverter(string FileName)
{
    private const string LineSplitter = "<br />";
    
    public string ConvertToHtml()
    {
        using TextReader unicodeFileStream = File.OpenText(FileName);
        var html = string.Empty;

        var line = unicodeFileStream.ReadLine();
        while (line != null)
        {
            html += ConvertLine(line);
            line = unicodeFileStream.ReadLine();
        }

        return html;
    }

    private string ConvertLine(string line)
    {
        return HttpUtility.HtmlEncode(line) + LineSplitter;
    }
}