using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Drawing;
using Aspose.Html.Saving;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using System.Drawing.Drawing2D;

namespace Aspose.HTML.Tests.Converting_Between_Formats.SVG_Converter
{
    public class SVGtoPNGTests : TestsBase
    {
        public SVGtoPNGTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("svg-converter/svg-to-png");
        }


        [Fact(DisplayName = "Convert SVG to PNG With a Single Line")]
        public void ConvertSVGWithASingleLineTest()
        {
            // Invoke the ConvertSVG method for SVG to PNG conversion          
            Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new ImageSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.png"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-with-single-line_1.png")));
        }


        [Fact(DisplayName = "Convert SVG to PNG")]
        public void ConvertSVGtoPNGTest()
        {
            // Prepare SVG code 
            var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
                       "<circle cx ='100' cy ='100' r ='60' fill='none' stroke='red' stroke-width='10' />" +
                       "</svg>";

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "circle.png");

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions();

            // Convert SVG to PNG
            Converter.ConvertSVG(code, ".", options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "circle_1.png")));
        }


        [Fact(DisplayName = "SVG to PNG With ImageSaveOptions")]
        public void SVGtoPNGWithImageSaveOptionsTest()
        {
            // Prepare a path to a source SVG file
            string documentPath = Path.Combine(DataDir, "flower1.svg");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "flower-options.png");

            // Initialize an SVG document from the file
            using var document = new SVGDocument(documentPath);

            // Initialize ImageSaveOptions. Set up the SmoothingMode, resolutions, and change the background color to AliceBlue 
            var options = new ImageSaveOptions()
            {
                HorizontalResolution = 200,
                VerticalResolution = 200,
                BackgroundColor = System.Drawing.Color.AliceBlue,
                SmoothingMode = SmoothingMode.HighQuality,
            };            

            // Convert SVG to PNG
            Converter.ConvertSVG(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "flower-options_1.png")));
        }


        [Fact(DisplayName = "Specify Custom Stream Provider")]
        public void SpecifyCustomStreamProviderTest()
        {
            // Create an instance of MemoryStreamProvider
            using var streamProvider = new MemoryStreamProvider();

            // Prepare SVG code
            var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
                       "<circle cx='50' cy='50' r='40' stroke='black' stroke-width='3' fill='red' />" +
                       "</svg>";

            // Convert SVG to PNG using the MemoryStreamProvider
            Converter.ConvertSVG(code, ".", new ImageSaveOptions(), streamProvider);

            // Get access to the memory stream that contains the result data
            var memory = streamProvider.Streams.First();
            memory.Seek(0, SeekOrigin.Begin);

            // Flush the result data to the output file
            using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.png")))
            {
                memory.CopyTo(fs);
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "stream-provider.png")));
        }


        class MemoryStreamProvider : Aspose.Html.IO.ICreateStreamProvider
        {
            // List of MemoryStream objects created during the document rendering
            public List<MemoryStream> Streams { get; } = new List<MemoryStream>();

            public Stream GetStream(string name, string extension)
            {
                // This method is called when only one output stream is required, for instance for XPS, PDF or TIFF formats
                MemoryStream result = new MemoryStream();
                Streams.Add(result);
                return result;
            }

            public Stream GetStream(string name, string extension, int page)
            {
                // This method is called when the creation of multiple output streams are required. For instance, during the rendering HTML to list of image files (JPG, PNG, etc.)
                MemoryStream result = new MemoryStream();
                Streams.Add(result);
                return result;
            }

            public void ReleaseStream(Stream stream)
            {
                //  Here you can release the stream filled with data and, for instance, flush it to the hard-drive
            }

            public void Dispose()
            {
                // Releasing resources
                foreach (var stream in Streams)
                    stream.Dispose();
            }
        }
    }    
}
