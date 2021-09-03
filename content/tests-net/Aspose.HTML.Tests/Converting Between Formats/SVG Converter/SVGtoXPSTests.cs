using Aspose.Html;
using Aspose.Html.Converters;
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

namespace Aspose.HTML.Tests.Converting_Between_Formats.SVG_Converter
{
    public class SVGtoXPSTests : TestsBase
    {
        public SVGtoXPSTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("svg-converter/svg-to-xps");
        }


        [Fact(DisplayName = "Convert SVG to XPS With a Single Line")]
        public void ConvertSVGWithASingleLineTest()
        {
            // Invoke the ConvertSVG method to convert SVG to XPS           
            Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new XpsSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.xps"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-with-single-line.xps")));
        }


        [Fact(DisplayName = "Convert SVG to XPS")]
        public void ConvertSVGtoXPSTest()
        {
            // Prepare SVG code 
            var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
                       "<circle cx ='100' cy ='100' r ='60' fill='none' stroke='red' stroke-width='10' />" +
                       "</svg>";

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "circle.xps");

            // Initialize XpsSaveOptions 
            var options = new XpsSaveOptions();

            // Convert SVG to XPS
            Converter.ConvertSVG(code, ".", options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "circle.xps")));
        }


        [Fact(DisplayName = "SVG to XPS With XpsSaveOptions")]
        public void SVGtoXPSWithXpsSaveOptionsTest()
        {
            // Prepare a path to a source SVG file
            string documentPath = Path.Combine(DataDir, "aspose.svg");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "aspose-options.xps");

            // Initialize an SVG document from the file
            using var document = new SVGDocument(documentPath);

            // Initialize XpsSaveOptions. Set up the page-size 500x500 pixels, margins, resolutions and change the background color to AliceBlue 
            var options = new XpsSaveOptions()
            {
                HorizontalResolution = 200,
                VerticalResolution = 200,
                BackgroundColor = Color.AliceBlue               
            };
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(500, 500), new Margin(30, 10, 10, 10));

            // Convert SVG to XPS
            Converter.ConvertSVG(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "aspose-options.xps")));
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

            // Convert SVG to XPS using the MemoryStreamProvider
            Converter.ConvertSVG(code, ".", new XpsSaveOptions(), streamProvider);

            // Get access to the memory stream that contains the result data
            var memory = streamProvider.Streams.First();
            memory.Seek(0, SeekOrigin.Begin);

            // Flush the result data to the output file
            using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.xps")))
            {
                memory.CopyTo(fs);
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "stream-provider.xps")));
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
