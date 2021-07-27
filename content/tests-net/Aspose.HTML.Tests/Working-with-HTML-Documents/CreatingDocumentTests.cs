using Aspose.Html;
using Aspose.Html.Dom.Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests
{
    public class CreatingDocumentTests : TestsBase
    {
        public CreatingDocumentTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("creating");
        }
        

        [Fact(DisplayName = "Create an Empty HTML Document")]
        public void CreateEmptyDocumentTest()
        {
            // Prepare an output path for a document saving
            string documentPath = Path.Combine(OutputDir, "create-empty-document.html");

            // Initialize an empty HTML Document
            using (var document = new HTMLDocument())
            {
                // Work with the document
                
                // Save the document to a file
                document.Save(documentPath);
            }

            Assert.True(File.Exists(documentPath));
        }


        [Fact(DisplayName = "Create a New HTML Document")]
        public void CreateNewDocumentTest()
        {
            // Prepare an output path for a document saving
            string documentPath = Path.Combine(OutputDir, "create-new-document.html");

            // Initialize an empty HTML Document
            using (var document = new HTMLDocument())
            {
                // Create a text element and add it to the document
                var text = document.CreateTextNode("Hello World!");
                document.Body.AppendChild(text);

                // Save the document to a disk
                document.Save(documentPath);
            }

            Assert.True(File.Exists(documentPath));
        }


        [Fact(DisplayName = "Create an HTML Document from a String")]
        public void CreateDocumentFromContentStringTest()
        {
            // Prepare HTML code
            var html_code = "<p>Hello World!</p>";

            // Initialize a document from the string variable
            using (var document = new HTMLDocument(html_code, "."))
            {
                // Save the document to a disk
                document.Save(Path.Combine(OutputDir, "create-from-string.html"));
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "create-from-string.html")));
        }


        [Fact(DisplayName = "Load an HTML Document from Sprite.html File")]
        public void LoadDocumentFromFileTest1()
        {
            // Prepare a path to a file
            string documentPath = Path.Combine(DataDir, "Sprite.html");

            // Initialize an HTML document from the file
            using (var document = new HTMLDocument(documentPath))
            {
                // Work with the document
                               
                // Save the document to a disk
                document.Save(Path.Combine(OutputDir, "Sprite_out.html"));
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "Sprite_out.html")));
        }


        [Fact(DisplayName = "Load an HTML Document from a File")]
        public void LoadDocumentFromFileTest2()
        {
            var htmlFile = Path.Combine(OutputDir, "load-from-file.html");

            // Prepare a 'load-from-file.html' document
            File.WriteAllText(htmlFile, "Hello World!");

            // Load from the 'load-from-file.html' 
            using (var document = new HTMLDocument(htmlFile))
            {
                // Write the document content to the output stream
                Output.WriteLine(document.DocumentElement.OuterHTML);

                Assert.Contains("<html>", document.DocumentElement.OuterHTML);
            }            
        }


        [Fact(DisplayName = "Load an HTML Document from a Stream")]
        public void LoadDocumentFromStreamTest()
        {
            // Create a memory stream object
            using (var mem = new MemoryStream())
            using (var sw = new StreamWriter(mem))
            {
                // Write the HTML Code into memory object
                sw.Write("<p>Hello World! I love HTML!</p>");

                // It is important to set the position to the beginning, since HTMLDocument starts the reading exactly from the current position within the stream
                sw.Flush();
                mem.Seek(0, SeekOrigin.Begin);

                // Initialize a document from the string variable
                using (var document = new HTMLDocument(mem, "."))
                {
                    // Save the document to disk
                    document.Save(Path.Combine(OutputDir, "load-from-stream.html"));
                    
                    Assert.True(document.QuerySelectorAll("p").Length > 0);
                }
            }
        }


        [Fact(DisplayName = "Load an HTML Document from a URL")]
        public void LoadDocumentFromUrlTest()
        {
            // Load a document from 'https://docs.aspose.com/html/net/working-with-documents/creating-a-document/document.html' web page
            using (var document = new HTMLDocument("https://docs.aspose.com/html/net/working-with-documents/creating-a-document/document.html"))
            {
                var html = document.DocumentElement.OuterHTML;

                // Write the document content to the output stream
                Output.WriteLine(html);

                Assert.StartsWith("<html", html.Trim());

                Assert.Contains("</html>", html);
            }
        }


        [Fact(DisplayName = "Load an SVG document from a String")]
        public void LoadSVGDocumentFromStringTest()
        {
            // Initialize an SVG document from the string object
            using (var document = new SVGDocument("<svg xmlns='http://www.w3.org/2000/svg'><circle cx='50' cy='50' r='40'/></svg>", "."))
            {
                // Write the document content to the output stream
                Output.WriteLine(document.DocumentElement.OuterHTML);
                
                Assert.True(document.QuerySelectorAll("circle").Length > 0);
            }
        }


        [Fact(DisplayName = "HTML Document Asynchronously On Ready State Change")]
        public void HTMLDocumentAsynchronouslyOnReadyStateChangeTest()
        {
            // Initialize an AutoResetEvent
            var resetEvent = new AutoResetEvent(false);

            // Create an instance of an HTML document
            var document = new HTMLDocument();

            // Create a string variable for OuterHTML property reading
            var outerHTML = string.Empty;

            // Subscribe to 'ReadyStateChange' event
            // This event will be fired during the document loading process
            document.OnReadyStateChange += (sender, @event) =>
            {
                // Check the value of 'ReadyState' property
                // This property is representing the status of the document. For detail information please visit https://www.w3schools.com/jsref/prop_doc_readystate.asp
                if (document.ReadyState == "complete")
                {
                    // Fill the outerHTML variable by value of loaded document                  
                    outerHTML = document.DocumentElement.OuterHTML;
                    resetEvent.Set();
                }
            };

            // Navigate asynchronously at the specified Uri
            document.Navigate("https://docs.aspose.com/html/net/working-with-documents/creating-a-document/document.html");

            // Here the outerHTML is empty yet
            Assert.True(string.IsNullOrEmpty(outerHTML));

            Output.WriteLine($"outerHTML = {outerHTML}");

            //  Wait 5 seconds for the file to load
            Assert.True(resetEvent.WaitOne(5000), "Thread works too long, more than 5000 ms");
                       
            // Here the outerHTML is filled 
            Output.WriteLine("outerHTML = {0}", outerHTML);

            Assert.False(string.IsNullOrEmpty(outerHTML));

            Assert.Contains("<body>Hello World!</body>", outerHTML);

            Assert.True(document.DocumentElement.TagName.ToLower() == "html");
        }


        [Fact(DisplayName = "HTML Document Asynchronously On Load")]
        public void HTMLDocumentAsynchronouslyOnLoadTest()
        {
            // Initialize an AutoResetEvent
            var resetEvent = new AutoResetEvent(false);

            // Initialize an HTML document
            var document = new HTMLDocument();
            var isLoading = false;

            // Subscribe to the 'OnLoad' event
            // This event will be fired once the document is fully loaded
            document.OnLoad += (sender, @event) =>
            {
                isLoading = true;
                resetEvent.Set();
            };

            // Navigate asynchronously at the specified Uri
            document.Navigate("https://docs.aspose.com/html/net/working-with-documents/creating-a-document/document.html");

            // Here the document is not loaded yet
            Assert.False(isLoading);

            // Wait 5 seconds for the file to load
            Assert.True(resetEvent.WaitOne(5000), "Thread works too long, more than 5000 ms");

            // Here is the loaded document
            Assert.True(isLoading);

            Output.WriteLine("outerHTML = {0}", document.DocumentElement.OuterHTML);
        }
    }
}
