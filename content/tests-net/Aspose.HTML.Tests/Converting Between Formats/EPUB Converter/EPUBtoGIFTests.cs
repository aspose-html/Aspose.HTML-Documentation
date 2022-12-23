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

namespace Aspose.HTML.Tests.Converting_Between_Formats.EPUB_Converter
{
    public class EPUBtoGIFTests : TestsBase
    {
        public EPUBtoGIFTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("epub-converter/epub-to-gif");
        }


        [Fact(DisplayName = "Convert EPUB to GIF by Two Lines")]
        public void ConvertEPUBbyTwoLinesTest()
        {
            // Open an existing EPUB file for reading.
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Invoke the ConvertEPUB method to convert the EPUB code to GIF image           
            Converter.ConvertEPUB(stream, new ImageSaveOptions(ImageFormat.Gif), Path.Combine(OutputDir, "convert-by-two-lines.gif"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-by-two-lines_1.gif")));
        }


        [Fact(DisplayName = "Convert EPUB to GIF")]
        public void ConvertEPUBtoGIFTest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "input-output.gif");

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Gif);

            // Call the ConvertEPUB method to convert EPUB to GIF
            Converter.ConvertEPUB(stream, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "input-output_1.gif")));
        }


        [Fact(DisplayName = "Convert EPUB to GIF with ImageSaveOptions")]
        public void ConvertEPUBtoGIFWithImageSaveOptionsTest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "input-options.gif");

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Gif)
            {
                SmoothingMode = SmoothingMode.HighQuality,
                HorizontalResolution = 400,
                VerticalResolution = 400,
                BackgroundColor = System.Drawing.Color.AliceBlue
            };
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(800, 500), new Margin(30, 20, 10, 10));

            // Call the ConvertEPUB method to convert EPUB to GIF
            Converter.ConvertEPUB(stream, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "input-options_1.gif")));
        }
    }
}
