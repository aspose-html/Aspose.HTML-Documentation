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
    public class DownloadYouTubeVideosTests :  TestsBase
    {
        public DownloadYouTubeVideosTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("youtube-download");
        }


        [Fact(DisplayName = "Get YouTube Video Info Test1")]
        public void GetYouTubeVideoInfoTest1()
        {
            // URL of the video you want to extract data from
            string url = "https://www.youtube.com/watch?v=cTnbD67vqjo";

            // Expected video properties, for example, "Title" and "Duration"
            string expectedTitle = "How to convert HTML file to JPEG";
            int expectedDuration = 71;

            // Initialize an instance of the MultimediaScraper class 
            using var multimediaScraper = new MultimediaScraper();

            // Create a multimedia object that includes information from the specified URL 
            using var multimedia = multimediaScraper.GetMultimedia(url);
            
            // Get a VideoInfo object and cast it to YouTubeVideoInfo type
            var info = multimedia.CollectVideoInfo();
            
            if(info.MultimediaHost == MultimediaHost.YouTube)
            {
                var youTubeVideoInfo = (YouTubeVideoInfo)info;
                
                // Show YouTube video info
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
        public void GetYouTubeVideoInfoTest2()
        {
            // Initialize an instance of the MultimediaScraper class 
            using var scraper = new MultimediaScraper();

            // Create a multimedia object that handles information from the specified URL
            using var multimedia = scraper.GetMultimedia("https://www.youtube.com/watch?v=Yugq1KyZCI0");
           
            // Get a VideoInfo object and check whether it is an instance of the YouTubeVideoInfo class 
            var videoInfo = multimedia.CollectVideoInfo();
            
            if (videoInfo is YouTubeVideoInfo)
            {
                Output.WriteLine("videoInfo is an instance of YouTubeVideoInfo class");

                // Show information about the video
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
                Assert.Equal(5, videoInfo.Formats.Count);
            }            
        }


        [Fact(DisplayName = "Get YouTube Video Format Info")]
        public void GetYouTubeVideoFormatInfoTest()
        {
            // URL of the video you want to extract data from
            string url = "https://www.youtube.com/watch?v=Yugq1KyZCI0";

            // Expected list of Bitrate values
            double[] expectedBitrates = {
                575105,
                253154,
                129521,
                128053,
                54530
            };
            int expectedFormatsCount = expectedBitrates.Length;

            // Initialize an instance of the MultimediaScraper class
            using var multimediaScraper = new MultimediaScraper();

            // Create a multimedia object that includes information from the URL
            using var multimedia = multimediaScraper.GetMultimedia(url);

            // Get a VideoInfo object 
            var videoInfo = multimedia.CollectVideoInfo();

            Output.WriteLine("Title: {0}", videoInfo.Title);

            if (videoInfo.Formats.Count == 2)
            {
                Output.WriteLine("License is not set, only 2 items are available");
            }
            else
            {
                // Check the count of formats
                Assert.Equal(expectedFormatsCount, videoInfo.Formats.Count);
            }

            // Show video format information from the collection of available formats
            int i = 0;
            foreach (var videoFormatInfo in videoInfo.Formats.OrderByDescending(f => f.Bitrate))
            {
                // Check Bitrate of current collection item
                double expectedBitrate = expectedBitrates[i++];
                Assert.Equal(expectedBitrate, videoFormatInfo.Bitrate.Value, 1);

                Output.WriteLine("Format #{0}", i);

                Output.WriteLine("  Bitrate: {0}", videoFormatInfo.Bitrate?.ToString() ?? "[null]");

                Output.WriteLine("  Audio Codec: {0}", videoFormatInfo.AudioCodec ?? "[null]");
                Output.WriteLine("  Video Codec: {0}", videoFormatInfo.VideoCodec ?? "[null]");

                Output.WriteLine("  Width: {0}", videoFormatInfo.Width?.ToString() ?? "[null]");
                Output.WriteLine("  Height: {0}", videoFormatInfo.Height?.ToString() ?? "[null]");

                Output.WriteLine("  Extension: {0}", videoFormatInfo.Extension ?? "[null]");
                Output.WriteLine("  File Size: {0}", videoFormatInfo.FileSize?.ToString() ?? "[null]");
                Output.WriteLine("  FPS: {0}", videoFormatInfo.FPS?.ToString() ?? "[null]");
                Output.WriteLine("  Sampling Rate: {0}", videoFormatInfo.SamplingRate?.ToString() ?? "[null]");
            }            
        }


        [Fact(DisplayName = "Download YouTube Video")]
        public void DownloadYouTubeVideoTest()
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

            // Create a multimedia object that includes information from the URL
            using var multimedia = multimediaScraper.GetMultimedia(url);

            // Get a VideoInfo object
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

                // Download YouTube video
                multimedia.Download(format, filePath);

                // Show YouTube video info
                Output.WriteLine("Title: {0}", youTubeVideoInfo.Title);
                Output.WriteLine("Description: {0}", youTubeVideoInfo.Description);
                Output.WriteLine("Duration: {0}", youTubeVideoInfo.Duration);
                Output.WriteLine("Thumbnails count: {0}", youTubeVideoInfo.Thumbnails.Count);
                Output.WriteLine("Formats count: {0}", youTubeVideoInfo.Formats.Count);

                Assert.Equal(expectedTitle, youTubeVideoInfo.Title);
                Assert.Equal(expectedDuration, youTubeVideoInfo.Duration);
            }             

            Assert.True(File.Exists(Path.Combine(OutputDir, "HTML-to-Markdown.mp4")));
        }
    }    
}
