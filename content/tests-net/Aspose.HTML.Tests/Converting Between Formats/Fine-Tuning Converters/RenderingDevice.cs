using Aspose.Html;
using Aspose.Html.Rendering.Doc;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Rendering.Xps;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.Fine_Tuning_Converters
{
    public class RenderingDevice : TestsBase
    {
        public RenderingDevice(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("fine-tuning-converters");
        }


        [Fact(DisplayName = "Convert HTML to PDF from HTML Code")]
        public void ConvertHTMLtoPDFTest()
        {
            // Prepare HTML code
            var code = @"<span>Hello World!!</span>";

            // Prepare a path to save a converted file 
            string savePath = Path.Combine(OutputDir, "document.pdf");

            // Initialize an HTML document from the HTML code
            using var document = new HTMLDocument(code, ".");

            // Create a PDF Device and specify the output file to render
            using var device = new PdfDevice(savePath);
                
            // Render HTML to PDF
            document.RenderTo(device);            

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Convert HTML to JPG")]
        public void ConvertHTMLtoJPGTest()
        {
            // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "spring.html");

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "spring-output.jpg");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Create an instance of the ImageRenderingOptions class
            var imageOptions = new ImageRenderingOptions(ImageFormat.Jpeg);

            // Create the Image Device and specify the output file to render
            using var device = new ImageDevice(imageOptions, savePath);

            // Render HTML to JPG
            document.RenderTo(device);

            Assert.True(File.Exists(Path.Combine(OutputDir, "spring-output_1.jpg")));
        }


        [Fact(DisplayName = "Convert HTML to DOCX")]
        public void ConvertHTMLtoDOCXTest()
        {
            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "document.docx");

            // Load a document from 'https://docs.aspose.com/html/net/working-with-documents/creating-a-document/document.html' web page
            using var document = new HTMLDocument("https://docs.aspose.com/html/net/working-with-documents/creating-a-document/document.html");

            // Create an instance of the DocRenderingOptions class
            var docOptions = new DocRenderingOptions();

            // Create the DocDevice object and specify the output file to render
            using var device = new DocDevice(docOptions, savePath);

            // Render HTML to DOCX
            document.RenderTo(device);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Convert HTML to XPS")]
        public void ConvertHTMLtoXPSTest()
        {
            // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "spring.html");

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "spring.xps");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);            

            // Create an instance of the XpsDevice and specify the output file to render
            using var device = new XpsDevice(savePath);

            // Render HTML to XPS
            document.RenderTo(device);

            Assert.True(File.Exists(savePath));
        }
    }
}
