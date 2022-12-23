using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Drawing;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.HTMLConverter
{
    public class HTMLtoPNGTests : TestsBase
    {
        public HTMLtoPNGTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("html-converter/html-to-png");
        }


        [Fact(DisplayName = "Convert HTML to PNG")]
        public void ConvertHTMLtoPNGTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "nature.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "nature-output.png");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Png);

            // Convert HTML to PNG
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "nature-output_1.png")));
        }


        [Fact(DisplayName = "Convert HTML to PNG with ImageSaveOptions")]
        public void ConvertHTMLtoPNGWithImageSavaOptionsTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "nature.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "nature-output-options.png");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Initialize ImageSaveOptions            
            var options = new ImageSaveOptions()
            {
                SmoothingMode = SmoothingMode.Default,
                HorizontalResolution = 100,
                VerticalResolution = 100,
                BackgroundColor = System.Drawing.Color.Beige
            };

            // Convert HTML to PNG
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "nature-output-options_1.png")));
        }


        [Fact(DisplayName = "Specify Custom Stream Provider")]
        public void SpecifyCustomStreamProviderTest()
        {
            // Create an instance of MemoryStreamProvider
            using var streamProvider = new MemoryStreamProvider();

            // Initialize an HTML document
            using var document = new HTMLDocument(@"<h1>Convert HTML to PNG File Format!</h1>", ".");
            
            // Convert HTML to JPG using the MemoryStreamProvider
            Converter.ConvertHTML(document, new ImageSaveOptions(ImageFormat.Png), streamProvider);

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
                // This method is called when the creation of multiple output streams are required. For instance, during the rendering HTML to list of the image files (JPG, PNG, etc.)
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
