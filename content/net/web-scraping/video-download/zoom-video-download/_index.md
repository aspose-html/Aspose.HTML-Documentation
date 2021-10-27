---
title: Download Zoom Videos | C# Examples
linktitle: Download Zoom Videos
keywords: Zoom video, how to download Zoom video, download Zoom video, Zoom video info, video formats,
  extract data, data scraping, C# example
description: In this article, you find the description and a few C# examples of how to download Zoom videos using the Aspose.HTML API and get information about them.
weight: 30
type: docs
url: /net/web-scraping/download-zoom-videos/

---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

Nowadays, communication via the Internet has become more relevant than ever. The Zoom platform helps organizations lead virtual meetings with team members and their clients, solves learning challenges through distance learning, and enables teachers to present lessons and give homework to their students over the Internet. Aspose.HTML for .NET API provides a powerful toolset to analyze and collect information from HTML documents and allows you to download Zoom video by its URL. You can easily create your own application using API functionalities or just download and watch your favorite video offline without any internet connection.

{{% alert color="primary" %}} 
Aspose.HTML offers a Free Online [**Zoom Video Downloader**](https://products.aspose.app/html/en/zoom-video-downloader) for your favorite videos. Just click on the button and save the favorite video to review it at any time! 
{{% /alert %}}  

<a href="https://products.aspose.app/html/en/zoom-video-downloader" target="_blank">![Text "Banner Zoom Video Downloader"](download-zoom.png#center)</a>

**Note:** Video downloading becomes illegal when non publicly available data becomes extracted. You should be especially careful about the information you collect and comply with copyright laws. We do not support downloading copyrighted videos and using other people’s videos for commercial purposes without their express permission. We are not responsible for any copyright infringement that may occur when using the Aspose.HTML library.

## **Get Zoom Video Info**

Getting information about Zoom video file using Aspose.HTML API, the following steps should be done:

1. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
2. Create a multimedia object that collects information from the specified  URL.
3. Create a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object and check whether it is an instance of the [ZoomVideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping.zoom/zoomvideoinfo) class.
4. Get information about the video and display it in the console.

The following code snippet can be used to get information about a video file such as Title, Description, Duration, Thumbnails, and Formats Count.
{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.Zoom;
...

	// Initialize an instance of the MultimediaScraper class 
	using var scraper = new MultimediaScraper();
	
	// Create a multimedia object that collects information from a URL
	using var multimedia = scraper.GetMultimedia("https://zoom.us/recording/play/IMjKs3RC8-QaTcYQSFutPxB6CyrezT9pIqfsVj4nF8UIbyXbsvzMnLgjgP83cDHS");              
	
	// Get a VideoInfo object and check whether it is an instance of ZoomVideoInfo class 
	var videoInfo = multimedia.CollectVideoInfo();
	
	if (videoInfo is ZoomVideoInfo)
	{
	    Console.WriteLine("videoInfo is an instance of the ZoomVideoInfo class");
	
	    // Show Zoom video info
	    Console.WriteLine("Title: {0}", videoInfo.Title);
	    Console.WriteLine("Description: {0}", videoInfo.Description);
	    Console.WriteLine("Duration: {0}", videoInfo.Duration);
	    Console.WriteLine("Thumbnails count: {0}", videoInfo.Thumbnails.Count);
	    Console.WriteLine("Formats count: {0}", videoInfo.Formats.Count);
	}            
{{< /highlight >}}

In the example above, we use the [MultimediaScraper()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper/constructors/main) constructor for creating an instance of the MultimediaScraper class (`scraper`) that can collect information from the specified page URL. The  [GetMultimedia(`url`)](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper/methods/getmultimedia) method initializes multimedia object by the specified URL. The [CollectVideoInfo()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/collectvideoinfo) method of the Multimedia class collects and provides video information from the URL. These can be the  [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) class properties such as Description, Duration, Formats, MultimediaHost, Thumbnails, and Title for a video file. 

You can get information about available video formats and download Zoom videos in different formats. For more information, please see the article [**How to Download a Video**](/html/net/web-scraping/video-download/).

## **How to Download Zoom Videos**

{{% alert color="primary" %}} 
**Note:** If you want to add a URL of the required video to download, first of all, make sure this uploading is not dedicated to copyright infringement.
{{% /alert %}}

The Aspose.HTML API includes a set of features for downloading video files. With this functionality, you can programmatically download videos through your own front end in your own application. You may download a video in different formats: in the best available quality or, for example, in low size when you are on a slow or intermittent connection. Using the  [VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo) class, you can select a video format based on some criterion or criteria and specify the desired file extension.

To download a video file with Aspose.HTML, you should follow a few steps:
1. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
2. Create a multimedia object.
3. Create a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object.
4. Select a format based on some criterion or criteria. 
5. Specify a video format and full file path for the output file.
6. Download Zoom video using the [Download()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/download) method.

Here is a C# example of how to download Zoom videos and get information about them:
{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.Zoom;
using System.Linq;
using System.IO;
...	

    // URL of the video you want to extract data from
    string url = "https://zoom.us/recording/play/IMjKs3RC8-QaTcYQSFutPxB6CyrezT9pIqfsVj4nF8UIbyXbsvzMnLgjgP83cDHS";    
    
    // File name for downloading video
    string filename = "Session1";
    
    // Initialize an instance of the MultimediaScraper class
    using var multimediaScraper = new MultimediaScraper();
    
    // Create a multimedia object that collects information from the URL
    using var multimedia = multimediaScraper.GetMultimedia(url);
    
    // Get a VideoInfo object
    var videoInfo = multimedia.CollectVideoInfo();
    
    // Cast a videoInfo to ZoomVideoInfo type
    var ZoomVideoInfo = videoInfo as ZoomVideoInfo;
    
    if (ZoomVideoInfo != null)
    {
        // Get the first element from the formats collection with minimal bitrate
        var format = ZoomVideoInfo.Formats.OrderBy(f => f.Bitrate).First();
    
        // Get the extension for the output file
        var ext = string.IsNullOrEmpty(format.Extension) ? "mp4" : format.Extension;
    
        // Get the full file path for the output file
        var filePath = Path.Combine(OutputDir, filename + "." + ext);
    
        // Download Zoom video
        multimedia.Download(format, filePath);
    
        // Show Zoom video info
        Console.WriteLine("Title: {0}", ZoomVideoInfo.Title);
        Console.WriteLine("Description: {0}", ZoomVideoInfo.Description);
        Console.WriteLine("Duration: {0}", ZoomVideoInfo.Duration);
        Console.WriteLine("Thumbnails count: {0}", ZoomVideoInfo.Thumbnails.Count);
        Console.WriteLine("Formats count: {0}", ZoomVideoInfo.Formats.Count);               
    } 
{{< /highlight >}}

The [Download(`format`, `filePath`)](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/download) method of the [Multimedia](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia) class takes as parameters the information about the video file to download (it is a local VideoFormatInfo variable `format`) and a local path to the output file `filePath`; then, it downloads the video file to your local file system. 

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

Aspose.HTML offers free online Apps for data scraping that help you extract data from the web on any device in seconds. [**Data Scrapers**](https://products.aspose.app/html/en/scrapers) are free and do not require any software installation. They are easy and clear to use yet forceful and reliable. Try the Data Scrapers Apps and extract data from any web page now! 
{{% /alert %}} 









