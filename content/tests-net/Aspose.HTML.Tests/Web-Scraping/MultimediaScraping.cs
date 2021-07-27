using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Web_Scraping
{
    public class MultimediaScrapingTests : TestsBase
    {
        public MultimediaScrapingTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("multimedia-scraping");
        }


        [Fact(DisplayName = "Get Video Info Test1")]
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
                // Get a videoInfo object
                var videoInfo = multimedia.CollectVideoInfo();

                // Show information about the video
                Output.WriteLine("Title: {0}", videoInfo.Title);
                Output.WriteLine("Description: {0}", videoInfo.Description);
                Output.WriteLine("Duration: {0}", videoInfo.Duration);
                Output.WriteLine("Thumbnails count: {0}", videoInfo.Thumbnails.Count);
                Output.WriteLine("Formats count: {0}", videoInfo.Formats.Count);

                // Check expected and actual data
                Assert.Equal(expectedTitle, videoInfo.Title);
                Assert.Equal(expectedDuration, videoInfo.Duration);
            }                       
        }


        [Fact(DisplayName = "Get Video Info Test2")]
        public void GetVideoInfoTest2()
        {
            // Initialize an instance of MultimediaScraper class 
            using var scraper = new MultimediaScraper();
            
            // Create a multimedia object that include information from a URL
            using (var multimedia = scraper.GetMultimedia("https://www.youtube.com/watch?v=Yugq1KyZCI0"))
            {
                // Check MultimediaHost
                Assert.Equal(MultimediaHost.YouTube, multimedia.MultimediaHost);

                // Get a videoInfo object
                var videoInfo = Assert.IsType<YouTubeVideoInfo>(multimedia.CollectVideoInfo());

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


        [Fact(DisplayName = "Get Video Format Info")]
        public void GetVideoFormatInfoTest()
        {
            // URL of the video you want to extract data from
            string url = "https://www.youtube.com/watch?v=0Ww_tCjxsYc";

            // Expected list of Bitrate values
            double[] expectedBitrates = {
                432821,
                281724,
                156375,
                129584,
                76672
            };
            int expectedFormatsCount = expectedBitrates.Length;

            // Initialize an instance of MultimediaScraper class
            using var multimediaScraper = new MultimediaScraper();
            
            // Create a multimedia object that include information from the URL
            using (var multimedia = multimediaScraper.GetMultimedia(url))
            {
                // Get a videoInfo object 
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
        }


        [Fact(DisplayName = "Download Video")]
        public void DownloadVideoTest()
        {
            // URL of the video you want to extract data from
            string url = "https://www.youtube.com/watch?v=JlKF7z8ODIo";

            // Expected video properties, for example, "Title" and "Duration" 
            string expectedTitle = "How to convert HTML file to Markdown";
            int expectedDuration = 56;
            
            // File name for downloading video
            string filename = "HTML-to-Markdown";

            // Initialize an instance of MultimediaScraper class
            using var multimediaScraper = new MultimediaScraper();
            
            // Create a multimedia object that include information from the URL
            using (var multimedia = multimediaScraper.GetMultimedia(url))
            {
                // Get a videoInfo object
                var videoInfo = multimedia.CollectVideoInfo();                
                
                // Get the first element from the formats collection with minimal bitrate and present audio and video codecs
                var format = videoInfo.Formats.OrderBy(f => f.Bitrate).First(f => f.AudioCodec != null && f.VideoCodec != null);

                // Get the extension for the output file
                var ext = string.IsNullOrEmpty(format.Extension) ? "mp4" : format.Extension;

                // Get the full file path for the output file
                var filePath = Path.Combine(OutputDir, filename + "." + ext);
                
                // Download video
                multimedia.Download(format, filePath);

                // Show information about the video
                Output.WriteLine("Title: {0}", videoInfo.Title);
                Output.WriteLine("Description: {0}", videoInfo.Description);
                Output.WriteLine("Duration: {0}", videoInfo.Duration);
                Output.WriteLine("Thumbnails count: {0}", videoInfo.Thumbnails.Count);
                Output.WriteLine("Formats count: {0}", videoInfo.Formats.Count);

                Assert.Equal(expectedTitle, videoInfo.Title);
                Assert.Equal(expectedDuration, videoInfo.Duration);
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "HTML-to-Markdown.mp4")));            
        }


        [Fact(DisplayName = "Video Download Test1")]        
        public void VideoDownloadTest1()
        {
            VideoDownloadAssert("https://www.youtube.com/watch?v=oWAc7meoktE", 2478206, "SVG to JPEG");
        }


        [Fact(DisplayName = "Video Download Test2")]       
        public void VideoDownloadTest2()
        {
            VideoDownloadAssert("https://www.youtube.com/watch?v=cTnbD67vqjo", 3522137, "HTML to JPEG");
        }


        private void VideoDownloadAssert(string url, long expectedSize, string fileName)
        {
            using var scraper = new MultimediaScraper();
            
            using (var multimedia = scraper.GetMultimedia(url))
            {
                var info = multimedia.CollectVideoInfo();

                // Get the first element from the formats collection with maximal bitrate and present audio and video codecs
                var format = info.Formats.OrderBy(f => f.Bitrate).Last(f => f.AudioCodec != null && f.VideoCodec != null);

                var ext = string.IsNullOrEmpty(format.Extension) ? "mp4" : format.Extension;
                var filePath = Path.Combine(OutputDir, fileName + "." + ext);
                multimedia.Download(format, filePath);

                // Check expected and actual data 
                Assert.Equal(expectedSize, new FileInfo(filePath).Length);
            }            
        }
    }
}
