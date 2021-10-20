using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouKu;
using System;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Web_Scraping
{
    public class DownloadYouKuVideosTests : TestsBase
    {
        public DownloadYouKuVideosTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("youku-download");
        }


        [Fact(DisplayName = "Get YouKu Video Info Test")]
        public void GetYouKuVideoInfoTest()
        {
            // URL of the video you want to extract data from
            string url = "https://v.youku.com/v_show/id_XMzgyODk3MDk0NA==.html?spm=a2h0c.8166622.PhoneSokuUgc_5.dscreenshot";

            // Expected video properties, for example, "Title" and "Duration"
            string expectedTitle = "News 24";
            int expectedDuration = 59;

            // Initialize an instance of the MultimediaScraper class 
            using var multimediaScraper = new MultimediaScraper();

            // Create a multimedia object that includes information from the URL 
            using var multimedia = multimediaScraper.GetMultimedia(url);
            
            // Get a VideoInfo object 
            var info = multimedia.CollectVideoInfo();
            
            if (info.MultimediaHost == MultimediaHost.YouKu)
            {
                var youKuVideoInfo = (YouKuVideoInfo)info;

                // Show YouKu video info
                Output.WriteLine("Title: {0}", youKuVideoInfo.Title);
                Output.WriteLine("Description: {0}", youKuVideoInfo.Description);
                Output.WriteLine("Duration: {0}", youKuVideoInfo.Duration);
                Output.WriteLine("Thumbnails count: {0}", youKuVideoInfo.Thumbnails.Count);
                Output.WriteLine("Formats count: {0}", youKuVideoInfo.Formats.Count);

                // Check expected and actual data
                Assert.Equal(expectedTitle, youKuVideoInfo.Title);
                Assert.Equal(expectedDuration, youKuVideoInfo.Duration);
            }            
        }       


        [Fact(DisplayName = "Download YouKu Video")]
        public void DownloadYouKuVideoTest()
        {
            // URL of the video you want to extract data from
            string url = "https://v.youku.com/v_show/id_XMzgyODk3MDk0NA==.html?spm=a2h0c.8166622.PhoneSokuUgc_5.dscreenshot";

            // Expected video properties, for example, "Title" and "Duration" 
            string expectedTitle = "News 24";
            int expectedDuration = 59;

            // File name for downloading video
            string filename = "News-24";

            // Initialize an instance of the MultimediaScraper class
            using var multimediaScraper = new MultimediaScraper();

            // Create a multimedia object that includes information from the URL
            using var multimedia = multimediaScraper.GetMultimedia(url);
            
            // Get a VideoInfo object
            var videoInfo = multimedia.CollectVideoInfo();

            // Cast a videoInfo to YouKuVideoInfo type
            var youKuVideoInfo = videoInfo as YouKuVideoInfo;

            if (youKuVideoInfo != null)
            {
                // Get the first element from the formats collection with minimal bitrate
                var format = youKuVideoInfo.Formats.OrderBy(f => f.Bitrate).First();

                // Get the extension for the output file
                var ext = string.IsNullOrEmpty(format.Extension) ? "mp4" : format.Extension;

                // Get the full file path for the output file
                var filePath = Path.Combine(OutputDir, filename + "." + ext);

                // Download YouKu video
                multimedia.Download(format, filePath);

                // Show YouKu video info
                Output.WriteLine("Title: {0}", youKuVideoInfo.Title);
                Output.WriteLine("Description: {0}", youKuVideoInfo.Description);
                Output.WriteLine("Duration: {0}", youKuVideoInfo.Duration);
                Output.WriteLine("Thumbnails count: {0}", youKuVideoInfo.Thumbnails.Count);
                Output.WriteLine("Formats count: {0}", youKuVideoInfo.Formats.Count);

                Assert.Equal(expectedTitle, youKuVideoInfo.Title);
                Assert.Equal(expectedDuration, youKuVideoInfo.Duration);
            }            

            Assert.True(File.Exists(Path.Combine(OutputDir, "News-24.mp4")));
        }
    }
}
