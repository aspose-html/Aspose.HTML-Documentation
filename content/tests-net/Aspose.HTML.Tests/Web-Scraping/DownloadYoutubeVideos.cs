using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;
using System;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Web_Scraping
{
    public class DownloadYoutubeVideosTests :  TestsBase
    {
        public DownloadYoutubeVideosTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("youtube-download");
        }


        [Fact(DisplayName = "Get YouTube Video Info Test1")]
        public void GetVideoInfoTest1()
        {
            // URL of the video you want to extract data from
            string url = "https://www.youtube.com/watch?v=cTnbD67vqjo";

            // Expected video properties, for example, "Title" and "Duration"
            string expectedTitle = "How to convert HTML file to JPEG";
            int expectedDuration = 71;

            // Initialize an instance of MultimediaScraper class 
            using var multimediaScraper = new MultimediaScraper();

            // Create a multimedia object that include information from the URL 
            using (var multimedia = multimediaScraper.GetMultimedia(url))
            {
                // Getting a VideoInfo object and casting it to YouTubeVideoInfo type
                YouTubeVideoInfo youTubeVideoInfo = multimedia.CollectVideoInfo() as YouTubeVideoInfo;
               
                //var YouTubeVideoInfo = new VideoInfo(MultimediaHost.YouTube);
                                
                // Show information about the video
                Output.WriteLine("Title: {0}", youTubeVideoInfo.Title);
                Output.WriteLine("Description: {0}", youTubeVideoInfo.Description);
                Output.WriteLine("Duration: {0}", youTubeVideoInfo.Duration);
                Output.WriteLine("Thumbnails count: {0}", youTubeVideoInfo.Thumbnails.Count);
                Output.WriteLine("Formats count: {0}", youTubeVideoInfo.Formats.Count);

                // Check expected and actual data
                Assert.Equal(expectedTitle, youTubeVideoInfo.Title);
                Assert.Equal(expectedDuration, youTubeVideoInfo.Duration);
            }
        }


        [Fact(DisplayName = "Get YouTube Video Info Test2")]
        public void GetVideoInfoTest2()
        {
            // Initialize an instance of the MultimediaScraper class 
            using var scraper = new MultimediaScraper();

            // Create a multimedia object that include information from a URL
            using (var multimedia = scraper.GetMultimedia("https://www.youtube.com/watch?v=Yugq1KyZCI0"))
            {
                // Check MultimediaHost
                Assert.Equal(MultimediaHost.YouTube, multimedia.MultimediaHost);

                // Get a videoInfo object
                //var videoInfo = Assert.IsType<YouTubeVideoInfo>(multimedia.CollectVideoInfo());

                // Getting a videoInfo object and checking whether it is an instance of YouTubeVideoInfo class 
                var videoInfo = multimedia.CollectVideoInfo();
                if (videoInfo is YouTubeVideoInfo)
                {
                    Output.WriteLine("videoInfo is instance of YouTubeVideoInfo class");
                }

                // Show information about video
                Output.WriteLine("Title: {0}", videoInfo.Title);
                Output.WriteLine("Description: {0}", videoInfo.Description);
                Output.WriteLine("Duration: {0}", videoInfo.Duration);
                Output.WriteLine("Thumbnails count: {0}", videoInfo.Thumbnails.Count);
                Output.WriteLine("Formats count: {0}", videoInfo.Formats.Count);

                if (videoInfo.Formats.Count == 2)
                {
                    Output.WriteLine("License is not set, only 2 items are available");
                }
                else
                {
                    // Check the count of formats
                    Assert.Equal(5, videoInfo.Formats.Count);
                }
            }
        }

        [Fact(DisplayName = "Download YouTube Video")]
        public void DownloadVideoTest()
        {
            // URL of the video you want to extract data from
            string url = "https://www.youtube.com/watch?v=JlKF7z8ODIo";

            // Expected video properties, for example, "Title" and "Duration" 
            string expectedTitle = "How to convert HTML file to Markdown";
            int expectedDuration = 56;

            // File name for downloading video
            string filename = "HTML-to-Markdown";

            // Initialize an instance of the MultimediaScraper class
            using var multimediaScraper = new MultimediaScraper();

            // Create a multimedia object that include information from the URL
            using (var multimedia = multimediaScraper.GetMultimedia(url))
            {
                // Get a videoInfo object
                var videoInfo = multimedia.CollectVideoInfo();

                // Cast a videoInfo to YouTubeVideoInfo type
                var youTubeVideoInfo = videoInfo as YouTubeVideoInfo;

                if (youTubeVideoInfo != null)
                {
                    // Get the first element from the formats collection with minimal bitrate and present audio and video codecs
                    var format = youTubeVideoInfo.Formats.OrderBy(f => f.Bitrate).First(f => f.AudioCodec != null && f.VideoCodec != null);

                    // Get the extension for the output file
                    var ext = string.IsNullOrEmpty(format.Extension) ? "mp4" : format.Extension;

                    // Get the full file path for the output file
                    var filePath = Path.Combine(OutputDir, filename + "." + ext);

                    // Download the video
                    multimedia.Download(format, filePath);

                    // Show information about the video
                    Output.WriteLine("Title: {0}", youTubeVideoInfo.Title);
                    Output.WriteLine("Description: {0}", youTubeVideoInfo.Description);
                    Output.WriteLine("Duration: {0}", youTubeVideoInfo.Duration);
                    Output.WriteLine("Thumbnails count: {0}", youTubeVideoInfo.Thumbnails.Count);
                    Output.WriteLine("Formats count: {0}", youTubeVideoInfo.Formats.Count);

                    Assert.Equal(expectedTitle, youTubeVideoInfo.Title);
                    Assert.Equal(expectedDuration, youTubeVideoInfo.Duration);

                }                
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "HTML-to-Markdown.mp4")));
        }
    }    
}
