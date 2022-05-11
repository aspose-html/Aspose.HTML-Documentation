---
title: Download YouTube Audio | C# Examples
linktitle: Download YouTube Aidio
keywords: youtube audio, how to download youtube audio, download youtube audio, how to download audio from youtube
  extract data, data scraping, C# example
description: In this article, you find the description and a few C# examples of how to download youtube audio using the Aspose.HTML API.
weight: 30
type: docs
lastmod: "2022-04-13"
sitemap:
    changefreq: "weekly"
    priority: 0.8

---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

YouTube is the second largest search engine after Google. People upload over 100 hours of audio & video per minute to YouTube.  YouTube is a free service and a great place to find what you love. Many people use YouTube to watch music videos, how-to guides, comedy shows,  recipes, funny science lessons, fashion tips, and more. But sometimes you only need audio instead of video. That's when you need to learn how to download audio from YouTube.

{{% alert color="primary" %}} 
Aspose.HTML offers a Free Online [**YouTube Video Downloader**](https://products.aspose.app/html/video-downloader/youtube) for your favorite videos. Just click on the button and save the favorite video to review it at any time! 
{{% /alert %}} 

Aspose.HTML for .NET API provides a powerful toolset to analyze and collect information from HTML documents and gives a possibility to download YouTube audio & video by its URL. Using API functions, you can easily download, save and listen to the audio offline without any Internet connection.

**Note:** Audio downloading becomes illegal when non publicly available data becomes extracted. You should be especially careful about the information you collect and comply with copyright laws. We are not responsible for any copyright infringement that may occur when using the Aspose.HTML library.

## **Get YouTube Audio Info**

You can get information about Title, Description, Duration, Thumbnails, and  Formats of the audio. And then, you may download the audio in the format you need. Getting information about audio using Aspose.HTML API, the following steps should be done:

1. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
2. Create a multimedia object that collects information from the specified  URL.
3. Use the [CollectVideoInfo()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/collectvideoinfo) method and get a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object. 
4. Verify if VideoInfo is an instance of the [YouTubeVideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping.youtube/youtubevideoinfo) class.
5. Get information about the audio title, duration, etc., and display it in the console.
6. Get audio format information (bitrate, audio codec) from the collection of available formats.

The following code snippet can be used to get information about audio such as Title, Description, Duration, and Formats.
{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;
using System.Linq;
...

	// URL of the video you want to extract audio from
	string url = "https://www.youtube.com/watch?v=Yugq1KyZCI0";
	
	// Initialize an instance of the MultimediaScraper class
	using var multimediaScraper = new MultimediaScraper();
	
	// Create a multimedia object that includes information from the URL
	using var multimedia = multimediaScraper.GetMultimedia(url);
	
	// Get a VideoInfo object and check whether it is an instance of the YouTubeVideoInfo class 
	var videoInfo = multimedia.CollectVideoInfo();    
	
	if (videoInfo is YouTubeVideoInfo)
	{
	    Console.WriteLine("videoInfo is an instance of YouTubeVideoInfo class");
	    
	    // Show YouTube audio info
		Console.WriteLine("Title: {0}", videoInfo.Title);
		Console.WriteLine("Description: {0}", videoInfo.Description);
		Console.WriteLine("Duration: {0}", videoInfo.Duration);	
		Console.WriteLine("Formats count: {0}", videoInfo.Formats.Count);
	}
	
	// Show audio format information from the collection of available formats
	int i = 0;
	foreach (var videoFormatInfo in videoInfo.Formats.OrderByDescending(f => f.Bitrate))
	{	
	    Console.WriteLine("Format #{0}", ++i);	
	    Console.WriteLine("Bitrate: {0}", videoFormatInfo.Bitrate?.ToString() ?? "[null]");	
	    Console.WriteLine("Audio Codec: {0}", videoFormatInfo.AudioCodec ?? "[null]");	    
	}
{{< /highlight >}}

In the example above, we use the [GetMultimedia(`url`)](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper/methods/getmultimedia) method of MultimediaScraper class for initializing multimedia object that can receive information from the specified page URL. The [CollectVideoInfo()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/collectvideoinfo) method of the Multimedia class collects and provides audio information from the associated URL. These can be the [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) class properties such as Title, Description, Duration, and  Formats for the audio. 

## **How to Download YouTube Audio**

{{% alert color="primary" %}} 

The way to download audio from YouTube is following: 
1. using [YouTube](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping.youtube) multimedia data scraping Namespace to download YouTube media;

2. extracting only audio codecs from video formats.

{{% /alert %}}

The Aspose.HTML API includes a set of features for downloading video and audio. With this functionality, you can programmatically download media through your own front end in your own application. Using the  [YouTubeVideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping.youtube/youtubevideoinfo) class, you can select only audio format  and specify the desired file extension, for example .mp3.

To download an audio file with Aspose.HTML, you should follow a few steps:
1. Set a URL of the video whose audio you want to download.
2. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
3. Create a multimedia object.
4. Create a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object. Verify if VideoInfo is an instance of the [YouTubeVideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping.youtube/youtubevideoinfo) class.
5.  Select the audio download format based on some criteria, one of them - set **VideoCodec to null**.
6. Specify a full file path for the output file.
7. Download YouTube audio using the [Download()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/download) method.

Here is a C# example of how to download YouTube audio:

{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouTube;
using System.Linq;
using System.IO;
...
	

	// URL of the video whose audio you want to download
	string url = "https://www.youtube.com/watch?v=JlKF7z8ODIo";
	
	// Set a file name for downloading audio
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
{{< /highlight >}}

The [Download(`format`, `filePath`)](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/download) method of the [Multimedia](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia) class takes as parameters the information about the audio to download (it is a local VideoFormatInfo variable `format`) and a local path to the output file `filePath`; then, it downloads the audio file to your local file system. 

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [<a href="https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net" rel='noopener nofollow' target="_blank">**GitHub**</a>](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net). 

**Note:** If you want to add a URL of the required audio to download, first of all, make sure this uploading is not dedicated to copyright infringement.

Aspose.HTML offers free online Apps for data scraping that help you extract data from the web on any device in seconds. [**Data Scrapers**](https://products.aspose.app/html/data-scrapers) are free and do not require any software installation. They are easy and clear to use yet forceful and reliable. Try the Data Scrapers Apps and extract data from any web page now!
{{% /alert %}}   

<a href="https://products.aspose.app/html/data-scraperss" target="_blank">![Text "Banner Data Scrapers"](./../data-scrapers.png#center)</a> 









