---
title: Download YouTube Videos | C# Examples
linktitle: Download YouTube Videos
keywords: youtube video, how to download youtube video, download youtube video, youtube video info, video formats,
  extract data, data scraping, C# example
description: In this article, you find the description and a few C# examples of how to download youtube videos using the Aspose.HTML API and get information about them.
weight: 10
type: docs
url: /net/web-scraping/download-youtube-videos/
lastmod: "2022-01-11"
sitemap:
    changefreq: "weekly"
    priority: 0.8

---


<link href="./../../style.css" rel="stylesheet" type="text/css" />

YouTube is a free service and a great place to find what you love. Many people use YouTube to watch music videos, how-to guides, comedy shows,  recipes, funny science lessons, fashion tips, and more. YouTube is popular among over a billion users who record and share their own videos, watch and upload all kinds of video content.

{{% alert color="primary" %}} 
Aspose.HTML offers a Free Online [**YouTube Video Downloader**](https://products.aspose.app/html/video-downloader/youtube) for your favorite videos. Just click on the button and save the favorite video to review it at any time! 
{{% /alert %}}  

<a href="https://products.aspose.app/html/video-downloader/youtube" target="_blank">![Text "Banner YouTube Video Downloader"](download-youtube.png#center)</a>

Aspose.HTML for .NET API provides a powerful toolset to analyze and collect information from HTML documents and gives a possibility to download YouTube video by its URL.  Using API functionalities, you can easily create your own application or just download and watch your favorite video offline without any internet connection.

**Note:** Video downloading becomes illegal when non publicly available data becomes extracted. You should be especially careful about the information you collect and comply with copyright laws. We are not responsible for any copyright infringement that may occur when using the Aspose.HTML library.

## **Get YouTube Video Info**

Getting information about a video file using Aspose.HTML API, the following steps should be done:

1. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
2. Create a multimedia object that collects information from the specified  URL.
3. Create a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object and check whether it is an instance of the [YouTubeVideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping.youtube/youtubevideoinfo) class.
4. Get information about the video and display it in the console.

The following code snippet can be used to get information about a video file such as Title, Description, Duration, Thumbnails, and Formats Count.
{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;
...

	// Initialize an instance of the MultimediaScraper class 
	using var scraper = new MultimediaScraper();
	
	// Create a multimedia object that collects information from a URL
	using var multimedia = scraper.GetMultimedia("https://www.youtube.com/watch?v=Yugq1KyZCI0");        
	
	// Get a VideoInfo object and check whether it is an instance of the YouTubeVideoInfo class 
	var videoInfo = multimedia.CollectVideoInfo();
	
	if (videoInfo is YouTubeVideoInfo)
	{
	    Console.WriteLine("videoInfo is an instance of YouTubeVideoInfo class");
	    
	    // Show YouTube video info
		Console.WriteLine("Title: {0}", videoInfo.Title);
		Console.WriteLine("Description: {0}", videoInfo.Description);
		Console.WriteLine("Duration: {0}", videoInfo.Duration);
		Console.WriteLine("Thumbnails count: {0}", videoInfo.Thumbnails.Count);
		Console.WriteLine("Formats count: {0}", videoInfo.Formats.Count);
	}
{{< /highlight >}}

In the example above, we use the [GetMultimedia(`url`)](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper/methods/getmultimedia) method of MultimediaScraper class for initializing multimedia object that can receive information from the specified page URL. The [CollectVideoInfo()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/collectvideoinfo) method of the Multimedia class collects and provides video information from the associated URL. These can be the VideoInfo class properties such as Description, Duration, Formats, MultimediaHost, Thumbnails, and Title for a video file. 

## **YouTube Video Formats Info**

You may download a YouTube video in different formats: in the best available quality or, for example, in low size when you are on a slow or intermittent connection. Using the [VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo) class, you can select a video format based on some criterion or criteria.

To get video formats information, you should follow a few steps:

1. Initialize an instance of the  [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
2. Create a multimedia object that handles information from the URL.
3. Use the [CollectVideoInfo()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/collectvideoinfo) method and get a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object. 
4. Get video format information from the collection of available formats.

Consider the following code snippet to get information about all the available formats for the selected video:

{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;
using System.Linq;
...

	// URL of the video you want to extract data from
	string url = "https://www.youtube.com/watch?v=Yugq1KyZCI0";    
	
	// Initialize an instance of the MultimediaScraper class
	using var multimediaScraper = new MultimediaScraper();
	
	// Create a multimedia object that handles information from the URL
	using var multimedia = multimediaScraper.GetMultimedia(url);
	
	// Get a VideoInfo object 
	var videoInfo = multimedia.CollectVideoInfo();
	
	Console.WriteLine("Title: {0}", videoInfo.Title);
	   
	// Show video format information from the collection of available formats
	int i = 0;
	foreach (var videoFormatInfo in videoInfo.Formats.OrderByDescending(f => f.Bitrate))
	{	
	    Console.WriteLine("Format #{0}", ++i);
	
	    Console.WriteLine("Bitrate: {0}", videoFormatInfo.Bitrate?.ToString() ?? "[null]");
	
	    Console.WriteLine("Audio Codec: {0}", videoFormatInfo.AudioCodec ?? "[null]");
	    Console.WriteLine("Video Codec: {0}", videoFormatInfo.VideoCodec ?? "[null]");
	
	    Console.WriteLine("Width: {0}", videoFormatInfo.Width?.ToString() ?? "[null]");
	    Console.WriteLine("Height: {0}", videoFormatInfo.Height?.ToString() ?? "[null]");
	
	    Console.WriteLine("Extension: {0}", videoFormatInfo.Extension ?? "[null]");
	    Console.WriteLine("File Size: {0}", videoFormatInfo.FileSize?.ToString() ?? "[null]");
	    Console.WriteLine("FPS: {0}", videoFormatInfo.FPS?.ToString() ?? "[null]");
	    Console.WriteLine("Sampling Rate: {0}", videoFormatInfo.SamplingRate?.ToString() ?? "[null]");
	}            

{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [<a href="https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net" rel='noopener nofollow' target="_blank">**GitHub**</a>](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}  

## **How to Download YouTube Videos**

{{% alert color="primary" %}} 
**Note:** If you want to add a URL of the required video to download, first of all, make sure this uploading is not dedicated to copyright infringement.
{{% /alert %}}

The Aspose.HTML API includes a set of features for downloading video files. With this functionality, you can programmatically download videos through your own front end in your own application. You may download a video in different formats: in the best available quality or, for example, in low size when you are on a slow or intermittent connection. Using the  [VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo) class, you can select a video format based on some criterion or criteria and specify the desired file extension.

To download a video file with Aspose.HTML, you should follow a few steps:
1. Set a URL and file name to download a video.
2. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
3. Create a multimedia object.
4. Create a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object.
5.  Select a format based on some criterion or criteria. For example, select the first element from the collection of video formats with minimal bitrate and present audio and video codecs.
6. Specify a video format and full file path for the output file.
7. Download YouTube video using the [Download()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/download) method.

Here is a C# example of how to download YouTube videos and get information about them:
{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;
using System.Linq;
using System.IO;
...
	// URL of the video you want to extract data from
    string url = "https://www.youtube.com/watch?v=JlKF7z8ODIo";

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
        Console.WriteLine("Title: {0}", youTubeVideoInfo.Title);
        Console.WriteLine("Description: {0}", youTubeVideoInfo.Description);
        Console.WriteLine("Duration: {0}", youTubeVideoInfo.Duration);
        Console.WriteLine("Thumbnails count: {0}", youTubeVideoInfo.Thumbnails.Count);
        Console.WriteLine("Formats count: {0}", youTubeVideoInfo.Formats.Count);        
    } 
{{< /highlight >}}

The [Download(`format`, `filePath`)](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/download) method of the [Multimedia](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia) class takes as parameters the information about the video file to download (it is a local VideoFormatInfo variable `format`) and a local path to the output file `filePath`; then, it downloads the video file to your local file system. 

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [<a href="https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net" rel='noopener nofollow' target="_blank">**GitHub**</a>](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

Aspose.HTML offers free online Apps for data scraping that help you extract data from the web on any device in seconds. [**Data Scrapers**](https://products.aspose.app/html/data-scrapers) are free and do not require any software installation. They are easy and clear to use yet forceful and reliable. Try the Data Scrapers Apps and extract data from any web page now!
{{% /alert %}}   

<a href="https://products.aspose.app/html/data-scraperss" target="_blank">![Text "Banner Data Scrapers"](./../data-scrapers.png#center)</a> 









