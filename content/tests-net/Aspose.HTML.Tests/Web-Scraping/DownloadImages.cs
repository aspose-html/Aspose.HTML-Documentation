using Aspose.Html;
using Aspose.Html.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Web_Scraping
{
    public class DownloadImages : TestsBase
    {
        public DownloadImages(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("navigation/download-images");
        }


        [Fact(DisplayName = "Download Images")]
        public void DownloadImagesTest()
        {
            // Open a document you want to download images from
            using var document = new HTMLDocument("https://docs.aspose.com/svg/net/drawing-basics/svg-shapes/");

            // Collect all <img> elements
            var images = document.GetElementsByTagName("img");

            // Create a distinct collection of relative image URLs
            var urls = images.Select(element => element.GetAttribute("src")).Distinct();

            // Create absolute image URLs
            var absUrls = urls.Select(src => new Url(src, document.BaseURI));

            foreach (var url in absUrls)
            {
                // Create an image request message
                using var request = new RequestMessage(url);

                // Download image
                using var response = document.Context.Network.Send(request);

                // Check whether a response is successful
                if (response.IsSuccess)
                {
                    // Save image to a local file system                    
                    File.WriteAllBytes(Path.Combine(OutputDir, url.Pathname.Split('/').Last()), response.Content.ReadAsByteArray());

                    Assert.True(File.Exists(Path.Combine(OutputDir, url.Pathname.Split('/').Last())));
                }
            }
        }


        [Fact(DisplayName = "Download Icons")]
        public void DownloadIconsTest()
        {
            // Open a document you want to download icons from
            using var document = new HTMLDocument("https://docs.aspose.com/html/net/message-handlers/");

            // Collect all <link> elements
            var links = document.GetElementsByTagName("link");

            // Leave only "icon" elements
            var icons = links.Where(link => link.GetAttribute("rel") == "icon");

            // Create a distinct collection of relative icon URLs
            var urls = icons.Select(icon => icon.GetAttribute("href")).Distinct();

            // Create absolute icon URLs
            var absUrls = urls.Select(src => new Url(src, document.BaseURI));

            foreach (var url in absUrls)
            {
                // Create a downloading request
                using var request = new RequestMessage(url);

                // Download icon
                using var response = document.Context.Network.Send(request);

                // Check whether a response is successful
                if (response.IsSuccess)
                {
                    // Save icon to a local file system                    
                    File.WriteAllBytes(Path.Combine(OutputDir, url.Pathname.Split('/').Last()), response.Content.ReadAsByteArray());

                    Assert.True(File.Exists(Path.Combine(OutputDir, url.Pathname.Split('/').Last())));
                }
            }
        }
    }
}
