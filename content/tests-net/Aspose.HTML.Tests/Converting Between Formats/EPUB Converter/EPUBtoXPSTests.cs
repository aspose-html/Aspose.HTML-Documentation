using Aspose.Html.Converters;
using Aspose.Html.Drawing;
using Aspose.Html.Saving;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.EPUB_Converter
{
    public class EPUBtoXPSTests : TestsBase
    {
        public EPUBtoXPSTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("epub-converter/epub-to-xps");
        }


        [Fact(DisplayName = "Convert EPUB to XPS With a Single Line")]
        public void ConvertEPUBWithASingleLineTest()
        {           
            // Invoke the ConvertEPUB method to convert EPUB to XPS           
            Converter.ConvertEPUB(File.OpenRead(DataDir + "input.epub"), new XpsSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.xps"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-with-single-line.xps")));
        }


        [Fact(DisplayName = "Convert EPUB to XPS")]
        public void ConvertEPUBToXPSTest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "input-output.xps");

            // Create an instance of XpsSaveOptions
            var options = new XpsSaveOptions();

            // Call the ConvertEPUB method to convert EPUB to XPS
            Converter.ConvertEPUB(stream, options, savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "EPUB to XPS With XpsSaveOptions")]
        public void EPUBtoXPSWithXpsSaveOptionsTest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "input-options.xps");

            // Create an instance of XpsSaveOptions. Set up the page-size and change the background color to LightGray 
            var options = new XpsSaveOptions()
            {
                PageSetup =
                    {
                        AnyPage = new Page()
                        {
                            Size = new Aspose.Html.Drawing.Size(Length.FromPixels(500), Length.FromPixels(500))
                        }
                    },
                BackgroundColor = Color.LightGray
            };

            // Call the ConvertEPUB method to convert EPUB to XPS
            Converter.ConvertEPUB(stream, options, savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Specify Custom Stream Provider")]
        public void SpecifyCustomStreamProviderTest()
        {
            // Create an instance of MemoryStreamProvider
            using var streamProvider = new MemoryStreamProvider();

            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "stream-provider.xps");

            // Convert EPUB to XPS by using the MemoryStreamProvider class
            Converter.ConvertEPUB(stream, new XpsSaveOptions(), streamProvider);

            // Get access to the memory stream that contains the result data
            var memory = streamProvider.Streams.First();
            memory.Seek(0, SeekOrigin.Begin);

            // Flush the result data to the output file
            using (FileStream fs = File.Create(savePath))
            {
                memory.CopyTo(fs);
            }

            Assert.True(File.Exists(savePath));
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
