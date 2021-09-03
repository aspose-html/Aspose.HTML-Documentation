using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.HTMLConverter
{
    public class HTMLtoMDTests : TestsBase
    {
        public HTMLtoMDTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("html-converter/html-to-md");
        }


        [Fact(DisplayName = "Convert HTML to MD")]
        public void ConvertHTMLtoMDTest()
        {
            // Prepare HTML code and save it to a file
            var code = "<h1>Header 1</h1>" +
                       "<h2>Header 2</h2>" +
                       "<p>Convert HTML to Markdown</p>";
            File.WriteAllText("convert.html", code);

            // Call ConvertHTML() method to convert HTML to Markdown
            Converter.ConvertHTML("convert.html", new MarkdownSaveOptions(), Path.Combine(OutputDir, "convert.md"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert.md")));
        }


        [Fact(DisplayName = "Convert HTML to MD Using Git Syntax")]
        public void ConvertHTMLtoMDUsingGitSyntaxTest()
        {            
            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "output-git.md");

            // Prepare HTML code and save it to the file
            var code = "<h1>Header 1</h1>" +
                       "<h2>Header 2</h2>" +
                       "<p>Hello World!!</p>";
            File.WriteAllText(Path.Combine(OutputDir, "document.html"), code);

            // Call ConvertHTML() method to convert HTML to Markdown
            Converter.ConvertHTML(Path.Combine(OutputDir, "document.html"), MarkdownSaveOptions.Git, savePath);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Inline HTML")]
        public void InlineHTMLTest()
        {
            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "inline-html.md");

            // Prepare HTML code and save it to the file
            var code = "text<div markdown='inline'><code>text</code></div>";
            File.WriteAllText(Path.Combine(OutputDir, "inline.html"), code);

            // Call ConvertHTML method to convert HTML to Markdown.
            Converter.ConvertHTML(Path.Combine(OutputDir, "inline.html"), new MarkdownSaveOptions(), savePath);

            // Output file will contain: text\r\n<div markdown="inline"><code>text</code></div>
           
            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Specify MarkdownSaveOptions")]
        public void SpecifyMarkdownSaveOptionsTest()
        {
            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "options-output.md");

            // Prepare HTML code and save it to the file
            var code = "<h1>Header 1</h1>" +
                       "<h2>Header 2</h2>" +
                       "<p>Hello, World!!</p>" +
                       "<a href='aspose.com'>aspose</a>";
            File.WriteAllText(Path.Combine(OutputDir, "options.html"), code);

            // Create an instance of SaveOptions and set up the rule: 
            // - only <a> and <p> elements will be converted to Markdown
            var options = new MarkdownSaveOptions();
            options.Features = MarkdownFeatures.Link | MarkdownFeatures.AutomaticParagraph;

            // Call the ConvertHTML method to convert the HTML to Markdown.
            Converter.ConvertHTML(Path.Combine(OutputDir, "options.html"), options, savePath);

            Assert.True(File.Exists(savePath));
        }        
    }
}
