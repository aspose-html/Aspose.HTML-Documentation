using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Drawing;
using Aspose.Html.Saving;
using System;
using System.Drawing;
using System.IO;
using Xunit;
using Xunit.Abstractions;
using System.Drawing.Drawing2D;

namespace Aspose.HTML.Tests.Converting_Between_Formats.SVG_Converter
{
    public class SVGtoBMPTests : TestsBase
    {
        public SVGtoBMPTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("svg-converter/svg-to-bmp");
        }


        [Fact(DisplayName = "Convert SVG to BMP With a Single Line")]
        public void ConvertSVGWithASingleLineTest()
        {
            // Invoke the ConvertSVG method for SVG to BMP conversion          
            Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new ImageSaveOptions(ImageFormat.Bmp), Path.Combine(OutputDir, "convert-with-single-line.bmp"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-with-single-line_1.bmp")));
        }


        [Fact(DisplayName = "Convert SVG to BMP")]
        public void ConvertSVGtoBMPTest()
        {
            // Prepare SVG code 
            var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
                       "<circle cx ='100' cy ='100' r ='50' fill='none' stroke='red' stroke-width='10' />" +
                       "</svg>";

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "circle.bmp");

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Bmp);

            // Convert SVG to BMP
            Converter.ConvertSVG(code, ".", options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "circle_1.bmp")));
        }


        [Fact(DisplayName = "SVG to BMP With ImageSaveOptions")]
        public void SVGtoBMPWithImageSaveOptionsTest()
        {
            // Prepare a path to a source SVG file
            string documentPath = Path.Combine(DataDir, "flower1.svg");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "flower-options.bmp");

            // Initialize an SVG document from the file
            using var document = new SVGDocument(documentPath);

            // Initialize ImageSaveOptions. Set up the SmoothingMode, resolutions, and change the background color to AliceBlue 
            var options = new ImageSaveOptions(ImageFormat.Bmp)
            {
                HorizontalResolution = 200,
                VerticalResolution = 200,
                BackgroundColor = Color.AliceBlue,
                SmoothingMode = SmoothingMode.HighQuality
            };           

            // Convert SVG to BMP
            Converter.ConvertSVG(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "flower-options_1.bmp")));
        }
    }
}
