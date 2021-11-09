using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Drawing;
using Aspose.Html.Saving;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.HTMLConverter
{
    public class HTMLtoPDFTests : TestsBase
    {
        public HTMLtoPDFTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("html-converter/html-to-pdf");
        }


        [Fact(DisplayName = "Convert HTML to PDF With a Single Line")]
        public void ConvertHTMLWithASingleLineTest()
        {
            // Invoke the ConvertHTML() method to convert the HTML code to PDF           
            Converter.ConvertHTML(@"<h1>Convert HTML to PDF!</h1>", ".", new PdfSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.pdf"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-with-single-line.pdf")));
        }


        [Fact(DisplayName = "Convert HTML to PDF")]
        public void ConvertHTMLtoPDFTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "spring.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "spring-output.pdf");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Initialize PdfSaveOptions 
            var options = new PdfSaveOptions();

            // Convert HTML to PDF
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "spring-output.pdf")));
        }


        [Fact(DisplayName = "HTML to PDF With PdfSaveOptions")]
        public void HTMLtoPDFWithPdfSaveOptionsTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "drawing.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "drawing-options.pdf");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Initialize PdfSaveOptions. Set up the page-size 600x300 pixels, margins, resolutions and change the background color to AliceBlue 
            var options = new PdfSaveOptions()
            {                
                HorizontalResolution = 200,
                VerticalResolution = 200,
                BackgroundColor = Color.AliceBlue,
                JpegQuality = 100
            };
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(600, 300), new Margin(20, 10, 10, 10));           

            // Convert HTML to PDF
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "drawing-options.pdf")));
        }


        [Fact(DisplayName = "Specify PdfSaveOptions")]
        public void SpecifyPdfSaveOptionsTest()
        {
            string documentPath = Path.Combine(OutputDir, "save-options.html");
            string savePath = Path.Combine(OutputDir, "save-options-output.pdf");

            // Prepare HTML code and save it to a file
            var code = "<h1>  PdfSaveOptions Class</h1>\r\n" +
                       "<p>Using PdfSaveOptions Class, you can programmatically apply a wide range of conversion parameters such as BackgroundColor, HorizontalResolution, VerticalResolution, PageSetup, etc.</p>\r\n";

            File.WriteAllText(documentPath, code);

            // Initialize an HTML Document from the html file
            using var document = new HTMLDocument(documentPath);
            
            // Set up the page-size, margins and change the background color to AntiqueWhite
            var options = new PdfSaveOptions()
            {
                BackgroundColor = Color.AntiqueWhite
            };                
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(Length.FromInches(4.9f), Length.FromInches(3.5f)), new Margin(30, 20, 10, 10));

            // Convert HTML to PDF
            Converter.ConvertHTML(document, options, savePath);            

            Assert.True(File.Exists(documentPath));
        }


        [Fact(DisplayName = "Specify Custom Stream Provider")]
        public void SpecifyCustomStreamProviderTest()
        {
            // Create an instance of MemoryStreamProvider
            using var streamProvider = new MemoryStreamProvider();

            // Initialize an HTML document
            using var document = new HTMLDocument(@"<h1>Convert HTML to PDF File Format!</h1>", ".");
            
            // Convert HTML to PDF using the MemoryStreamProvider
            Converter.ConvertHTML(document, new PdfSaveOptions(), streamProvider);

            // Get access to the memory stream that contains the result data
            var memory = streamProvider.Streams.First();
            memory.Seek(0, SeekOrigin.Begin);

            // Flush the result data to the output file
            using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.pdf")))
            {
                memory.CopyTo(fs);
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "stream-provider.pdf")));            
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
