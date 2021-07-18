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
    public class MultimediaScraping : TestsBase
    {
        public MultimediaScraping(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("multimedia-scraping");
        }

        [Fact(DisplayName = "Get Video Info Test1")]
        public void GetVideoInfoTest1()
        {
            // URL of the video you want to extract data from
            string url = "https://www.youtube.com/watch?v=LXb3EKWsInQ";

            // Expected video properties, for example, "Title" and "Duration"
            string expectedTitle = "COSTA RICA IN 4K 60fps HDR (ULTRA HD)";
            int expectedDuration = 314;

            // Initialize an instance of MultimediaScraper class 
            using (var multimediaScraper = new MultimediaScraper())
            {
                // Create a multimedia object that include information from the URL 
                using (var multimedia = multimediaScraper.GetMultimedia(url))
                {
                    // Get videoInfo object
                    VideoInfo videoInfo = multimedia.CollectVideoInfo();

                    // Show information about video
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
        }


        [Fact(DisplayName = "Get Video Info Test2")]
        public void GetVideoInfoTest2()
        {
            // Initialize an instance of MultimediaScraper class 
            using (var scraper = new MultimediaScraper())
            {
                // Create a multimedia object that include information from a URL
                using (var multimedia = scraper.GetMultimedia("https://www.youtube.com/watch?v=U7-dxzp6Jvs"))
                {
                    // Check MultimediaHost
                    Assert.Equal(MultimediaHost.YouTube, multimedia.MultimediaHost);

                    // Get videoInfo object
                    var videoInfo = Assert.IsType<YouTubeVideoInfo>(multimedia.CollectVideoInfo());

                    // Show information about video
                    Output.WriteLine("Title: {0}", videoInfo.Title);
                    Output.WriteLine("Description: {0}", videoInfo.Description);
                    Output.WriteLine("Duration: {0}", videoInfo.Duration);
                    Output.WriteLine("Thumbnails count: {0}", videoInfo.Thumbnails.Count);
                    Output.WriteLine("Formats count: {0}", videoInfo.Formats.Count);

                    // Check the count of formats
                    Assert.Equal(23, videoInfo.Formats.Count);
                }
            }
        }


        [Fact(DisplayName = "Get Video Format Info")]
        public void GetVideoFormatInfoTest()
        {
            // URL of the video you want to extract data from
            string url = "https://www.youtube.com/watch?v=kzzFPmmRQNw";

            // Expected list of Bitrate values
            double[] expectedBitrates = {
                30091,
                38223,
                52094,
                56431,
                61035,
                81299,
                103125,
                107491,
                125391,
                129898,
                163648,
                244212,
                308845,
                372151,
                483077,
                614390,
                719857,
                908254,
                1439095
            };
            int expectedFormatsCount = expectedBitrates.Length;

            // Initialize an instance of MultimediaScraper class
            using (var multimediaScraper = new MultimediaScraper())
            {
                // Create a multimedia object that include information from the URL
                using (var multimedia = multimediaScraper.GetMultimedia(url))
                {
                    // Get videoInfo object 
                    VideoInfo videoInfo = multimedia.CollectVideoInfo();
                    
                    Output.WriteLine("Title: {0}", videoInfo.Title);

                    Assert.Equal(expectedFormatsCount, videoInfo.Formats.Count);

                    // Show video format information from collection of available formats
                    int i = 0;
                    foreach (VideoFormatInfo videoFormatInfo in videoInfo.Formats.OrderBy(f => f.Bitrate))
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
        }


        [Fact(DisplayName = "Download Video")]
        public void DownloadVideoTest()
        {
            // URL of the video you want to extract data from
            string url = "https://www.youtube.com/watch?v=G-x99W-l4x4";

            // Expected video properties, for example, "Title" and "Duration" 
            string expectedTitle = "MACRO ore cheriya videography";
            int expectedDuration = 67;
            
            // File name for downloading video
            string filename = "video";

            // Initialize an instance of MultimediaScraper class
            using (var multimediaScraper = new MultimediaScraper())
            {
                // Create a multimedia object that include information from the URL
                using (var multimedia = multimediaScraper.GetMultimedia(url))
                {
                    // Get videoInfo object
                    var videoInfo = multimedia.CollectVideoInfo();                
                    
                    // Get the first element from formats collection with minimal bitrate and present audio and video codeces
                    var format = videoInfo.Formats.OrderBy(f => f.Bitrate).First(f => f.AudioCodec != null && f.VideoCodec != null);
                    
                    // Get extension for output file
                    var ext = string.IsNullOrEmpty(format.Extension) ? "mp4" : format.Extension;

                    // Get full file path for output file
                    var filePath = Path.Combine(OutputDir, filename + "." + ext);
                    
                    // Download video
                    multimedia.Download(format, filePath);

                    // Show information about video
                    Output.WriteLine("Title: {0}", videoInfo.Title);
                    Output.WriteLine("Description: {0}", videoInfo.Description);
                    Output.WriteLine("Duration: {0}", videoInfo.Duration);
                    Output.WriteLine("Thumbnails count: {0}", videoInfo.Thumbnails.Count);
                    Output.WriteLine("Formats count: {0}", videoInfo.Formats.Count);

                    Assert.Equal(expectedTitle, videoInfo.Title);
                    Assert.Equal(expectedDuration, videoInfo.Duration);
                }
            }
        }


        [Fact(DisplayName = "Video Download Test1")]        
        public void VideoDownloadTest1()
        {
            VideoDownloadAssert("https://youtube.com/watch?v=HtVdAasjOgU", 31072526, "file1");
        }

        [Fact(DisplayName = "Video Download Test2")]       
        public void VideoDownloadTest2()
        {
            VideoDownloadAssert("https://www.youtube.com/watch?v=LzPqYihbkFY", 7911761, "file2");
        }


        private void VideoDownloadAssert(string url, long expectedSize, string fileName)
        {            
            using (var scraper = new MultimediaScraper())
            {
                using (var multimedia = scraper.GetMultimedia(url))
                {
                    var info = multimedia.CollectVideoInfo();

                    // Get the first element from formats collection with maximal bitrate and present audio and video codeces
                    var format = info.Formats.OrderByDescending(f => f.Bitrate).First(f => f.AudioCodec != null && f.VideoCodec != null);

                    var ext = string.IsNullOrEmpty(format.Extension) ? "mp4" : format.Extension;
                    var filePath = Path.Combine(OutputDir, fileName + "." + ext);
                    multimedia.Download(format, filePath);

                    // Check expected and actual data 
                    Assert.Equal(expectedSize, new FileInfo(filePath).Length);
                }
            }
        }
    }
}
