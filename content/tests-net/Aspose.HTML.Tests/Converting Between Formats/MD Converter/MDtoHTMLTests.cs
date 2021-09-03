using Aspose.Html;
using Aspose.Html.Converters;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.MD_Converter
{
    public class MDtoHTMLTests : TestsBase
    {
        public MDtoHTMLTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("md-converter/md-to-html");
        }


        [Fact(DisplayName = "Convert Markdown to HTML Test1")]
        public void ConvertMDtoHTMLTest1()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(OutputDir, "document.md");

            // Prepare a simple Markdown example
            var code = "### Hello, World!" +
                       "\r\n" +
                       "[visit applications](https://products.aspose.app/html/family)";
            // Create a Markdown file
            File.WriteAllText(sourcePath, code);

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "document-output.html");

            // Convert Markdown to HTML document
            Converter.ConvertMarkdown(sourcePath, savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Convert Markdown to HTML Test2")]
        public void ConvertMDtoHTMLest2()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(DataDir, "nature.md");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "nature-output.html");

            // Convert Markdown to HTML
            Converter.ConvertMarkdown(sourcePath, savePath);

            Assert.True(File.Exists(savePath));
        }    
    }
}
