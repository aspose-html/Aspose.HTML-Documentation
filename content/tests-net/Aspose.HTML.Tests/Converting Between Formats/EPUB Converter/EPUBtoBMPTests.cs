using Aspose.Html;
using Aspose.Html.Converters;
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
    public class EPUBtoBMPTests : TestsBase
    {
        public EPUBtoBMPTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("epub-converter/epub-to-bmp");
        }


        [Fact(DisplayName = "Convert EPUB to BMP by Two Lines")]
        public void ConvertEPUBbyTwoLinesTest()
        {
            // Open an existing EPUB file for reading.
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Invoke the ConvertEPUB method to convert the EPUB code to BMP image           
            Converter.ConvertEPUB(stream, new ImageSaveOptions(ImageFormat.Bmp), Path.Combine(OutputDir, "convert-by-two-lines.bmp"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-by-two-lines_1.bmp")));
        }


        [Fact(DisplayName = "Convert EPUB to BMP")]
        public void ConvertEPUBtoBMPTest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "input-output.bmp");

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Bmp);

            // Call the ConvertEPUB method to convert EPUB to BMP
            Converter.ConvertEPUB(stream, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "input-output_1.bmp")));
        }


        [Fact(DisplayName = "Convert EPUB to BMP with ImageSaveOptions")]
        public void ConvertEPUBtoBMPWithImageSaveOptionsTest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "input-options.bmp");

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Bmp)
            {
                SmoothingMode = SmoothingMode.HighQuality,
                HorizontalResolution = 400,
                VerticalResolution = 400,
                BackgroundColor = System.Drawing.Color.AliceBlue
            };            

            // Call the ConvertEPUB method to convert EPUB to BMP
            Converter.ConvertEPUB(stream, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "input-options_1.bmp")));
        }
    }
}
