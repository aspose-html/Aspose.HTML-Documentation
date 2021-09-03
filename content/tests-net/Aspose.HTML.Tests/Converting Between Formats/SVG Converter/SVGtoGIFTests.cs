using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Rendering.Image;
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
    public class SVGtoGIFTests : TestsBase
    {
        public SVGtoGIFTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("svg-converter/svg-to-gif");
        }


        [Fact(DisplayName = "Convert SVG to GIF With a Single Line")]
        public void ConvertSVGWithASingleLineTest()
        {
            // Invoke the ConvertSVG method for SVG to GIF conversion          
            Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new ImageSaveOptions(ImageFormat.Gif), Path.Combine(OutputDir, "convert-with-single-line.gif"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-with-single-line_1.gif")));
        }


        [Fact(DisplayName = "Convert SVG to GIF")]
        public void ConvertSVGtoGIFTest()
        {
            // Prepare SVG code 
            var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
                       "<circle cx ='100' cy ='100' r ='55' fill='pink' stroke='red' stroke-width='8' />" +
                       "</svg>";

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "circle.gif");

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Gif);

            // Convert SVG to GIF
            Converter.ConvertSVG(code, ".", options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "circle_1.gif")));
        }


        [Fact(DisplayName = "SVG to GIF With ImageSaveOptions")]
        public void SVGtoGIFWithImageSaveOptionsTest()
        {
            // Prepare a path to a source SVG file
            string documentPath = Path.Combine(DataDir, "gradient.svg");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "gradient-options.gif");

            // Initialize an SVG document from the file
            using var document = new SVGDocument(documentPath);

            // Initialize ImageSaveOptions. Set up the SmoothingMode, resolutions, and change the background color to AliceBlue 
            var options = new ImageSaveOptions(ImageFormat.Gif)
            {
                SmoothingMode = SmoothingMode.HighQuality,
                HorizontalResolution = 200,
                VerticalResolution = 200,
                BackgroundColor = Color.AliceBlue                
            };

            // Convert SVG to GIF
            Converter.ConvertSVG(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "gradient-options_1.gif")));
        }
    }    
}
