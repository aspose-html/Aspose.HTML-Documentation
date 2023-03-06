using Aspose.Html;
using Aspose.Html.Drawing;
using Aspose.Html.Rendering;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Rendering.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.How_to_Articles
{
    public class HowToResizeDocumentTests : TestsBase
    {
        public HowToResizeDocumentTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("resize-document");
        }


        [Fact(DisplayName = "Convert With Default RenderingOptions")]
        public void DefaultRenderingOptionsTest()
        {
            // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "rendering.html");

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "a4.png");

            // Create an instance of HTMLDocument class
            using var document = new HTMLDocument(documentPath);

            // Initialize an ImageRenderingOptions object with default options
            var opt = new ImageRenderingOptions();

            // Create an output rendering device and convert HTML
            using var device = new ImageDevice(opt, savePath);
            document.RenderTo(device);

            Assert.True(File.Exists(Path.Combine(OutputDir, "a4_1.png")));
        }


        [Fact(DisplayName = "Using FitWidth")]
        public void UsingFitWidthTest()
        {
            // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "rendering.html");

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "FitWidthResolution.jpg");

            // Create an instance of HTMLDocument class
            using var document = new HTMLDocument(documentPath);

            // Initialize an ImageRenderingOptions object with custom options. Use the FitToWidestContentWidth flag
            var opt = new ImageRenderingOptions(ImageFormat.Jpeg)
            {
                PageSetup =
                {
                    PageLayoutOptions = PageLayoutOptions.FitToWidestContentWidth
                },
                HorizontalResolution = 96,
                VerticalResolution = 96
            };

            // Create an output rendering device and convert HTML
            using var device = new ImageDevice(opt, savePath);
            document.RenderTo(device);

            Assert.True(File.Exists(Path.Combine(OutputDir, "FitWidth_1.jpg")));
        }


        [Fact(DisplayName = "Using FitToWidestContentWidth and FitToContentHeight")]
        public void FitPageTest()
        {
            // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "rendering.html");

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "FitPage.png");

            // Create an instance of HTMLDocument class
            using var document = new HTMLDocument(documentPath);

            // Initialize an ImageRenderingOptions object with custom options. Use FitToContentWidth and FitToContentHeight flags
            var opt = new ImageRenderingOptions()
            {
                PageSetup =
                {
                    PageLayoutOptions = PageLayoutOptions.FitToContentWidth | PageLayoutOptions.FitToContentHeight
                },
                HorizontalResolution=96,
                VerticalResolution=96
            };

            // Create an output rendering device and convert HTML
            using var device = new ImageDevice(opt, savePath);
            document.RenderTo(device);

            Assert.True(File.Exists(Path.Combine(OutputDir, "FitPage_1.png")));
        }


        [Fact(DisplayName = "Using FitToWidestContentWidth and FitToContentHeight")]
        public void FitPagePdfTest()
        {
            // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "Test.html");

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "FitPage.pdf");

            // Initialize HTMLDocument
            using var document = new HTMLDocument(documentPath);

            // Initialize an PdfRenderingOptions object with custom options. Use FitToContentWidth and FitToContentHeight flags
            var opt = new PdfRenderingOptions()
            {
                PageSetup =
                {
                    PageLayoutOptions = PageLayoutOptions.FitToContentWidth | PageLayoutOptions.FitToContentHeight
                }
            };

            // Create an output rendering device and convert HTML
            using var device = new PdfDevice(opt, savePath);
            document.RenderTo(device);

            Assert.True(File.Exists(Path.Combine(OutputDir, "FitPage.pdf")));
        }


        [Fact(DisplayName = "Using FitSmallPage ")]
        public void UsingFitSmallPageTest()
        {
            // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "rendering.html");

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "FitSmallPage.jpg");

            // Initialize HTMLDocument
            using var document = new HTMLDocument(documentPath);

            // Initialize an ImageRenderingOptions object with custom options. Use FitToWidestContentWidth and FitToContentHeight flags
            var opt = new ImageRenderingOptions(ImageFormat.Jpeg)
            {
                PageSetup =
                {
                    PageLayoutOptions = PageLayoutOptions.FitToWidestContentWidth | PageLayoutOptions.FitToContentHeight,
                    AnyPage = new Page(new Size(20,20))
                }
            };

            // Create an output rendering device and convert HTML
            using var device = new ImageDevice(opt, savePath);
            document.RenderTo(device);

            Assert.True(File.Exists(Path.Combine(OutputDir, "FitSmallPage_1.jpg")));
        }


        [Fact(DisplayName = "Using ScaleToPageWidth and ScaleToPageHeight")]
        public void ScaleSmallPageTest()
        {
            // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "rendering.html");

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "ScaleSmallPage.png");

            // Initialize an HTMLDocument object
            using var document = new HTMLDocument(documentPath);

            // Initialize an ImageRenderingOptions object and use ScaleToPageWidth and ScaleToPageHeight flags
            var opt = new ImageRenderingOptions()
            {
                PageSetup =
                {
                    PageLayoutOptions = PageLayoutOptions.ScaleToPageWidth | PageLayoutOptions.ScaleToPageHeight,
                    AnyPage = new Page(new Size(200,200))
                }
            };

            // Create an output rendering device and convert HTML
            using var device = new ImageDevice(opt, savePath);
            document.RenderTo(device);

            Assert.True(File.Exists(Path.Combine(OutputDir, "ScaleSmallPage_1.png")));
        }

    }
}
