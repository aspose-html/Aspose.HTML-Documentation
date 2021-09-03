using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Drawing;
using Aspose.Html.Saving;
using System;
using System.Drawing;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.MD_Converter
{
    public class MDtoXPSTests : TestsBase
    {
        public MDtoXPSTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("md-converter/md-to-xps");
        }


        [Fact(DisplayName = "Convert Markdown to XPS")]
        public void ConvertMDtoXPSTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(OutputDir, "document.md");

            // Prepare a simple Markdown example
            var code = "### Hello, World!" +
                       "\r\n" +
                       "[visit applications](https://products.aspose.app/html/family)";
            // Create a Markdown file
            File.WriteAllText(sourcePath, code);

            // Prepare a path for converted XPS file saving 
            string savePath = Path.Combine(OutputDir, "document-output.xps");

            // Convert Markdown to HTML 
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Convert the HTML document to XPS file format
            Converter.ConvertHTML(document, new XpsSaveOptions(), savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Convert Markdown to XPS With XpsSaveOptions")]
        public void ConvertMDtoXPSWithXpsSaveOptionsTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(DataDir, "nature.md");

            // Prepare a path for converted PDF file saving 
            string savePath = Path.Combine(OutputDir, "nature-output.xps");

            // Convert Markdown to HTML
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Initialize XpsSaveOptions. Set up the resilutions, page-size, margins and change the background color to AntiqueWhite 
            var options = new XpsSaveOptions()
            {
                HorizontalResolution = 200,
                VerticalResolution = 200,
                BackgroundColor = Color.AntiqueWhite
            };
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(Length.FromInches(5.0f), Length.FromInches(10.0f)), new Margin(30, 20, 10, 10));

            // Convert HTML to XPS file format
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(savePath));
        }    
    }
}
