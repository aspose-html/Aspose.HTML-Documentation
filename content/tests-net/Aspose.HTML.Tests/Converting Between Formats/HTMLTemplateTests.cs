using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Loading;
using Aspose.Html.Rendering.Image;
using System;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats
{
    public class HTMLTemplateTests : TestsBase
    {
        public HTMLTemplateTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("html-template");
        }


        [Fact(DisplayName = "Convert Template to HTML With a Single Line")]
        public void ConvertWithASingleLineTest()
        {
            // Convert template to HTML
            Converter.ConvertTemplate(Path.Combine(DataDir, "template.html"), new TemplateData(Path.Combine(DataDir, "data-source.json")), new TemplateLoadOptions(), Path.Combine(OutputDir, "template-with-single-line.html"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "template-with-single-line.html")));
        }


        [Fact(DisplayName = "Convert Template to HTML")]
        public void ConvertTemplateTest()
        {
            // Prepare a path to an HTML source file
            var sourcePath = Path.Combine(DataDir, "template.html");

            // Prepare a path to an xml template data file
            var templateDataPath = Path.Combine(DataDir, "templateData.xml");

            // Define TemplateData object instance
            var templateData = new TemplateData(templateDataPath);

            // Prepare a path to the result file
            var resultPath = Path.Combine(OutputDir, "result.html");

            // Define default TemplateLoadOptions object
            var options = new TemplateLoadOptions();

            // Initialize an HTML document as conversion source
            var document = new HTMLDocument(sourcePath, new Configuration());

            // Convert template to HTML
            Converter.ConvertTemplate(document, templateData, options, resultPath);

            // Clear resources
            document.Dispose();

            Assert.True(File.Exists(resultPath));
        }


        [Fact(DisplayName = "HTMLTemplate")]
        public void HTMLTemplateTest()
        {
            // Prepare a path to JSON data source file
            string jsonPath = Path.Combine(OutputDir, "data-source.json");

            // Prepare a JSON data source and save it to the file
            var data = @"{
                'FirstName': 'John',
                'LastName': 'Doe',
                'Address': {
                    'City': 'Dallas',
                    'Street': 'Austin rd.',
                    'Number': '200'
                    }
                }";
            File.WriteAllText(jsonPath, data);

            // Prepare a path to an HTML Template file
            string sourcePath = Path.Combine(OutputDir, "template.html");           

            // Prepare an HTML Template and save it to the file
            var template = @"
                <table border=1>
                    <tr>
                        <th>Person</th>
                        <th>Address</th>
                    </tr>
                    <tr>
                        <td>{{FirstName}} {{LastName}}</td>
                        <td>{{Address.Street}} {{Address.Number}}, {{Address.City}}</td>
                    </tr>
                </table>
                ";
            File.WriteAllText(sourcePath, template);

            // Prepare a path to the output file (data-filled template file)
            string outputPath = Path.Combine(OutputDir, "template-output.html");

            // Invoke Converter.ConvertTemplate in order to populate 'template.html' with the data source from 'data-source.json' file
            Converter.ConvertTemplate(sourcePath, new TemplateData(jsonPath), new TemplateLoadOptions(), outputPath);

            Assert.True(File.Exists(outputPath));
        }


        [Fact(DisplayName = "Fill HTML Template")]
        public void FillHTMLTemplateTest()
        {
            // Create a template with a string of HTML code
            var htmlCode = "<input type=\"checkbox\" disabled {{attr}} />";

            // Set data for the template in XML format
            var dataSource = "<Data><attr>checked</attr></Data>";

            // Convert template to HTML
            using (var htmlDocument = Converter.ConvertTemplate(htmlCode, string.Empty,
                       new TemplateData(new TemplateContentOptions(dataSource, TemplateContent.XML)),
                       new TemplateLoadOptions()))
            {
                // Request the input checkbox element that we specified in the template
                var input = (HTMLInputElement)htmlDocument.GetElementsByTagName("input").First();

                // Check if it has a checkmark 
                Assert.True(input.Checked);
                Assert.Equal(3, input.Attributes.Length);
                Assert.Equal("type", input.Attributes[0].Name);
                Assert.Equal("disabled", input.Attributes[1].Name);
                Assert.Equal("checked", input.Attributes[2].Name);

                // Save the HTML document to a file
                htmlDocument.Save(Path.Combine(OutputDir, "out-checked.html"));

                // Prepare a path to the output image file
                string outputPath = Path.Combine(OutputDir, "out-checked.png"); 
                
                // Convert HTML to PNG using RenderTo() method
                htmlDocument.RenderTo(new ImageDevice(new ImageRenderingOptions(), outputPath));

                Assert.True(File.Exists(Path.Combine(OutputDir, "out-checked.html")));
            }
        }


        [Fact(DisplayName = "Fill HTML Template")]
        public void UncheckedTemplateTest()
        {
            // Create a template with a string of HTML code
            var htmlCode = "<input type=\"checkbox\" disabled {{attr}} />";

            // Create an empty data source that won't set an attribute
            var dataSource = "<Data><attr></attr></Data>";

            // Convert template to HTML
            using (var htmlDocument = Converter.ConvertTemplate(htmlCode, string.Empty,
                       new TemplateData(new TemplateContentOptions(dataSource, TemplateContent.XML)),
                       new TemplateLoadOptions()))
            {
                // Request the input checkbox element that we specified in the template
                var input = (HTMLInputElement)htmlDocument.GetElementsByTagName("input").First();

                // Сheck if the checkbox is checked - it should not be there
                Assert.False(input.Checked);
                Assert.Equal(2, input.Attributes.Length);
                Assert.Equal("type", input.Attributes[0].Name);
                Assert.Equal("disabled", input.Attributes[1].Name);

                // Save the HTML document to a file
                htmlDocument.Save(Path.Combine(OutputDir, "out-unchecked.html"));

                // Prepare a path to the output file
                string outputPath = Path.Combine(OutputDir, "out-unchecked.png");

                // Convert HTML to PNG
                htmlDocument.RenderTo(new ImageDevice(new ImageRenderingOptions(), outputPath));

                Assert.True(File.Exists(Path.Combine(OutputDir, "out-unchecked.html")));
            }
        }
    }
}
