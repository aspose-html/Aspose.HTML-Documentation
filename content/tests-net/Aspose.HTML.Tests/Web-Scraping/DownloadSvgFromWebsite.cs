using Aspose.Html;
using Aspose.Html.Net;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Web_Scraping
{
    public class DownloadSvgFromWebsite : TestsBase
    {
        public DownloadSvgFromWebsite(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("navigation/download-svg-from-website");
        }


        [Fact(DisplayName = "Download Inline SVG")]
        public void DownloadInlineSvgTest()
        {
            // Open a document you want to download inline SVG images from
            using var document = new HTMLDocument("https://docs.aspose.com/svg/net/drawing-basics/svg-shapes/");

            // Collect all inline SVG images
            var images = document.GetElementsByTagName("svg");

            for (var i = 0; i < images.Length; i++)
            {
                // Save every image to local file system
                File.WriteAllText(Path.Combine(OutputDir, $"{i}.svg"), images[i].OuterHTML);
                Output.WriteLine(document.Images[i].OuterHTML);

                Assert.True(File.Exists(Path.Combine(OutputDir, $"{i}.svg")));
            }            
        }


        [Fact(DisplayName = "Download External SVG")]
        public void DownloadExternalSvg1Test()
        {
            // Open the document you want to download external SVGs from
            using var document = new HTMLDocument("https://docs.aspose.com/html/net/message-handlers/");

            // Collect all image elements
            var images = document.GetElementsByTagName("img");

            // Create a distinct collection of relative image URLs
            var urls = images.Select(element => element.GetAttribute("src")).Distinct();

            // Filter out non SVG images
            var svgUrls = urls.Where(url => url.EndsWith(".svg"));

            // Create absolute SVG image URLs
            var absUrls = svgUrls.Select(src => new Url(src, document.BaseURI));

            foreach (var url in absUrls)
            {
                // Create a downloading request
                using var request = new RequestMessage(url);

                // Download SVG image
                using var response = document.Context.Network.Send(request);

                // Check whether response is successful
                if (response.IsSuccess)
                {
                    // Save SVG image to local file system
                    File.WriteAllBytes(Path.Combine(OutputDir, url.Pathname.Split('/').Last()), response.Content.ReadAsByteArray());

                    Assert.True(File.Exists(Path.Combine(OutputDir, url.Pathname.Split('/').Last())));
                }
            }            
        }
    }
}

