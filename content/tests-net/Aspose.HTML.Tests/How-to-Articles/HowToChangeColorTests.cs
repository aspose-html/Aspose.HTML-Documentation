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
            string documentPath = Path.Combine(DataDir, "file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Find the first paragraph element to set a style attribute
            var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();

            // Set the style attribute with color property
            paragraph.Style.Color = "#8B0000";
            
            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "How to Change Paragraph Color")]
        public void HowToChangePragraphColorTest2()
        {
            // Prepare output path for HTML document saving
            string savePath = Path.Combine(OutputDir, "change-paragraph-color-internal-css.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Create a style element and assign the text color value for all paragraph elements
            var style = document.CreateElement("style");
            style.TextContent = "p { color:#8B0000 }";

            // Find the document head element and append style element to the head
            var head = document.GetElementsByTagName("head").First();
            head.AppendChild(style);          
            
            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "How to Change H1 Color")]
        public void HowToChangeHeaderColorTest1()
        {
            // Prepare output path for document saving
            string savePath = Path.Combine(OutputDir, "change-h1-color-inline-css.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Find the h1 element to set a style attribute
            var header = (HTMLElement)document.GetElementsByTagName("h1").First();

            // Set the style attribute with color property
            header.Style.Color = "DarkRed";

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "How to Change H1 Color")]
        public void HowToChangeHeaderColorTest2()
        {
            // Prepare output path for document saving
            string savePath = Path.Combine(OutputDir, "change-h1-color-internal-css.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Create a style element and assign the color value for all h1 elements
            var style = document.CreateElement("style");
            style.TextContent = "h1 { color:DarkRed }";

            // Find the document head element and append style element to the head
            var head = document.GetElementsByTagName("head").First();
            head.AppendChild(style);

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }       


        [Fact(DisplayName = "How to Change Background Color for Paragraph")]
        public void HowToChangeBackgroundColorPTest()
        {
            // Prepare output path for document saving
            string savePath = Path.Combine(OutputDir, "change-background-color-p-inline-css.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Find the paragraph element to set a style attribute
            var paragraph = (HTMLElement)document.GetElementsByTagName("p").First();

            // Set the style attribute with background-color property
            paragraph.Style.BackgroundColor = "#e5f3fd";
            
            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }

       
        [Fact(DisplayName = "How to Change Background Color")]
        public void HowToChangeBackgroundColorTest1()
        {
            // Prepare output path for document saving
            string savePath = Path.Combine(OutputDir, "change-background-color-inline-css.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Find the body element to set a style attribute
            var body = (HTMLElement)document.GetElementsByTagName("body").First();

            // Set the style attribute with background-color property
            body.Style.BackgroundColor = "#e5f3fd";

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }

        [Fact(DisplayName = "How to Change Background Color")]
        public void HowToChangeBackgroundColorTest2()
        {
            // Prepare output path for document saving
            string savePath = Path.Combine(OutputDir, "change-background-color-internal-css.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Find the body element
            var body = (HTMLElement)document.GetElementsByTagName("body").First();

            // Remove the background-color property from the style attribute
            body.Style.RemoveProperty("background-color");

            // Create a style element and assign the background-color value for body element
            var style = document.CreateElement("style");
            style.TextContent = "body { background-color: rgb(229, 243, 253) }";

            // Find the document head element and append style element to the head
            var head = document.GetElementsByTagName("head").First();
            head.AppendChild(style);

            // Save the HTML document
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "How to Change Border Color")]
        public void HowToChangeBorderColorTest1()
        {
            // Prepare an output path for a document saving
            string savePath = Path.Combine(OutputDir, "change-border-color.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Find the h1 element to set a style attribute
            var header = (HTMLElement)document.GetElementsByTagName("h1").First();

            // Set the style attribute properties
            header.Style.Color = "#8B0000";
            header.Style.BorderStyle = "solid";
            header.Style.BorderColor = "rgb(220,30,100)";

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "How to Change Border Color")]
        public void HowToChangeBorderColorTest2()
        {
            // Prepare an output path for a document saving
            string savePath = Path.Combine(OutputDir, "change-four-border-color.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "change-border-color.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Find the h1 element to set a style attribute
            var header = (HTMLElement)document.GetElementsByTagName("h1").First();

            // Set the style attribute properties
            header.Style.BorderStyle = "solid";
            header.Style.BorderColor = "red blue green gray";

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }

        [Fact(DisplayName = "How to Change Border Color")]
        public void HowToChangeBorderColorTest3()
        {
            // Prepare an output path for a document saving
            string savePath = Path.Combine(OutputDir, "change-border-color-internal-css.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "file.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Create a style element and assign the color border-style and border-color values for h1 element
            var style = document.CreateElement("style");
            style.TextContent = "h1 {color:DarkRed; border-style:solid; border-color:rgb(220,30,100) }";

            // Find the document head element and append style element to the head
            var head = document.GetElementsByTagName("head").First();
            head.AppendChild(style);             

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "How to Change Table Border Color")]
        public void HowToChangeTableBorderColorTest1()
        {
            // Prepare an output path for a document saving
            string savePath = Path.Combine(OutputDir, "change-table-border-color-inline-css.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "table.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Create a CSS Selector that selects the first table element
            var element = document.QuerySelector("table");

            // Set style attribute with properties for the selected element               
            element.SetAttribute("style", "border: 2px #0000ff solid");

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "How to Change Table Border Color")]
        public void HowToChangeTableBorderColorTest2()
        {
            // Prepare an output path for a document saving
            string savePath = Path.Combine(OutputDir, "change-table-border-color-internal-css.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "table.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Create a style element and assign the color border-style and border-color values for table element
            var style = document.CreateElement("style");
            style.TextContent = "table { border-style:solid; border-color:rgb(0, 0, 255) }";

            // Find the document head element and append style element to the head
            var head = document.GetElementsByTagName("head").First();
            head.AppendChild(style);

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }
    }
}
