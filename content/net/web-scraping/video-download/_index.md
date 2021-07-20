---
title: How to download video 
type: docs
weight: 20
aliases: /net/how-to-download-video/
description: In this article you find the required information and a few examples how to upload videos using the Aspose.HTML API and get information about them.
keywords: how to download video, video info, web scraping, data scraping, video download, multimedia download 
---

Aspose.HTML for .NET API provides a powerful toolset to analyze and collect information from HTML documents and gives a possibility to download video by its URL.  Using API functionalities, you can easily create your own application or just download and watch your favorite video offline without any internet connection.

{{% alert color="primary" %}} 
You can download video to your device from popular video hubs in any format with our Free Online [**Video Grabber**](https://products.aspose.app/html/en/video-grabber) App. 
{{% /alert %}}  

## **Data Scraping Namespaces**
Data Scraping is a way to get data from websites. Aspose.HTML API provides [Aspose.Html.DataScraping Namespaces](https://apireference.aspose.com/html/net/aspose.html.datascraping/index) that implement various multimedia scraping classes:

|[Class](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfocollection)|**Description**|
| :- | :- |
|[Multimedia](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia)|This class provides functionality to collect and download [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) (information about video & audio) from the associated page.|
|[MultimediaFactory](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediafactory)|This class represents an abstract factory which is used for Multimedia objects creation.|
|[MultimediaInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo)|Represents multimedia information such as [Description](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/description), [Duration](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/duration), Formats, [MultimediaHost](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/multimediahost), [Thumbnails](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/thumbnails), [Titles](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/title).|
| [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) |Provides functionality to register and select Multimedia object, which will be able to collect information from the specified page URL.|
|[VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo)|Represents information about a video format: names of the audio and video codec; bitrate value in KBit/s, extension, file size, video track height and width in pixels, etc.|
|[VideoFormatInfoCollection](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfocollection)|Represents a [VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo) collection, i.e. information about all available video formats.|
|[VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo)|Represents video information such as [Description](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo/properties/description), [Duration](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo/properties/duration), [Formats](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo/properties/formats), [MultimediaHost](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo/properties/multimediahost), [Thumbnails](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo/properties/thumbnails), [Titles](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo/properties/title).|
|[YouTubeVideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping.youtube/youtubevideoinfo)|Represents YouTube specific video information.|

Using the mentioned classes, you can get information or download video data through the web. For a complete list of classes and methods represented in the DataScraping Namespaces please visit [API Reference Source](https://apireference.aspose.com/html/net).

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  

## **Video Info**

Getting information about a video file using Aspose.HTML API, the following steps should be done:
1. Set a URL of the video you want to extract data from.
2. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
3. Create a multimedia object that collects information from the specified  URL.
4. Create a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object.
5. Get information about the video and display it in the console.

Following is the code snippet which can be used to get information about a video file such as Title, Description, Duration, Thumbnails, and Formats Count.

{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;
using System.IO;
using System.Linq;
...
    // URL of the video 
    string url = "https://www.youtube.com/watch?v=cTnbD67vqjo";

    // Initialize an instance of MultimediaScraper class 
    using (var multimediaScraper = new MultimediaScraper())
    {
        // Create a multimedia object that include information from the URL 
        using (var multimedia = multimediaScraper.GetMultimedia(url))
        {
            // Get videoInfo object
            VideoInfo videoInfo = multimedia.CollectVideoInfo();
    
            // Show information about video
            Console.WriteLine("Title: {0}", videoInfo.Title);
            Console.WriteLine("Description: {0}", videoInfo.Description);
            Console.WriteLine("Duration: {0}", videoInfo.Duration);
            Console.WriteLine("Thumbnails count: {0}", videoInfo.Thumbnails.Count);
            Console.WriteLine("Formats count: {0}", videoInfo.Formats.Count);            
        }
    }            

{{< /highlight >}}

In the example above, we use the [GetMultimedia()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper/methods/getmultimedia) method of MultimediaScraper class for initializing multimedia object that can collect information from the specified page URL. The [CollectVideoInfo()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/collectvideoinfo) method of the Multimedia class collects and provides video information from the associated URL. These can be the VideoInfo class properties such as Description, Duration, Formats, MultimediaHost, Thumbnails, and Title for a video file. 


## **Video Formats Info**

You may download a video in different formats: in the best available quality or, for example, in low size when you are on a slow or intermittent connection. Using the  [VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo) class, you can select a format based on some criterion or criteria.

Consider the following code snippet to get information about all the available formats for the selected video:

{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;
using System.IO;
using System.Linq;
...
    // URL of the video you want to extract data from
    string url = "https://www.youtube.com/watch?v=0Ww_tCjxsYc";
    
	// Initialize an instance of MultimediaScraper class
	using (var multimediaScraper = new MultimediaScraper())
	
	// Create a multimedia object that include information from the URL
	using (var multimedia = multimediaScraper.GetMultimedia(url))
	{
	    // Get videoInfo object
		var videoInfo = multimedia.CollectVideoInfo();
	    
	    // Show video format information from collection of available formats                
	    int i = 0;
	    foreach (VideoFormatInfo videoFormatInfo in videoInfo.Formats.OrderBy(f => f.Bitrate))
	    {
	        Console.WriteLine("Format #{0}", ++i);
	
	        Console.WriteLine("  Bitrate: {0}", videoFormatInfo.Bitrate?.ToString() ?? "[null]");
	
	        Console.WriteLine("  Audio Codec: {0}", videoFormatInfo.AudioCodec ?? "[null]");
	        Console.WriteLine("  Video Codec: {0}", videoFormatInfo.VideoCodec ?? "[null]");
	
	        Console.WriteLine("  Width: {0}", videoFormatInfo.Width?.ToString() ?? "[null]");
	        Console.WriteLine("  Height: {0}", videoFormatInfo.Height?.ToString() ?? "[null]");
	
	        Console.WriteLine("  Extension: {0}", videoFormatInfo.Extension ?? "[null]");
	        Console.WriteLine("  File Size: {0}", videoFormatInfo.FileSize?.ToString() ?? "[null]");
	        Console.WriteLine("  FPS: {0}", videoFormatInfo.FPS?.ToString() ?? "[null]");
	        Console.WriteLine("  Sampling Rate: {0}", videoFormatInfo.SamplingRate?.ToString() ?? "[null]");                    
	    }                
	}
{{< /highlight >}}


## **Download Video**

{{% alert color="primary" %}} 
**Note:** If you want to add a URL of the required video to download, first of all, make sure this uploading is not dedicated to copyright infringement.
{{% /alert %}}

The Aspose.HTML API includes a set of features for uploading video files. With this functionality, you can programmatically download videos through your own front end in your own application. You may download a video in different formats: in the best available quality or, for example, in low size when you are on a slow or intermittent connection. Using the  [VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo) class, you can select a format based on some criterion or criteria and specify the desired file extension.

To download a video file with Aspose.HTML, you should follow a few steps:
1. Set a URL and file name to download the video.
2. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
3. Create a multimedia object.
4. Create a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object.
5.  Select a format based on some criterion or criteria. For example, select the first element from the formats' collection with minimal bitrate and present audio and video codecs.
6. Specify a video format and full file path for the output file.
7. Download video using [Download()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/download) method.

Here is an example how to upload videos using the API and get information about them.

{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;
using System.IO;
using System.Linq;
...
    // URL of the video you want to download
    string url = "https://www.youtube.com/watch?v=JlKF7z8ODIo";    

    // File name for downloading video
    string filename = "HTML-to-Markdown";
    
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
        }
    }

{{< /highlight >}}

The Download() method of the Multimedia class takes as parameters the information about the video file to download (it is a local VideoFormatInfo variable `format`), and a local path to the output file `filePath`; then it downloads the video file to your local file system. 

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  










