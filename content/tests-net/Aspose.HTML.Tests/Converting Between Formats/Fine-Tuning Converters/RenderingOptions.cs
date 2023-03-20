using Aspose.Html;
using Aspose.Html.Drawing;
using Aspose.Html.Rendering.Doc;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Rendering.Pdf.Encryption;
using Aspose.Html.Rendering.Xps;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.Fine_Tuning_Converters
{
    public class RenderingOptions : TestsBase
    {
        public RenderingOptions(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("fine-tuning-converters");
        }


        [Fact(DisplayName = "Use Rendering Options")]
        public void UseRenderingOptionsTest()
        {
            var code = @"<span>Hello World!!</span>";

            // Initialize an HTML document from the HTML code
            using var document = new HTMLDocument(code, ".");

            // Create the instance of PdfRenderingOptions and set a custom page size
            var options = new PdfRenderingOptions()
            {
                PageSetup =
                    {
                        AnyPage = new Page(new Size(Length.FromInches(4),Length.FromInches(2)))
                    }
            };                

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "file-with-custom-page-size.pdf");            

            // Create an instance of the PdfDevice and specify the options and output file to render
            using var device = new PdfDevice(options, savePath);

            // Render HTML to PDF
            document.RenderTo(device);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Use General Options")]
        public void UseGeneralOptionsTest()
        {
            // Prepare HTML code and save it to a file
            var code = @"
                <style>
                p
                { 
                    background: #a7d3fe; 
                }
                @media(min-resolution: 300dpi)
                {
                    p 
                    { 
                        /* high resolution screen color */
                        background: orange
                    }
                }
                </style>
                <p>Hello World!!</p>";

            File.WriteAllText("document.html", code);

            // Prepare path to save output file 
            string savePath1 = Path.Combine(OutputDir, "output_resolution_50.pdf");
            string savePath2 = Path.Combine(OutputDir, "output_resolution_300.pdf");

            // Create an instance of HTML document
            using (var document = new HTMLDocument("document.html"))
            {

                // Create options for low-resolution screens
                var options1 = new PdfRenderingOptions()
                {
                    HorizontalResolution = 50,
                    VerticalResolution = 50
                };

                // Create an instance of PDF device
                using var device1 = new PdfDevice(options1, savePath1);

                // Render HTML to PDF
                document.RenderTo(device1);


                // Create options for high-resolution screens
                var options2 = new PdfRenderingOptions()
                {
                    HorizontalResolution = 300,
                    VerticalResolution = 300
                };

                // Create an instance of PDF device
                using var device2 = new PdfDevice(options2, savePath2);

                // Render HTML to PDF
                document.RenderTo(device2);
            }

            Assert.True(File.Exists(savePath1));
        }


        [Fact(DisplayName = "Use Resolution Options")]
        public void UseResolutionTest()
        {
            // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "spring.html");            

            // Create an instance of HTML document
            using var document = new HTMLDocument(documentPath);

            // Prepare path to save output file 
            string savePath1 = Path.Combine(OutputDir, "output_resolution_50.png");
            string savePath2 = Path.Combine(OutputDir, "output_resolution_300.png");

            // Create options for low-resolution screens
                var options1 = new ImageRenderingOptions()
                {
                    HorizontalResolution = 50,
                    VerticalResolution = 50
                };

            // Create an instance of Image device
            using var device1 = new ImageDevice(options1, savePath1);

            // Render HTML to PNG
            document.RenderTo(device1);


            // Create options for high-resolution screens
            var options2 = new ImageRenderingOptions()
            {
                HorizontalResolution = 300,
                VerticalResolution = 300
            };

            // Create an instance of Image device
            using var device2 = new ImageDevice(options2, savePath2);

            // Render HTML to PNG
            document.RenderTo(device2);            

            Assert.True(File.Exists(Path.Combine(OutputDir, "output_resolution_50_1.png")));
        }


        [Fact(DisplayName = "Use Background Color")]
        public void UseBackgroundColorTest()
        {
            // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "spring.html");

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "spring.pdf");

            // Create an instance of HTML document
            using var document = new HTMLDocument(documentPath);

            // Initialize options with 'cyan' as a background-color
            var options = new PdfRenderingOptions()
            {
                BackgroundColor = System.Drawing.Color.Azure
            };

            // Create an instance of PDF device
            using var device = new PdfDevice(options, savePath);

            // Render HTML to PDF
            document.RenderTo(device);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Use Page Setup")]
        public void UsePageSetupTest()
        {
            // Prepare HTML code
            var code = @"<style>div { page-break-after: always; }</style>
            <div>First Page</div>
            <div>Second Page</div>
            <div>Third Page</div>
            <div>Fourth Page</div>";

            // Initialize an HTML document from the HTML code
            using var document = new HTMLDocument(code, ".");

            // Create the instance of Rendering Options and set a custom page size
            var options = new PdfRenderingOptions();
            options.PageSetup.SetLeftRightPage(
                new Page(new Size(400, 150)),
                new Page(new Size(400, 50))
            );

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "output-custom-page-size.pdf");

            // Create the PDF Device and specify options and output file
            using var device = new PdfDevice(options, savePath);

            // Render HTML to PDF
            document.RenderTo(device);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Use PageSetup.AdjustToWidestPage")]
        public void PageSetupAdjustToWidestPageTest()
        {
            // Prepare HTML code
            var code = @"<style>
                div { page-break-after: always; }
            </style>
            <div style='border: 1px solid red; width: 300px'>First Page</div>
            <div style='border: 1px solid red; width: 500px'>Second Page</div>
";
            // Initialize an HTML document from the HTML code
            using var document = new HTMLDocument(code, ".");

            // Create the instance of Rendering Options and set a custom page-size
            var options = new PdfRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(400, 200));

            // Enable auto-adjusting for the page size
            options.PageSetup.AdjustToWidestPage = true;

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "output-widest-page-size.pdf");

            // Create the PDF Device and specify options and output file
            using var device = new PdfDevice(options, savePath);

            // Render HTML to PDF
            document.RenderTo(device);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Use PdfRenderingOptions")]
        public void UsePdfRenderingOptionsTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "document.html");

            // Initialize the HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Create the instance of Rendering Options
            var options = new PdfRenderingOptions();

            // Set the permissions to the file
            options.Encryption = new PdfEncryptionInfo(
                    "user_pwd",
                    "owner_pwd",
                    PdfPermissions.PrintDocument,
                    PdfEncryptionAlgorithm.RC4_128);

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "output-options.pdf");

            // Create an instance of the PdfDevice and specify options and output file
            using var device = new PdfDevice(options, savePath);

            // Render HTML to PDF
            document.RenderTo(device);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Use ImageRenderingOptions")]
        public void UseImageRenderingOptionsTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "color.html");

            // Initialize the HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Create an instance of Rendering Options
            var options = new ImageRenderingOptions(ImageFormat.Jpeg)
            {
                // Disable smoothing mode
                SmoothingMode = SmoothingMode.None,

                // Set the image resolution as 75 dpi
                VerticalResolution = Resolution.FromDotsPerInch(75),
                HorizontalResolution = Resolution.FromDotsPerInch(75),
            };

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "color-options.jpg");

            // Create an instance of the ImageDevice and specify options and output file
            using var device = new ImageDevice(options, savePath);

            // Render HTML to JPG
            document.RenderTo(device);

            Assert.True(File.Exists(Path.Combine(OutputDir, "output-options_1.jpg")));
        }


        [Fact(DisplayName = "Use XpsRenderingOptions")]
        public void UseXpsRenderingOptionsTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "document.html");

            // Initialize the HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Create an instance of Rendering Options
            var options = new XpsRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(Length.FromInches(5), Length.FromInches(2)));

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "document-options.xps");

            // Create an instance of the XpsDevice and specify options and output file
            using var device = new XpsDevice(options, savePath);

            // Render HTML to XPS
            document.RenderTo(device);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Use DocRenderingOptions")]
        public void UseDocRenderingOptionsTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "nature.html");

            // Initialize the HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Create an instance of Rendering Options and set a custom page size
            var options = new DocRenderingOptions();
            options.PageSetup.AnyPage = new Page(new Size(Length.FromInches(8), Length.FromInches(10)));
            options.FontEmbeddingRule = (FontEmbeddingRule.Full);

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "nature-options.docx");

            // Create an instance of the DocDevice and specify options and output file
            using var device = new DocDevice(options, savePath);

            // Render HTML to DOCX
            document.RenderTo(device);

            Assert.True(File.Exists(savePath));
        }
    }
}
