using Aspose.Html.Converters;
using Aspose.Html.Drawing;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.MHTML_Converter
{
    public class MHTMLtoImageTests : TestsBase
    {
        public MHTMLtoImageTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("mhtml-converter/mhtml-to-image");
        }


        [Fact(DisplayName = "Convert MHTML to JPG by Two Lines")]
        public void ConvertMHTMLbyTwoLinesTest()
        {
            // Open an existing MHTML file for reading
            using var stream = File.OpenRead(DataDir + "sample.mht");

            // Invoke the ConvertMHTML method to convert MHTML to JPG           
            Converter.ConvertMHTML(stream, new ImageSaveOptions(ImageFormat.Jpeg), Path.Combine(OutputDir, "convert-by-two-lines.jpg"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-by-two-lines_1.jpg")));
        }


        [Fact(DisplayName = "Convert MHTML to JPG")]
        public void ConvertMHTMLToJPGTest()
        {
            // Open an existing MHTML file for reading
            using var stream = File.OpenRead(DataDir + "sample.mht");
                        
            // Create an instance of ImageSaveOptions
            var options = new ImageSaveOptions(ImageFormat.Jpeg);

            // Call the ConvertMHTML method to convert MHTML to JPG
            Converter.ConvertMHTML(stream, options, Path.Combine(OutputDir, "sample-output.jpg"));                            

            Assert.True(File.Exists(Path.Combine(OutputDir, "sample-output_1.jpg")));
        }


        [Fact(DisplayName = "Convert MHTML to PNG")]
        public void ConvertMHTMLToPNGTest()
        {
            // Open an existing MHTML file for reading
            using var stream = File.OpenRead(DataDir + "sample.mht");

            // Create an instance of ImageSaveOptions
            var options = new ImageSaveOptions(ImageFormat.Png);

            // Call the ConvertMHTML method to convert MHTML to PNG
            Converter.ConvertMHTML(stream, options, Path.Combine(OutputDir, "sample-output.png"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "sample-output_1.png")));
        }


        [Fact(DisplayName = "Convert MHTML to BMP")]
        public void ConvertMHTMLToBMPTest()
        {
            // Open an existing MHTML file for reading
            using var stream = File.OpenRead(DataDir + "sample.mht");

            // Create an instance of ImageSaveOptions
            var options = new ImageSaveOptions(ImageFormat.Bmp);

            // Call the ConvertMHTML method to convert MHTML to BMP
            Converter.ConvertMHTML(stream, options, Path.Combine(OutputDir, "sample-output.bmp"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "sample-output_1.bmp")));
        }


        [Fact(DisplayName = "Convert MHTML to GIF")]
        public void ConvertMHTMLToGIFTest()
        {
            // Open an existing MHTML file for reading
            using var stream = File.OpenRead(DataDir + "sample.mht");

            // Create an instance of ImageSaveOptions
            var options = new ImageSaveOptions(ImageFormat.Gif);

            // Call the ConvertMHTML method to convert MHTML to GIF
            Converter.ConvertMHTML(stream, options, Path.Combine(OutputDir, "sample-output.gif"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "sample-output_1.gif")));
        }


        [Fact(DisplayName = "Convert MHTML to TIFF")]
        public void ConvertMHTMLToTIFFTest()
        {
            // Open an existing MHTML file for reading
            using var stream = File.OpenRead(DataDir + "sample.mht");

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "sample-options.tiff");

            // Create an instance of ImageSaveOptions
            var options = new ImageSaveOptions(ImageFormat.Tiff);

            // Call the ConvertMHTML method to convert MHTML to TIFF
            Converter.ConvertMHTML(stream, options, savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "MHTML to JPG With ImageSaveOptions")]
        public void MHTMLtoJPGWithImageSaveOptionsTest()
        {
            // Open an existing MHTML file for reading
            using var stream = File.OpenRead(DataDir + "sample.mht");

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "sample-options.jpg");

            // Initailize the ImageSaveOptions with a custom page-size and a background color 
            var options = new ImageSaveOptions(ImageFormat.Jpeg)
            {
                PageSetup =
                    {
                        AnyPage = new Page()
                        {
                            Size = new Aspose.Html.Drawing.Size(Length.FromPixels(1000), Length.FromPixels(500))
                        }
                    },
                BackgroundColor = System.Drawing.Color.Beige
            };

            // Call the ConvertMHTML method to convert MHTML to JPG
            Converter.ConvertMHTML(stream, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "sample-options_1.jpg")));
        }


        [Fact(DisplayName = "Specify Custom Stream Provider")]
        public void SpecifyCustomStreamProviderTest()
        {
            // Create an instance of MemoryStreamProvider
            using var streamProvider = new MemoryStreamProvider();

            // Open an existing MHTML file for reading
            using var stream = File.OpenRead(DataDir + "sample.mht");

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "stream-provider.jpg");

            // Convert MHTML to JPG by using the MemoryStreamProvider class
            Converter.ConvertMHTML(stream, new ImageSaveOptions(ImageFormat.Jpeg), streamProvider);

            // Get access to the memory streams that contain the resulted data
            for (int i = 0; i < streamProvider.Streams.Count; i++)
            {
                var memory = streamProvider.Streams[i];
                memory.Seek(0, SeekOrigin.Begin);

                // Flush the page to the output file
                //using (FileStream fs = File.Create($"page_{i + 1}.jpg"))
                using (FileStream fs = File.Create(savePath))
                {
                    memory.CopyTo(fs);
                }
            }

            //Assert.True(File.Exists(savePath));
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
