using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Drawing;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.MD_Converter
{
    public class MDtoImageTests : TestsBase
    {
        public MDtoImageTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("md-converter/md-to-image");
        }


        [Fact(DisplayName = "Convert Markdown to JPG")]
        public void ConvertMDtoJPGTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(OutputDir, "document.md");

            // Prepare a simple Markdown example
            var code = "### Hello, World!" +
                       "\r\n" +
                       "[visit applications](https://products.aspose.app/html/family)";
            // Create a Markdown file
            File.WriteAllText(sourcePath, code);

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "document-output.jpg");

            // Convert Markdown to HTML
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Convert HTML document to JPG image file format
            Converter.ConvertHTML(document, new ImageSaveOptions(ImageFormat.Jpeg), savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "document-output_1.jpg")));
        }


        [Fact(DisplayName = "Convert Markdown to JPG with ImageSaveOptions")]
        public void ConvertMDtoJPGWithImageSaveOptionsTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(DataDir, "nature.md");            

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "nature-options.jpg");

            // Convert Markdown to HTML
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Jpeg)
            {
                SmoothingMode = SmoothingMode.HighQuality,
                HorizontalResolution = 200,
                VerticalResolution = 200,
                BackgroundColor = Color.AliceBlue
            };
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(600, 950), new Margin(30, 20, 10, 10));

            // Convert HTML document to JPG image file format
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "nature-options_1.jpg")));
        }


        [Fact(DisplayName = "Convert Markdown to PNG")]
        public void ConvertMDtoPNGTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(DataDir, "document.md");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "output.png");

            // Convert Markdown to HTML
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Convert HTML document to PNG image file format
            Converter.ConvertHTML(document, new ImageSaveOptions(), savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "output_1.png")));
        }


        
        [Fact(DisplayName = "Convert Markdown to BMP")]
        public void ConvertMDtoBMPTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(DataDir, "document.md");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "output.bmp");

            // Convert Markdown to HTML
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Convert HTML document to BMP image file format
            Converter.ConvertHTML(document, new ImageSaveOptions(ImageFormat.Bmp), savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "output_1.bmp")));
        }


        [Fact(DisplayName = "Convert Markdown to GIF")]
        public void ConvertMDtoGIFTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(DataDir, "document.md");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "output.gif");

            // Convert Markdown to HTML
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Convert HTML document to GIF image file format
            Converter.ConvertHTML(document, new ImageSaveOptions(ImageFormat.Gif), savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "output_1.gif")));
        }


        [Fact(DisplayName = "Convert Markdown to TIFF")]
        public void ConvertMDtoTIFFTest()
        {
            // Prepare a path to a source Markdown file
            string sourcePath = Path.Combine(DataDir, "document.md");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "output.tiff");

            // Convert Markdown to HTML
            using var document = Converter.ConvertMarkdown(sourcePath);

            // Convert HTML document to TIFF image file format
            Converter.ConvertHTML(document, new ImageSaveOptions(ImageFormat.Tiff), savePath);

            Assert.True(File.Exists(savePath));
        }
    }
}
