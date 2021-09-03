using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.HTMLConverter
{
    public class HTMLtoMHTMLTests : TestsBase
    {
        public HTMLtoMHTMLTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("html-converter/html-to-mhtml");
        }


        [Fact(DisplayName = "Convert HTML to MHTML With a Single Line")]
        public void ConvertHTMLWithASingleLineTest()
        {
            // Invoke the ConvertHTML method to convert the HTML code to MHTML           
            Converter.ConvertHTML(@"<h1>Hellow, Word!</h1>", ".", new MHTMLSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.mht"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-with-single-line.mht")));
        }


        [Fact(DisplayName = "Convert HTML to MHTML")]
        public void ConvertHTMLtoMHTMLTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "drawing.html");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "drawing-output.mht");

            // Initialize an HTML document from the file
            using var document = new HTMLDocument(documentPath);

            // Initialize MHTMLSaveOptions 
            var options = new MHTMLSaveOptions();

            // Convert HTML to MHTML
            Converter.ConvertHTML(document, options, savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "HTML to MHTML With MHTMLSaveOptions")]
        public void HTMLtoMHTMLWithMHTMLSaveOptionsTest()
        {
            // Prepare HTML code with a link to another file and save it to the file as 'document.html'
            var code = "<span>Hello, World!!</span> " +
                       "<a href='document2.html'>click</a>";
            File.WriteAllText("document.html", code);

            // Prepare HTML code and save it to the file as 'document2.html'
            code = @"<span>Hello, World!!</span>";
            File.WriteAllText("document2.html", code);
            
            string savePath = Path.Combine(OutputDir, "output-options.mht");

            // Change the value of the resource linking depth to 1 in order to convert document with directly linked resources
            var options = new MHTMLSaveOptions()
            {
                ResourceHandlingOptions =
                {
                    MaxHandlingDepth = 1
                }
            };

            // Convert HTML to MHTML
            Converter.ConvertHTML("document.html", options, savePath);           

            Assert.True(File.Exists(savePath));
        }
    }
}
