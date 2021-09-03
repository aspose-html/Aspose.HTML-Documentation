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
    public class HTMLtoGIFTests : TestsBase
    {
        public HTMLtoGIFTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("html-converter/html-to-gif");
        }


        [Fact(DisplayName = "Convert HTML to GIF")]
        public void ConvertHTMLtoGIFTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "spring.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "spring-output.gif");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Gif);

            // Convert HTML to GIF
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "spring-output_1.gif")));
        }


        [Fact(DisplayName = "Convert HTML to GIF With ImageSaveOptions")]
        public void ConvertHTMLtoGIFWithImageSaveOptionsTest()
        {
            string documentPath = Path.Combine(OutputDir, "convert-to-gif.html");
            string savePath = Path.Combine(OutputDir, "convert-to-gif-options.gif");

            // Prepare HTML code and save it to a file
            var code = "<h1> HTML to GIF Converter </h1>\r\n" +
                       "<p> GIF is a popular image format that supports animated images and frequently used in web publishing. HTML to GIF conversion allows you to save an HTML document as a GIF image.  </p>\r\n";

            File.WriteAllText(documentPath, code);

            // Initialize an  HTML Document from the html file
            using var document = new HTMLDocument(documentPath);

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Gif)
            {
                SmoothingMode = SmoothingMode.Default,
                HorizontalResolution = 100,
                VerticalResolution = 100,
                BackgroundColor = Color.MistyRose
            };
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(500, 200), new Margin(30, 20, 10, 10));

            // Convert HTML to GIF
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-to-gif-options_1.gif")));
        }
    }
}
