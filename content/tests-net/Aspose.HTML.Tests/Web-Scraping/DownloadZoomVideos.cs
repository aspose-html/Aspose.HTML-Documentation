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
        

        [Fact(DisplayName = "Get Zoom Video Info Test")]
        public void GetZoomVideoInfoTest()
        {
            // Initialize an instance of the MultimediaScraper class 
            using var scraper = new MultimediaScraper();

            // Create a multimedia object that collects information from a URL
            using var multimedia = scraper.GetMultimedia("https://zoom.us/recording/play/IMjKs3RC8-QaTcYQSFutPxB6CyrezT9pIqfsVj4nF8UIbyXbsvzMnLgjgP83cDHS");
            
            // Check MultimediaHost
            Assert.Equal(MultimediaHost.Zoom, multimedia.MultimediaHost);           

            // Get a VideoInfo object and check whether it is an instance of the ZoomVideoInfo class 
            var videoInfo = multimedia.CollectVideoInfo();
            
            if (videoInfo is ZoomVideoInfo)
            {
                Output.WriteLine("videoInfo is an instance of the ZoomVideoInfo class");

                // Show information about video
                Output.WriteLine("Title: {0}", videoInfo.Title);
                Output.WriteLine("Description: {0}", videoInfo.Description);
                Output.WriteLine("Duration: {0}", videoInfo.Duration);
                Output.WriteLine("Thumbnails count: {0}", videoInfo.Thumbnails.Count);
                Output.WriteLine("Formats count: {0}", videoInfo.Formats.Count);
            }            

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


        [Fact(DisplayName = "Download Zoom Video")]
        public void DownloadZoomVideoTest()
        {
            // URL of the video you want to extract data from
            string url = "https://zoom.us/recording/play/IMjKs3RC8-QaTcYQSFutPxB6CyrezT9pIqfsVj4nF8UIbyXbsvzMnLgjgP83cDHS";

            // Expected video "Title" property 
            string expectedTitle = "Zoom - Univ. Washington: Session 1";

            // File name for video download
            string filename = "Session1";

            // Initialize an instance of the MultimediaScraper class
            using var multimediaScraper = new MultimediaScraper();

            // Create a multimedia object that collects information from the URL
            using var multimedia = multimediaScraper.GetMultimedia(url);
            
            // Get a VideoInfo object
            var videoInfo = multimedia.CollectVideoInfo();

            // Cast a videoInfo to ZoomVideoInfo type
            var zoomVideoInfo = videoInfo as ZoomVideoInfo;

            if (zoomVideoInfo != null)
            {
                // Get the first element from the formats collection with minimal bitrate 
                var format = zoomVideoInfo.Formats.OrderBy(f => f.Bitrate).First();

                // Get the extension for the output file
                var ext = string.IsNullOrEmpty(format.Extension) ? "mp4" : format.Extension;

                // Get the full file path for the output file
                var filePath = Path.Combine(OutputDir, filename + "." + ext);

                // Download Zoom video
                multimedia.Download(format, filePath);

                // Show Zoom video info
                Output.WriteLine("Title: {0}", zoomVideoInfo.Title);
                Output.WriteLine("Description: {0}", zoomVideoInfo.Description);
                Output.WriteLine("Duration: {0}", zoomVideoInfo.Duration);
                Output.WriteLine("Thumbnails count: {0}", zoomVideoInfo.Thumbnails.Count);
                Output.WriteLine("Formats count: {0}", zoomVideoInfo.Formats.Count);

                Assert.Equal(expectedTitle, zoomVideoInfo.Title);                
            }            

            Assert.True(File.Exists(Path.Combine(OutputDir, "Session1.mp4")));
        }
    }
}
