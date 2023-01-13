using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System;
using System.Drawing;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.MD_Converter
{
    public class MDtoPDFTests : TestsBase
    {
        public MDtoPDFTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("md-converter/md-to-pdf");
        }


        [Fact(DisplayName = "Convert Markdown to PDF")]
        public void ConvertMDtoPDFTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(OutputDir, "document.md");

            // Prepare a simple Markdown example
            var code = "### Hello, World!" +
                       "\r\n" +
                       "[visit applications](https://products.aspose.app/html/family)";
            // Create a Markdown file
            File.WriteAllText(sourcePath, code);            

            // Convert Markdown to HTML 
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Prepare a path for converted PDF file saving 
            string savePath = Path.Combine(OutputDir, "document-output.pdf");

            // Convert the HTML document to PDF file format
            Converter.ConvertHTML(document, new PdfSaveOptions(), savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Convert Markdown to PDF With PdfSaveOptions")]
        public void ConvertMDtoPDFWithPdfSaveOptionsTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(DataDir, "nature.md");

            // Prepare a path for converted PDF file saving 
            string savePath = Path.Combine(OutputDir, "nature-output.pdf");

            // Convert Markdown to HTML
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Initialize PdfSaveOptions. Set up the resolutions, JpegQuality and change the background color to AliceBlue 
            var options = new PdfSaveOptions()
            {
                HorizontalResolution = 200,
                VerticalResolution = 200,
                BackgroundColor = System.Drawing.Color.AliceBlue,
                JpegQuality = 100
            };            

            // Convert the HTML document to PDF file format
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(savePath));
        }        
    }
}
