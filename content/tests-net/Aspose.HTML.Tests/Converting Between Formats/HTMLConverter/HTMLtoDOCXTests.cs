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
    public class HTMLtoDOCXTests : TestsBase
    {
        public HTMLtoDOCXTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("html-converter/html-to-docx");
        }


        [Fact(DisplayName = "Convert HTML to DOCX With a Single Line")]
        public void ConvertHTMLWithASingleLineTest()
        {
            // Invoke the ConvertHTML method to convert HTML code to DOCX           
            Converter.ConvertHTML(@"<h1>Convert HTML to DOCX!</h1>", ".", new DocSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.docx"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-with-single-line.docx")));
        }


        [Fact(DisplayName = "Convert HTML to DOCX")]
        public void ConvertHTMLtoDOCXTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "canvas.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "canvas-output.docx");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Initialize DocSaveOptions 
            var options = new DocSaveOptions();

            // Convert HTML to DOCX
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "HTML to DOCX With DocSaveOptions")]
        public void HTMLtoDOCXWithDocSaveOptionsTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "canvas.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "canvas-output-options.docx");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Initialize DocSaveOptions. Set up the page-size 600x400 pixels and margins
            var options = new DocSaveOptions();
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(600, 400), new Margin(10, 10, 10, 10));

            // Convert HTML to DOCX
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Specify DocSaveOptions")]
        public void SpecifyDocSaveOptionsTest()
        {
            string documentPath = Path.Combine(OutputDir, "save-options.html");
            string savePath = Path.Combine(OutputDir, "save-options-output.docx");

            // Prepare HTML code and save it to a file
            var code = "<h1>DocSaveOptions Class</h1>\r\n" +
                       "<p>Using DocSaveOptions Class, you can programmatically apply a wide range of conversion parameters.</p>\r\n";

            File.WriteAllText(documentPath, code);

            // Initialize an HTML Document from the html file
            using var document = new HTMLDocument(documentPath);

            // Initialize DocSaveOptions. Set A5 as a page-size 
            var options = new DocSaveOptions();            
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(Length.FromInches(8.3f), Length.FromInches(5.8f)));

            // Convert HTML to DOCX
            Converter.ConvertHTML(document, options, savePath);            

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Specify Custom Stream Provider")]
        public void SpecifyCustomStreamProviderTest()
        {
            // Create an instance of MemoryStreamProvider
            using var streamProvider = new MemoryStreamProvider();

            // Initialize an HTML document
            using var document = new HTMLDocument(@"<h1>Convert HTML to DOCX File Format!</h1>", ".");
            
            // Convert HTML to DOCX using the MemoryStreamProvider
            Converter.ConvertHTML(document, new DocSaveOptions(), streamProvider);

            // Get access to the memory stream that contains the result data
            var memory = streamProvider.Streams.First();
            memory.Seek(0, SeekOrigin.Begin);

            // Flush the result data to the output file
            using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.docx")))
            {
                memory.CopyTo(fs);
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "stream-provider.docx")));            
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
