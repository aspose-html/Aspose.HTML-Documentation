using Aspose.Html;
using Aspose.Html.Net;
using Aspose.Html.Saving;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Web_Scraping
{
    public class DownloadWebsite : TestsBase
    {
        public DownloadWebsite(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("navigation/download-website");
        }


        [Fact(DisplayName = "Download Website")]
        public void DownloadWebsiteTest()
        {
            // Initialize HTML document from URL
            using var document = new HTMLDocument("https://docs.aspose.com/html/net/message-handlers/");

            // Create an HTMLSaveOptions object and set JavaScript property
            var options = new HTMLSaveOptions
            {
                ResourceHandlingOptions =
                {
                    JavaScript = ResourceHandling.Embed
                }
            };

            // Prepare a path to save the downloaded file
            string savePath = Path.Combine(OutputDir, "rootAndEmbedJs/result.html");

            // Save the HTML document to the specified file
            document.Save(savePath, options);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Download Site using MaxHandlingDepth")]
        public void DownloadSiteMaxHandlingDepthTest()
        {
            // Load an HTML document from URL
            using var document = new HTMLDocument("https://docs.aspose.com/html/net/message-handlers/");

            // Create an HTMLSaveOptions object and set MaxHandlingDepth property
            var options = new HTMLSaveOptions
            {
                ResourceHandlingOptions =
                {
                    MaxHandlingDepth = 1
                }
            };

            // Prepare a path for downloaded file saving 
            string savePath = Path.Combine(OutputDir, "rootAndAdjacent/result.html");

            // Save the HTML document to the specified file
            document.Save(savePath, options);

            Assert.True(File.Exists(savePath));
        }


        [Fact(DisplayName = "Download Site using PageUrlRestriction")]
        public void DownloadSitePageUrlRestrictionTest()
        {
            // Initialize HTML document from URL
            using var document = new HTMLDocument("https://docs.aspose.com/html/net/message-handlers/");

            // Create an HTMLSaveOptions object and set MaxHandlingDepth and PageUrlRestriction properties 
            var options = new HTMLSaveOptions
            {
                ResourceHandlingOptions =
                {
                    MaxHandlingDepth = 1,
                    PageUrlRestriction = UrlRestriction.SameHost
                }
            };

            // Prepare a path to save the downloaded file
            string savePath = Path.Combine(OutputDir, "rootAndManyAdjacent/result.html");

            // Save the HTML document to the specified file
            document.Save(savePath, options);

            Assert.True(File.Exists(savePath));
        }
    }        
}    

