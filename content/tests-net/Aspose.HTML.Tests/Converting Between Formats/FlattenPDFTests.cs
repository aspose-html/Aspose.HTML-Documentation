using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Pdf;
using Aspose.Html.Saving;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats
{
    public class FlattenPDFTests : TestsBase
    {
        public FlattenPDFTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("html-converter");
        }


        [Fact(DisplayName = "Convert HTML to PDF and Flattening PDF")]
        public void ConvertHTMLToPDFAndFlattenPDFTest()
        {
            // Prepare a path to an HTML source file
            var sourcePath = Path.Combine(DataDir, "SampleHtmlForm.html");

            // Initialize an HTML document from the file
            using HTMLDocument document = new HTMLDocument(sourcePath);

            // Prepare PDF save options
            var options = new PdfSaveOptions
            {
                // Flatten all form fields
                FormFieldBehaviour = FormFieldBehaviour.Flattened
            };

            // Prepare a path to the result file
            var resultPath = Path.Combine(OutputDir, "document.pdf");

            // Convert HTML to PDF
            Converter.ConvertHTML(document, options, resultPath);

            Assert.True(File.Exists(resultPath));
        }


        [Fact(DisplayName = "Convert MHTML to PDF and Flattening PDF")]
        public void ConvertMHTMLToPDFAndFlattenPDFTest()
        {
            // Prepare a path to an MHTML source file
            var sourcePath = Path.Combine(DataDir, "SampleHtmlForm.mhtml");

            // Initialize PDF save options
            var options = new PdfSaveOptions
            {
                // Flatten all form fields
                FormFieldBehaviour = FormFieldBehaviour.Interactive
            };

            // Prepare a path to the result file
            var resultPath = Path.Combine(OutputDir, "document-flattened.pdf");

            // Convert MHTML to PDF
            Converter.ConvertMHTML(sourcePath, options, resultPath);

            Assert.True(File.Exists(resultPath));
        }
    }
}
