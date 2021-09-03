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
    public class HTMLtoTIFFTests : TestsBase
    {
        public HTMLtoTIFFTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("html-converter/html-to-tiff");
        }


        [Fact(DisplayName = "Convert HTML to TIFF")]
        public void ConvertHTMLtoTIFFTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "nature.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "nature-output.tiff");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Tiff);

            // Convert HTML to TIFF
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Convert HTML to TIFF With ImageSaveOptions")]
        public void ConvertHTMLtoTIFFWithImageSaveOptionsTest()
        {
            string documentPath = Path.Combine(DataDir, "nature.html");
            string savePath = Path.Combine(OutputDir, "nature-output-options.tiff");


            // Initialize an  HTML Document from the html file
            using var document = new HTMLDocument(documentPath);
            
            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Tiff)
            {
                Compression = Compression.None,
                BackgroundColor = Color.Bisque,
                HorizontalResolution = 150,
                VerticalResolution = 150,
                SmoothingMode = SmoothingMode.AntiAlias
            };

            // Convert HTML to TIFF
            Converter.ConvertHTML(document, options, savePath);            

            Assert.True(File.Exists(savePath));
        }
    }
}
