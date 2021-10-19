using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.Zoom;
using System;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Web_Scraping
{
    public class DownloadZoomVideosTests : TestsBase
    {
        public DownloadZoomVideosTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("zoom-download");
        }


        [Fact(DisplayName = "Get Zoom Video Info Test1")]
        public void GetZoomVideoInfoTest1()
        {
            // URL of the video you want to extract data from
            string url = "https://zoom.us/recording/play/IMjKs3RC8-QaTcYQSFutPxB6CyrezT9pIqfsVj4nF8UIbyXbsvzMnLgjgP83cDHS";

            // Expected video properties, for example, "Title" and "Duration"
            string expectedTitle = "Zoom - Univ. Washington: Session 1";
            int expectedDuration = 0;

            // Initialize an instance of MultimediaScraper class 
            using var multimediaScraper = new MultimediaScraper();

            // Create a multimedia object that include information from the URL 
            using (var multimedia = multimediaScraper.GetMultimedia(url))
            {
                // Getting a VideoInfo object and casting it to ZoomVideoInfo type
                var info = multimedia.CollectVideoInfo();

                if (info.MultimediaHost == MultimediaHost.Zoom)
                {
                    var zoomVideoInfo = (ZoomVideoInfo)info;
                    // Show information about the video
                    Output.WriteLine("Title: {0}", zoomVideoInfo.Title);
                    Output.WriteLine("Description: {0}", zoomVideoInfo.Description);
                    Output.WriteLine("Duration: {0}", zoomVideoInfo.Duration);
                    Output.WriteLine("Thumbnails count: {0}", zoomVideoInfo.Thumbnails.Count);
                    Output.WriteLine("Formats count: {0}", zoomVideoInfo.Formats.Count);

                    // Check expected and actual data
                    Assert.Equal(expectedTitle, zoomVideoInfo.Title);
                    Assert.Equal(expectedDuration, zoomVideoInfo.Duration);
                }
            }
        }


        [Fact(DisplayName = "Get Zoom Video Info Test2")]
        public void GetZoomVideoInfoTest2()
        {
            // Initialize an instance of the MultimediaScraper class 
            using var scraper = new MultimediaScraper();

            // Create a multimedia object that include information from a URL
            using (var multimedia = scraper.GetMultimedia("https://zoom.us/recording/play/IMjKs3RC8-QaTcYQSFutPxB6CyrezT9pIqfsVj4nF8UIbyXbsvzMnLgjgP83cDHS"))
            {
                // Check MultimediaHost
                Assert.Equal(MultimediaHost.Zoom, multimedia.MultimediaHost);

                // Get a videoInfo object
                //var videoInfo = Assert.IsType<YouTubeVideoInfo>(multimedia.CollectVideoInfo());

                // Getting a videoInfo object and checking whether it is an instance of YouTubeVideoInfo class 
                var videoInfo = multimedia.CollectVideoInfo();
                if (videoInfo is ZoomVideoInfo)
                {
                    Output.WriteLine("videoInfo is an instance of the ZoomVideoInfo class");
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
                    Assert.Equal(1, videoInfo.Formats.Count);
                }
            }
        }


        [Fact(DisplayName = "Download Zoom Video")]
        public void DownloadYouTubeVideoTest()
        {
            // URL of the video you want to extract data from
            string url = "https://zoom.us/recording/play/IMjKs3RC8-QaTcYQSFutPxB6CyrezT9pIqfsVj4nF8UIbyXbsvzMnLgjgP83cDHS";

            // Expected video properties, for example, "Title" and "Duration" 
            string expectedTitle = "Zoom - Univ. Washington: Session 1";
            int expectedDuration = 0;

            // File name for downloading video
            string filename = "Session1";

            // Initialize an instance of the MultimediaScraper class
            using var multimediaScraper = new MultimediaScraper();

            // Create a multimedia object that include information from the URL
            using (var multimedia = multimediaScraper.GetMultimedia(url))
            {
                // Get a videoInfo object
                var videoInfo = multimedia.CollectVideoInfo();

                // Cast a videoInfo to YouTubeVideoInfo type
                var zoomVideoInfo = videoInfo as ZoomVideoInfo;

                if (zoomVideoInfo != null)
                {
                    // Get the first element from the formats collection with minimal bitrate and present audio and video codecs
                    var format = zoomVideoInfo.Formats.OrderBy(f => f.Bitrate).First();


                    // Get the extension for the output file
                    var ext = string.IsNullOrEmpty(format.Extension) ? "mp4" : format.Extension;

                    // Get the full file path for the output file
                    var filePath = Path.Combine(OutputDir, filename + "." + ext);

                    // Download the video
                    multimedia.Download(format, filePath);

                    // Show information about the video
                    Output.WriteLine("Title: {0}", zoomVideoInfo.Title);
                    Output.WriteLine("Description: {0}", zoomVideoInfo.Description);
                    Output.WriteLine("Duration: {0}", zoomVideoInfo.Duration);
                    Output.WriteLine("Thumbnails count: {0}", zoomVideoInfo.Thumbnails.Count);
                    Output.WriteLine("Formats count: {0}", zoomVideoInfo.Formats.Count);

                    Assert.Equal(expectedTitle, zoomVideoInfo.Title);
                    Assert.Equal(expectedDuration, zoomVideoInfo.Duration);
                }
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "Session1.mp4")));
        }
    }

}
