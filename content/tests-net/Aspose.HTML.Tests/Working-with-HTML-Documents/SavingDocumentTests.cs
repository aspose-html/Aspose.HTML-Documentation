using Aspose.Html;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Saving;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests
{
    public class SavingDocumentTests : TestsBase
    {
        public SavingDocumentTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("saving");
        }


        [Fact(DisplayName = "Save HTML To File")]
        public void SaveHTMLToFileTest()
        {
            // Prepare an output path for a document saving
            string documentPath = Path.Combine(OutputDir, "save-to-file.html");

            // Initialize an empty HTML document
            using (var document = new HTMLDocument())
            {
                // Create a text element and add it to the document
                var text = document.CreateTextNode("Hello World!");
                document.Body.AppendChild(text);

                // Save the HTML document to the file on a disk
                document.Save(documentPath);

                Assert.True(document.QuerySelectorAll("body").Length > 0);
            }

            Assert.True(File.Exists(documentPath));
        }


        [Fact(DisplayName = "Save HTML With a Linked File")]
        public void SaveHTMLWithLinkedFileTest()
        {
            // Prepare an output path for an HTML document 
            string documentPath = Path.Combine(OutputDir, "save-with-linked-file.html");

            // Prepare a simple HTML file with a linked document
            File.WriteAllText(documentPath, "<p>Hello World!</p>" +
                                            "<a href='linked.html'>linked file</a>");

            // Prepare a simple linked HTML file
            File.WriteAllText(Path.Combine(OutputDir, "linked.html"), "<p>Hello linked file!</p>");

            // Load the "save-with-linked-file.html" into memory
            using (var document = new HTMLDocument(documentPath))
            {
                // Create a save options instance
                var options = new HTMLSaveOptions();

                // The following line with value '0' cuts off all other linked HTML-files while saving this instance
                // If you remove this line or change value to the '1', the 'linked.html' file will be saved as well to the output folder
                options.ResourceHandlingOptions.MaxHandlingDepth = 1;

                // Save the document with the save options
                document.Save(Path.Combine(OutputDir, "save-with-linked-file_out.html"), options);

                Assert.True(document.QuerySelectorAll("p").Length > 0);
            }

            Assert.True(File.Exists(documentPath));
        }


        [Fact(DisplayName = "Save HTML To MHTML")]
        public void SaveHTMLToMHTMLTest()
        {
            // Prepare an output path for a document saving
            string savePath = Path.Combine(OutputDir, "save-to-MHTML.mht");
            
            // Prepare a simple HTML file with a linked document
            File.WriteAllText("save-to-MHTML.html", "<p>Hello World!</p>" +
                                                    "<a href='linked-file.html'>linked file</a>");

            // Prepare a simple linked HTML file
            File.WriteAllText("linked-file.html", "<p>Hello linked file!</p>");

            // Load the "save-to-MTHML.html" into memory
            using (var document = new HTMLDocument("save-to-MHTML.html"))
            {
                // Save the document to MHTML format
                document.Save(savePath, HTMLSaveFormat.MHTML);

                Assert.True(document.QuerySelectorAll("a").Length > 0);
            }

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Save HTML To MD")]
        public void SaveHTMLToMDTest()
        {
            // Prepare an output path for a document saving
            string documentPath = Path.Combine(OutputDir, "save-to-MD.md");

            // Prepare HTML code
            var html_code = "<H2>Hello World!</H2>";

            // Initialize a document from a string variable
            using (var document = new HTMLDocument(html_code, "."))
            {
                // Save the document as a Markdown file
                document.Save(documentPath, HTMLSaveFormat.Markdown);

                Assert.True(document.QuerySelectorAll("H2").Length > 0);
            }

            Assert.True(File.Exists(documentPath));
        }


        [Fact(DisplayName = "Save HTML To SVG")]
        public void SaveHTMLToSVGTest()
        {
            // Prepare an output path for a document saving
            string documentPath = Path.Combine(OutputDir, "save-to-SVG.svg");

            // Prepare SVG code
            var code = @"
                <svg xmlns='http://www.w3.org/2000/svg' height='200' width='300'>
                    <g fill='none' stroke-width= '10' stroke-dasharray='30 10'>
                        <path stroke='red' d='M 25 40 l 215 0' />
                        <path stroke='black' d='M 35 80 l 215 0' />
                        <path stroke='blue' d='M 45 120 l 215 0' />
                    </g>
                </svg>";

            // Initialize an SVG instance from the content string
            using (var document = new SVGDocument(code, "."))
            {
                // Save the SVG file to a disk
                document.Save(documentPath);

                Assert.True(document.QuerySelectorAll("path").Length > 2);
            }

            Assert.True(File.Exists(documentPath));
        }
    }
}
