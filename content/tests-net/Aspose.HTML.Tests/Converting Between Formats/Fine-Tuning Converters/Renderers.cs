using Aspose.Html;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Drawing;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Doc;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Rendering.Pdf.Encryption;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.Fine_Tuning_Converters
{
    public class Renderers : TestsBase
    {
        public Renderers(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("fine-tuning-converters");
        }


        [Fact(DisplayName = "Convert HTML to PDF with Rendering Options")]
        public void ConvertHHTMLtoPDFTOptionTsest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "file.html");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Create an instance of HTML Renderer
            using var renderer = new HtmlRenderer();

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "convert-html-options.pdf");

            // Create the instance of Rendering Options and set a custom page-size
            var options = new PdfRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(600, 200));
            options.Encryption = new PdfEncryptionInfo(
                   "user_pwd",
                   "owner_pwd",
                   PdfPermissions.PrintDocument,
                   PdfEncryptionAlgorithm.RC4_128);

            // Create an instance of PDF device
            using var device = new PdfDevice(options, savePath);

            // Render HTML to PDF
            renderer.Render(device, document);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Merge HTML to PDF")]
        public void MergeHTMLtoPDFTest()
        {
            // Prepare HTML code
            var code1 = @"<br><span style='color: green'>Hello World!!</span>";
            var code2 = @"<br><span style='color: blue'>Hello World!!</span>";
            var code3 = @"<br><span style='color: red'>Hello World!!</span>";

            // Create three HTML documents to merge later
            using var document1 = new HTMLDocument(code1, ".");
            using var document2 = new HTMLDocument(code2, ".");
            using var document3 = new HTMLDocument(code3, ".");

            // Create an instance of HTML Renderer
            using var renderer = new HtmlRenderer();

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "merge-html.pdf");

            // Create an instance of PDF device
            using var device = new PdfDevice(savePath);
                    
            // Merge all HTML documents into PDF
            renderer.Render(device, document1, document2, document3);             

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Merge HTML with Rendering Options")]
        public void MergeHTMLtoPDFTOptionTsest()
        {
            // Prepare HTML code
            var code1 = @"<br><span style='color: green'>Hello World!!</span>";
            var code2 = @"<br><span style='color: blue'>Hello World!!</span>";
            var code3 = @"<br><span style='color: red'>Hello World!!</span>";

            // Create three HTML documents to merge later
            using var document1 = new HTMLDocument(code1, ".");
            using var document2 = new HTMLDocument(code2, ".");
            using var document3 = new HTMLDocument(code3, ".");

            // Create an instance of HTML Renderer
            using var renderer = new HtmlRenderer();

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "merge-html-options.pdf");

            // Create the instance of Rendering Options and set a custom page-size
            var options = new PdfRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(400, 100));
            options.BackgroundColor = System.Drawing.Color.Azure;

            // Create an instance of PDF device
            using var device = new PdfDevice(options, savePath);

            // Merge all HTML documents into PDF
            renderer.Render(device, document1, document2, document3);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Convert MHTML with Rendering Options")]
        public void ConvertMHTMLtoPDFTOptionTsest()
        {
            // Open an existing MHTML file for reading
            using var stream = File.OpenRead(DataDir + "sample.mht");
            
            // Create an instance of MHTML Renderer
            using var renderer = new MhtmlRenderer();

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "convert-mhtml-options.pdf");

            // Create the instance of Rendering Options and set a custom page-size and background color
            var options = new PdfRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(600, 200));
            options.BackgroundColor = System.Drawing.Color.Azure;

            // Create an instance of PDF device
            using var device = new PdfDevice(options, savePath);

            // Convert MHTML to PDF
            renderer.Render(device, stream);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Convert MHTML to Image")]
        public void ConvertMHTMLtoImageTsest()
        {
            // Open an existing MHTML file for reading
            using var stream = File.OpenRead(DataDir + "sample.mht");

            // Create an instance of MHTML Renderer
            using var renderer = new MhtmlRenderer();

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "convert-mhtml.png");

            // Create the instance of Rendering Options and set a custom page-size and background color
            var options = new ImageRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(200, 100));
            options.BackgroundColor = System.Drawing.Color.Bisque;

            // Create an instance of Image device
            using var device = new ImageDevice(options, savePath);

            // Convert MHTML to PNG
            renderer.Render(device, stream);

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-mhtml_1.png")));
        }


        [Fact(DisplayName = "Convert EPUB with Rendering Options")]
        public void ConvertEpubtoDOCXTOptionTsest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Create an instance of EPUB Renderer
            using var renderer = new EpubRenderer();

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "convert-epub-options.docx");

            // Create the instance of Rendering Options and set a custom page-size
            var options = new DocRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(800, 400));            

            // Create an instance of the DocDevice class
            using var device = new DocDevice(options, savePath);

            // Render EPUB to DOCX
            renderer.Render(device, stream);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Convert EPUB to PDF")]
        public void ConvertEpubtoPDFTOptionTsest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Create an instance of EPUB Renderer
            using var renderer = new EpubRenderer();

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "convert-epub.pdf");

            // Create the instance of Rendering Options and set a custom page-size
            var options = new PdfRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(800, 400));

            // Create an instance of PDF device
            using var device = new PdfDevice(options, savePath);

            // Convert EPUB to PDF
            renderer.Render(device, stream);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Merge SVG to PDF")]
        public void MergeSVGtoPDFTest()
        {
            // Initialize an SVG document from the file
            using var document1 = new SVGDocument(Path.Combine(DataDir, "shapes.svg"));
            using var document2 = new SVGDocument(Path.Combine(DataDir, "aspose.svg"));

            // Create an instance of SVG Renderer
            using var renderer = new SvgRenderer();

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "merge-svg.pdf");

            // Create the instance of Rendering Options and set a custom page-size
            var options = new PdfRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(600, 500));            

            // Create an instance of PDF device
            using var device = new PdfDevice(options, savePath);

            // Merge all SVG documents into PDF
            renderer.Render(device, document1, document2);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Timeout")]
        public void TimeoutTest()
        {
            // Prepare HTML code
            var code = @"
            <script>
                var count = 0;
                setInterval(function()
                    {
                        var element = document.createElement('div');
                        var message = (++count) + '. ' + 'Hello, World!! I know how to use Renderers!';
                        var text = document.createTextNode(message);
                        element.appendChild(text);
                        document.body.appendChild(element);
                    }, 1000);
            </script>";

            // Initialize an HTML document based on prepared HTML code
            using var document = new HTMLDocument(code, ".");

            // Create an instance of HTML Renderer
            using HtmlRenderer renderer = new HtmlRenderer();

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "output-timeout.pdf");

            // Create an instance of PDF device
            using var device = new PdfDevice(savePath);
                    
            // Render HTML to PDF
            renderer.Render(device, TimeSpan.FromSeconds(5), document);                
            
            Assert.True(File.Exists(savePath));
        }
    }
}
