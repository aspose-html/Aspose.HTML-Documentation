using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System;
using System.Drawing;
using System.IO;
using Xunit;
using Xunit.Abstractions;
using System.Drawing.Drawing2D;

namespace Aspose.HTML.Tests.Converting_Between_Formats.SVG_Converter
{
    public class SVGtoTIFFTests : TestsBase
    {
        public SVGtoTIFFTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("svg-converter/svg-to-tiff");
        }


        [Fact(DisplayName = "Convert SVG to TIFF With a Single Line")]
        public void ConvertSVGWithASingleLineTest()
        {
            // Invoke the ConvertSVG method for SVG to TIFF conversion          
            Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new ImageSaveOptions(ImageFormat.Tiff), Path.Combine(OutputDir, "convert-with-single-line.tiff"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-with-single-line.tiff")));
        }


        [Fact(DisplayName = "Convert SVG to TIFF")]
        public void ConvertSVGtoTIFFTest()
        {
            // Prepare SVG code 
            var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
                       "<circle cx ='100' cy ='100' r ='50' fill='pink' stroke='red' stroke-width='10' />" +
                       "</svg>";

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "circle.tiff");

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Tiff);

            // Convert SVG to TIFF
            Converter.ConvertSVG(code, ".", options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "circle.tiff")));
        }


        [Fact(DisplayName = "SVG to TIFF With ImageSaveOptions")]
        public void SVGtoTIFFWithImageSaveOptionsTest()
        {
            // Prepare a path to a source SVG file
            string documentPath = Path.Combine(DataDir, "gradient.svg");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "gradient-options.tiff");

            // Initialize an SVG document from the file
            using var document = new SVGDocument(documentPath);

            // Initialize ImageSaveOptions. Set up the compression, resolutions, and change the background color to AliceBlue 
            var options = new ImageSaveOptions(ImageFormat.Tiff)
            {
                Compression = Compression.None,
                HorizontalResolution = 200,
                VerticalResolution = 200,
                BackgroundColor = System.Drawing.Color.AliceBlue
            };

            // Convert SVG to TIFF
            Converter.ConvertSVG(document, options, savePath);

            Assert.True(File.Exists(savePath));
        }
    }  
}
