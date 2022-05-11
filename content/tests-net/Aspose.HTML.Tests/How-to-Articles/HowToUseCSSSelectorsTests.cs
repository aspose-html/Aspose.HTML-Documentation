using Aspose.Html;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.How_to_Articles
{
    public class HowToUseCSSSelectorsTests : TestsBase
    {
        public HowToUseCSSSelectorsTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("how-to-articles/css-selectors");
        }


        [Fact(DisplayName = "Using a CSS Selector to Extract Content")]
        public void CSSSelectorUsageTest1()
        {
            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "queryselector.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Here we create a CSS Selector that extracts the first paragraph element
            var element = document.QuerySelector("p");

            // Print content of the first paragraph  
            Output.WriteLine(element.InnerHTML);
            // output: Aspose.HTML for .NET is a cross-platform class library that enables your applications to perform a wide range of HTML manipulation tasks.

            // Set style attribute with properties for the selected element               
            element.SetAttribute("style", "color:rgb(50,150,200); background-color:#e1f0fe;");

            // Save the HTML document to a file
            document.Save(Path.Combine(OutputDir, "queryselector-p.html"));

            Assert.Equal("HTML", document.DocumentElement.TagName);
        }


        [Fact(DisplayName = "CSS Selector Usage to Style Selected Element")]
        public void CSSSelectorUsageTest2()
        {
            // Prepare output path for HTML document saving
            string savePath = Path.Combine(OutputDir, "css-celector-style.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "nature.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Create a CSS Selector that selects <div> element that is the last child of its parent
            var element = document.QuerySelector("div:last-child");

            // Set style attribute with properties for the selected element               
            element.SetAttribute("style", "color:rgb(50,150,200); background-color:#e1f0fe; text-align:center");

            Assert.Equal("HTML", document.DocumentElement.TagName);

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "CSS Selector Usage to Style Selected Elements")]
        public void CSSSelectorUsageTest3()
        {
            // Prepare output path for HTML document saving
            string savePath = Path.Combine(OutputDir, "css-selector-color.html");

            // Prepare path to source HTML file
            string documentPath = Path.Combine(DataDir, "spring.html");

            // Create an instance of an HTML document
            var document = new HTMLDocument(documentPath);

            // Here we create a CSS Selector that extracts all elements whose 'class' attribute equals 'square2'
            var elements = document.QuerySelectorAll(".square2");

            // Iterate over the resulted list of elements
            foreach (HTMLElement element in elements)
            {
                // Set style attribute with new background-color property
                element.Style.BackgroundColor = "#b0d7fb";
            }

            // Save the HTML document to a file
            document.Save(Path.Combine(savePath));

            Assert.True(File.Exists(savePath));
        }
    }
}

