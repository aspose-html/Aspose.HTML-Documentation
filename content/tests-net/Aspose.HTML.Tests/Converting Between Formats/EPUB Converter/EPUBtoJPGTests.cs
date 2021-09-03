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

namespace Aspose.HTML.Tests.Converting_Between_Formats.EPUB_Converter
{
    public class EPUBtoJPGTests : TestsBase
    {
        public EPUBtoJPGTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("epub-converter/epub-to-jpg");
        }


        [Fact(DisplayName = "Convert EPUB to JPG by Two Lines")]
        public void ConvertEPUBbyTwoLinesTest()
        {
            // Open an existing EPUB file for reading.
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Invoke the ConvertEPUB method to convert the EPUB code to JPG image           
            Converter.ConvertEPUB(stream, new ImageSaveOptions(ImageFormat.Jpeg), Path.Combine(OutputDir, "convert-by-two-lines.jpg"));            

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-by-two-lines_1.jpg")));
        }


        [Fact(DisplayName = "Convert EPUB to JPG")]
        public void ConvertEPUBtoJPGTest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "input-output.jpg");            

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Jpeg);

            // Call the ConvertEPUB method to convert EPUB to JPG
            Converter.ConvertEPUB(stream, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "input-output_1.jpg")));
        }


        [Fact(DisplayName = "Convert EPUB to JPG with ImageSaveOptions")]
        public void ConvertEPUBtoJPGWithImageSaveOptionsTest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "input-options.jpg");
                        
            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Jpeg)
            {
                SmoothingMode = SmoothingMode.HighQuality,
                HorizontalResolution = 400,
                VerticalResolution = 400,
                BackgroundColor = Color.AliceBlue
            };
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(800, 500), new Margin(30, 20, 10, 10));

            // Call the ConvertEPUB method to convert EPUB to JPG
            Converter.ConvertEPUB(stream, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "input-options_1.jpg")));
        }

                
        [Fact(DisplayName = "Specify Custom Stream Provider")]
        public void SpecifyCustomStreamProviderTest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Create an instance of MemoryStreamProvider
            using var streamProvider = new MemoryStreamProvider();

            // Convert HTML to JPG using the MemoryStreamProvider
            Converter.ConvertEPUB(stream, new ImageSaveOptions(ImageFormat.Jpeg), streamProvider);
            
            // Get access to the memory streams that contain the resulted data
            for (int i = 0; i < streamProvider.Streams.Count; i++)
            {
                var memory = streamProvider.Streams[i];
                memory.Seek(0, System.IO.SeekOrigin.Begin);

                // Flush the page to the output file
                using (FileStream fs = File.Create(Path.Combine(OutputDir, $"input-page_{i + 1}.jpg")))
                {
                    memory.CopyTo(fs);
                }
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "input-page_1.jpg")));
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
