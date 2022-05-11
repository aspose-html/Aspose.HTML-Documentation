using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouKu;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;
using System;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Web_Scraping
{
    public class DownloadAudiosTests : TestsBase
    {
        public DownloadAudiosTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("audio-download");
        }


        [Fact(DisplayName = "Download Audio")]
        public void DownloadAudioTest()
        {
            // URL of the video you want to extract audio from
            string url = "https://www.youtube.com/watch?v=JlKF7z8ODIo";

            // File name for downloading audio
            string filename = "audio";

            // Initialize an instance of the MultimediaScraper class
            using var multimediaScraper = new MultimediaScraper();

            // Create a multimedia object that includes information from the URL
            using (var multimedia = multimediaScraper.GetMultimedia(url))
            {
                // Get a VideoInfo object
                var videoInfo = multimedia.CollectVideoInfo();

               // Get the first element from the formats collection with minimal bitrate and present audio. Set VideoCodec to null.
                VideoFormatInfo format = videoInfo
                    .Formats
                    .OrderByDescending(f => f.Bitrate)
                    .First(f => f.AudioCodec != null && f.VideoCodec == null);

                // Get the full file path for the output file
                var filePath = Path.Combine(OutputDir, filename + ".mp3");

                // Download the audio
                multimedia.Download(format, filePath);
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "audio.mp3")));
        }


        [Fact(DisplayName = "Download YouTube Audio")]
        public void DownloadYouTubeAudioTest()
        {
            // URL of the video you want to extract audio from
            string url = "https://www.youtube.com/watch?v=JlKF7z8ODIo";
            
            // File name for downloading audio
            string filename = "youtube-audio";

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
                // Get the first element from the formats collection with minimal bitrate and present audio. Set VideoCodec to null.
                var format = youTubeVideoInfo
                    .Formats
                    .OrderByDescending(f => f.Bitrate)
                    .First(f => f.AudioCodec != null && f.VideoCodec == null);

                // Get the full file path for the output file
                var filePath = Path.Combine(OutputDir, filename + ".mp3");

                // Download YouTube audio
                multimedia.Download(format, filePath);                
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "youtube-audio.mp3")));
        }


        [Fact(DisplayName = "Get YouTube Audio Info")]
        public void GetYouTubeAudioInfoTest()
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
                Output.WriteLine("Bitrate: {0}", videoFormatInfo.Bitrate?.ToString() ?? "[null]");
                Output.WriteLine("Audio Codec: {0}", videoFormatInfo.AudioCodec ?? "[null]");                
            }            
        }
    }
}
