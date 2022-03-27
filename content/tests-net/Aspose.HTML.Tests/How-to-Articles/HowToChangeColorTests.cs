using Aspose.Html;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Working_with_HTML_Documents
{
    public class HowToChangeColorTests : TestsBase
    {
        public HowToChangeColorTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("how-to-articles");
        }


        [Fact(DisplayName = "How to Change Paragraph Color")]
        public void HowToChangeParagraphtColorTest1()
        {
            // Prepare output path for HTML document saving
            string savePath = Path.Combine(OutputDir, "change-paragraph-color-inline-css.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "html_file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Find the first paragraph element to set a style attribute
            var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();

            // Set the style attribute with color property
            paragraph.Style.Color = "DarkRed";
            
            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "How to Change Paragraph Color")]
        public void HowToChangePragraphColorTest2()
        {
            // Prepare output path for HTML document saving
            string savePath = Path.Combine(OutputDir, "change-paragraph-color-internal-css.html");

            string documentPath = Path.Combine(DataDir, "html_file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Create a style element and assign the grey color for all elements with class-name equals 'gr'.
            var style = document.CreateElement("style");
            style.TextContent = "p { color:DarkRed }";

            // Find the document header element and append style element to the header
            var head = document.GetElementsByTagName("head").First();
            head.AppendChild(style);
           
            // Find the paragraph element to set the class-name 'gr'
            //var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();

            // Set the class-name 'gr'
            //paragraph.ClassName = "gr";
            
            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "How to Change H1 Color")]
        public void HowToChangeHeaderColorTest2()
        {
            // Prepare an output path for a document saving
            string savePath = Path.Combine(OutputDir, "change-h1-color-inline-css.html");

            string documentPath = Path.Combine(DataDir, "html_file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Find the paragraph element to set a style attribute
            var header = (HTMLElement)document.GetElementsByTagName("h1").First();

            // Set the style attribute
            header.Style.Color = "DarkRed";

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "How to Change H1 Color")]
        public void HowToChangeHeaderColorTest1()
        {
            // Prepare an output path for a document saving
            string savePath = Path.Combine(OutputDir, "change-h1-color-internal-css.html");

            string documentPath = Path.Combine(DataDir, "html_file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Create a style element and assign the grey color for all elements with class-name equals 'gr'.
            var style = document.CreateElement("style");
            style.TextContent = "h1 { color:DarkRed }";

            // Find the document header element and append style element to the header
            var head = document.GetElementsByTagName("head").First();
            head.AppendChild(style);

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }       


        [Fact(DisplayName = "How to Change Background Color")]
        public void HowToChangeBackgroundColorTest()
        {
            // Prepare an output path for a document saving
            string savePath = Path.Combine(OutputDir, "change-background-color.html");

            string documentPath = Path.Combine(DataDir, "html_file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Find the paragraph element to set a style attribute
            var body = (HTMLElement)document.GetElementsByTagName("body").First();

            // Set the style attribute
            body.Style.BackgroundColor = "#e0e0e0";
            
            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "How to Change Border Color")]
        public void HowToChangeBorderColorTest()
        {
            // Prepare an output path for a document saving
            string savePath = Path.Combine(OutputDir, "change-border-color.html");

            string documentPath = Path.Combine(DataDir, "html_file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Find the paragraph element to set a style attribute
            var header = (HTMLElement)document.GetElementsByTagName("h1").First();

            // Set the style attribute
            header.Style.Color = "red";
            header.Style.BorderStyle = "solid";
            header.Style.BorderColor = "blue";

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }
    }
}
