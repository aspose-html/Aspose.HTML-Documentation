using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Drawing;
using Aspose.Html.Saving;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.MD_Converter
{
    public class MDtoDOCXTests : TestsBase
    {
        public MDtoDOCXTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("md-converter/md-to-docx");
        }


        [Fact(DisplayName = "Convert Markdown to DOCX")]
        public void ConvertMDtoDOCXTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(OutputDir, "document.md");

            // Prepare a simple Markdown example
            var code = "### Hello, World!" +
                       "\r\n" +
                       "Convert Markdown to DOCX!";

            // Create a Markdown file
            File.WriteAllText(sourcePath, code);

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "document-output.docx");

            // Convert Markdown to HTML document
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Convert HTML document to DOCX file format
            Converter.ConvertHTML(document, new DocSaveOptions(), savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Convert Markdown to DOCX With DocSaveOptions")]
        public void ConvertMDtoDOCXWithDocSaveOptionsTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(DataDir, "nature.md");

            // Prepare a path for converted DOCX file saving 
            string savePath = Path.Combine(OutputDir, "nature-output.docx");

            // Convert Markdown to HTML 
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Initialize DocSaveOptions. Set up the page-size 500x1000 pixels and margins 
            var options = new DocSaveOptions();
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(500, 1000), new Margin(20, 20, 10, 10));

            // Convert the HTML document to DOCX file format
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(savePath));
        }     
    }
}
