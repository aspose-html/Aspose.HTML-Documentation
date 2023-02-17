using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.How_to_Articles
{
    public class HowToInstallFontFolderTests : TestsBase
    {
        public HowToInstallFontFolderTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("how-to-articles");
        }


        [Fact(DisplayName = "User Agent Service Font Setting")]
        public void UserAgentServiceFontSettingTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "file.html");

            // Create an instance of Configuration
            using (var configuration = new Configuration())
            {
                // Get the IUserAgentService
                var service = configuration.GetService<IUserAgentService>();

                // Set a custom font folder path
                service.FontsSettings.SetFontsLookupFolder(Path.Combine(DataDir + "fonts"));

                // Initialize the HTML document with specified configuration
                using (var document = new HTMLDocument(documentPath, configuration))
                {
                    // Convert HTML to PDF
                    Converter.ConvertHTML(document, new PdfSaveOptions(), Path.Combine(OutputDir, "file-fontsetting.pdf"));
                }

                Assert.True(File.Exists(Path.Combine(OutputDir, "file-fontsetting.pdf")));
            }
        }


        [Fact(DisplayName = "Font Setting")]
        public void FontSettingTest()
        {
            // Prepare a path to a source HTML file
            string documentPath = Path.Combine(DataDir, "file.html");

            // Prepare a path to save the converted file 
            string savePath = Path.Combine(OutputDir, "file-output.png");

            // Create an instance of Configuration class
            using (var configuration = new Configuration())
            {
                // Get the IUserAgentService
                var userAgentService = configuration.GetService<IUserAgentService>();

                // Use the SetFontsLookupFolder() method to set a directory which will act as a new fontsFolder
                // Pass "true" as the recursive parameter to use all nested directories
                userAgentService.FontsSettings.SetFontsLookupFolder(Path.Combine(DataDir + "font"), true);

                // Initialize the HTML document with specified configuration
                using (var document = new HTMLDocument(documentPath, configuration))
                {
                    // Convert HTML to Image
                    Converter.ConvertHTML(document, new ImageSaveOptions(), savePath);
                }

                Assert.True(File.Exists(Path.Combine(OutputDir, "file-output_1.png")));
            }
        }
    }
}
