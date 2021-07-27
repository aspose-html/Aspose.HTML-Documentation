using Aspose.Html;
using Aspose.Html.Dom;
using Aspose.Html.Dom.Traversal.Filters;
using Aspose.Html.Dom.XPath;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Web_Scraping
{
    public class HtmlNavigationTests : TestsBase
    {
        public HtmlNavigationTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("navigation");
        }


        [Fact(DisplayName = "Navigate Through HTML")]
        public void NavigateThroughHTMLTest()
        {            
            // Prepare an HTML code
            var html_code = "<span>Hello</span> <span>World!</span>";

            // Initialize a document from the prepared code
            using (var document = new HTMLDocument(html_code, "."))
            {
                // Get the reference to the first child (first SPAN) of the BODY
                var element = document.Body.FirstChild;
                Output.WriteLine(element.TextContent); // output: Hello

                // Get the reference to the whitespace between html elements
                element = element.NextSibling;
                Output.WriteLine(element.TextContent); // output: ' '

                // Get the reference to the second SPAN element
                element = element.NextSibling;
                Output.WriteLine(element.TextContent); // output: World!

                // Set an html variable for the document 
                var html = document.DocumentElement.OuterHTML;

                Output.WriteLine(html); // output: <html><head></head><body><span>Hello</span> <span>World!</span></body></html>

                Assert.StartsWith("<html", html.Trim());

                Assert.Contains("</html>", html);

                Assert.Contains("<span>Hello</span> <span>World!</span>", html);
            }           
        }


        [Fact(DisplayName = "Inspection of the HTML Document")]
        public void InspectionOfTheHtmlDocumentTest()
        {
            //Load a document from a file
            string documentPath = Path.Combine(DataDir, "html_file.html");

            using (var document = new HTMLDocument(documentPath))
            {
                // Get the html element of the document
                var element = document.DocumentElement;                
                Output.WriteLine(element.TagName); // HTML
                Assert.Equal("HTML", element.TagName);

                // Get the last element of the html element
                element = element.LastElementChild;
                Output.WriteLine(element.TagName); // BODY
                Assert.Equal("BODY", element.TagName);

                // Get the first element in the body element
                element = element.FirstElementChild;
                Output.WriteLine(element.TagName); // H1
                Output.WriteLine(element.TextContent); // Header 1
                                
                Assert.Equal("H1", element.TagName);
                Assert.Equal("Header 1", element.TextContent);
            }
        }


        [Fact(DisplayName = "Node Filter Usage")]
        public void NodeFilterUsageTest()
        {
            // Prepare an HTML code
            var code = @"
                <p>Hello</p>
                <img src='image1.png'>
                <img src='image2.png'>
                <p>World!</p>";

            // Initialize a document based on the prepared code
            using (var document = new HTMLDocument(code, "."))
            {
                // To start HTML navigation we need to create an instance of TreeWalker.
                // The specified parameters mean that it starts walking from the root of the document, iterating all nodes and use our custom implementation of the filter
                using (var iterator = document.CreateTreeWalker(document, NodeFilter.SHOW_ALL, new OnlyImageFilter()))
                {                    
                    while (iterator.NextNode() != null)
                    {
                        // Since we are using our own filter, the current node will always be an instance of the HTMLImageElement.
                        // So, we don't need the additional validations here.
                        var image = (HTMLImageElement)iterator.CurrentNode;

                        Output.WriteLine(image.Src);
                        // output: image1.png
                        // output: image2.png

                        // Set an html variable for the document 
                        var html = document.DocumentElement.OuterHTML;                        
                        
                        Assert.Contains("<p>", html);
                    }
                }
            }
        }


        [Fact(DisplayName = "XPath Query Usage")]
        public void XPathQueryUsageTest()
        {
            // Prepare an HTML code
            var code = @"
                <div class='happy'>
                    <div>
                        <span>Hello!</span>
                    </div>
                </div>
                <p class='happy'>
                    <span>World</span>
                </p>
            ";

            // Initialize a document based on the prepared code
            using (var document = new HTMLDocument(code, "."))
            {
                // Here we evaluate the XPath expression where we select all child SPAN elements from elements whose 'class' attribute equals to 'happy':
                var result = document.Evaluate("//*[@class='happy']//span",
                    document,
                    null,
                    XPathResultType.Any,
                    null);

                // Iterate over the resulted nodes
                for (Node node; (node = result.IterateNext()) != null;)
                {
                    Output.WriteLine(node.TextContent);
                    // output: Hello
                    // output: World!
                }

                Assert.True(document.QuerySelectorAll("div").Length > 0);
            }        
        }


        [Fact(DisplayName = "CSS Selector Usage")]
        public void CSSSelectorUsageTest()
        {
            // Prepare HTML code
            var code = @"
                <div class='happy'>
                    <div>
                        <span>Hello</span>
                    </div>
                </div>
                <p class='happy'>
                    <span>World!</span>
                </p>
            ";

            // Initialize a document based on the prepared code
            using (var document = new HTMLDocument(code, "."))
            {
                // Here we create a CSS Selector that extract all elements whose 'class' attribute equals to 'happy' and their child SPAN elements
                var elements = document.QuerySelectorAll(".happy span");

                // Iterate over the resulted list of elements
                foreach (HTMLElement element in elements)
                {
                    Output.WriteLine(element.InnerHTML);
                    // output: Hello
                    // output: World!
                }

                Assert.Equal("HTML", document.DocumentElement.TagName);               
            }
        }


        class OnlyImageFilter : NodeFilter
        {
            public override short AcceptNode(Node n)
            {
                // The current filter skips all elements, except IMG elements.
                return string.Equals("img", n.LocalName)
                    ? FILTER_ACCEPT
                    : FILTER_SKIP;
            }
        }
    }
}
