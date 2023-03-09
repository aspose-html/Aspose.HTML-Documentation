using Aspose.Html;
using Aspose.Html.Saving;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.How_to_Articles
{
    public class SerializeInputValueTests : TestsBase
    {
        public SerializeInputValueTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("serialize-input-value");
        }        


        [Fact(DisplayName = "Serialize Input Value in HTML Form")]
        public void SerializeInputValueTest()
        {
            var html = @"
            <html>
                <body>
                    <div>The new input element value: <input type = ""text"" value=""No"" /></div>
                </body>
            </html>";

            // Create an HTML document from string of code containing an HTMLInputElement
            using var doc = new HTMLDocument(html, string.Empty);

            // Get all elements with the <input> tag
            var inputElements = doc.GetElementsByTagName("input");

            // Take the first and only element, in this case, from the resulting collection
            var input = (HTMLInputElement)inputElements[0];

            // Set the desired value for this HTML form element
            input.Value = "Text";

            // Prepare path to save HTML 
            string savePath = Path.Combine(OutputDir, "result.html");

            // Save the HTML document with SerializeInputValue set to true
            doc.Save(savePath, new HTMLSaveOptions { SerializeInputValue = true });

            Assert.True(File.Exists(savePath));
        }        
    }
}
