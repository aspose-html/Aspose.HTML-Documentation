using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Drawing;
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
    public class HTMLtoXPSTests : TestsBase
    {
        public HTMLtoXPSTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("html-converter/html-to-xps");
        }


        [Fact(DisplayName = "Convert HTML to XPS With a Single Line")]
        public void ConvertHTMLWithASingleLineTest()
        {
            // Invoke the ConvertHTML method to convert the HTML code to XPS           
            Converter.ConvertHTML(@"<h1>Convert HTML to XPS!</h1>", ".", new XpsSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.xps"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-with-single-line.xps")));
        }


        [Fact(DisplayName = "Convert HTML to XPS")]
        public void ConvertHTMLtoXPSTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "canvas.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "canvas-output.xps");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Initialize XpsSaveOptions 
            var options = new XpsSaveOptions();

            // Convert HTML to XPS
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(savePath));
        }          


        [Fact(DisplayName = "Specify XpsSaveOptions")]
        public void SpecifyXpsSaveOptionsTest()
        {
            string documentPath = Path.Combine(OutputDir, "save-options.html");
            string savePath = Path.Combine(OutputDir, "save-options-output.xps");

            // Prepare HTML code and save it to a file
            var code = "<h1>  XpsSaveOptions Class</h1>\r\n" +
                       "<p>Using XpsSaveOptions Class, you can programmatically apply a wide range of conversion parameters such as BackgroundColor, PageSetup, etc.</p>\r\n";

            File.WriteAllText(documentPath, code);

            // Initialize an HTML Document from the html file
            using var document = new HTMLDocument(documentPath);
            
            // Set up the page-size, margins and change the background color to AntiqueWhite
            var options = new XpsSaveOptions()
            {
                BackgroundColor = System.Drawing.Color.AntiqueWhite
            };
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(Length.FromInches(4.9f), Length.FromInches(3.5f)), new Margin(30, 20, 10, 10));

            // Convert HTML to XPS
            Converter.ConvertHTML(document, options, savePath);            

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Specify Custom Stream Provider")]
        public void SpecifyCustomStreamProviderTest()
        {
            // Create an instance of MemoryStreamProvider
            using var streamProvider = new MemoryStreamProvider();

            // Initialize an HTML document
            using var document = new HTMLDocument(@"<h1>Convert HTML to XPS File Format!</h1>", ".");
            
            // Convert HTML to XPS using the MemoryStreamProvider
            Converter.ConvertHTML(document, new XpsSaveOptions(), streamProvider);

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
