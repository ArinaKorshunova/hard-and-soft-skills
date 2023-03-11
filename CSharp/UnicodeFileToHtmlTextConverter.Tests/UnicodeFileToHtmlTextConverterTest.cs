
using Xunit;
namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public class HikerTest
    {
        [Fact]
        public void FileNameNotEqual()
        {
            var converter = new UnicodeFileToHtmlTextConverter("foobar.txt");
            Assert.NotEqual("fixme", converter.FileName);
        }
    }
}
