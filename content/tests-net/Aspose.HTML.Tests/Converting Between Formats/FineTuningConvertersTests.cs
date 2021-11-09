using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats
{
    public class FineTuningConvertersTests : TestsBase
    {
        public FineTuningConvertersTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("fine-tuning-converters");
        }


        [Fact(DisplayName = "Convert HTML to PDF")]
        public void ConvertHTMLtoPDFTest()
        {
            // Prepare path to a source HTML file
            string documentPath = Path.Combine(DataDir, "spring.html");

            // Prepare path for converted file saving 
            string savePath = Path.Combine(OutputDir, "spring-output.pdf");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Create an instance of the PdfRenderingOptions class
            var pdfOptions = new PdfRenderingOptions();

            // Create the PDF Device and specify the output file to render
            using var device = new PdfDevice(pdfOptions, savePath);

            // Render HTML to PDF
            document.RenderTo(device);


            Assert.True(File.Exists(Path.Combine(OutputDir, "spring-output.pdf")));
        }
    }
}
