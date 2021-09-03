using Aspose.Html.Converters;
using Aspose.Html.Loading;
using System;
using System.IO;
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
    }
}
