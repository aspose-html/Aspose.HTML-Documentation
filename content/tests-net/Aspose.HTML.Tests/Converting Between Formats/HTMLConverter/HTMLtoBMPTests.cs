using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Drawing;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.HTMLConverter
{
    public class HTMLtoBMPTests : TestsBase
    {
        public HTMLtoBMPTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("html-converter/html-to-bmp");
        }


        [Fact(DisplayName = "Convert HTML to BMP")]
        public void ConvertHTMLtoBMPTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "bmp.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "bmp-output.bmp");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Bmp);

            // Convert HTML to BMP
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "bmp-output_1.bmp")));
        }


        [Fact(DisplayName = "Convert HTML to BMP with ImageSaveOptions")]
        public void ConvertHTMLtoBMPWithImageSaveOptionsTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "bmp.html");

            // Prepare a path for converted file saving
            string savePath = Path.Combine(OutputDir, "bmp-output-options.bmp");

            // Initialize an  HTML Document from the html file
            using var document = new HTMLDocument(documentPath);

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Bmp)
            {
                SmoothingMode = SmoothingMode.None,
                HorizontalResolution = 350,
                VerticalResolution = 350,
                BackgroundColor = Color.Beige
            };
            
            // Convert HTML to BMP
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "bmp-output-options_1.bmp")));
        }
    }
}
