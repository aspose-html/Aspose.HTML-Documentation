---
title: Download YouKu Videos | C# Examples
linktitle: Download YouKu Videos
keywords: YouKu video, how to download YouKu video, download YouKu video, YouKu video info, video formats,
  extract data, data scraping, C# example
description: In this article, you find the description and a few C# examples of how to download YouKu videos using the Aspose.HTML API and get information about them.
weight: 20
type: docs
url: /net/web-scraping/download-youku-videos/

---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

Youku is a Chinese Internet video giant that allows people to search, upload, view and share high-quality videos. As the fastest growing video sharing website in China, Youku has more than 500 million active users and offers over 100 million videos for daily viewing.  Youku is called China's YouTube. It attracts people worldwide and covers news, TV series, music videos, movies, animations, documentaries, sports, and others, inside and outside of China.  You can easily create your own application using Aspose.HTML API functionalities or just download and watch your favorite video offline without any internet connection.

{{% alert color="primary" %}} 
Aspose.HTML offers a Free Online [**YouKu Video Downloader**](https://products.aspose.app/html/en/youku-video-downloader) for your favorite videos. Just click on the button and save the favorite video to review it at any time! 
{{% /alert %}}  

<a href="https://products.aspose.app/html/en/youku-video-downloader" target="_blank">![Text "Banner YouKu Video Downloader"](download-youku.png#center)</a>

**Note:** Video downloading becomes illegal when non publicly available data becomes extracted. You should be especially careful about the information you collect and comply with copyright laws. We do not support downloading copyrighted videos and using other people’s videos for commercial purposes without their express permission. We are not responsible for any copyright infringement that may occur when using the Aspose.HTML library.

## **Get YouKu Video Info**

Aspose.HTML for .NET API provides a powerful toolset to analyze and collect information from HTML documents and allows you to get info and download YouKu video by its URL. To obtain information about a video file, follow these steps:

1. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
2. Create a multimedia object that collects information from the specified  URL.
3. Create a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object and check whether it is an instance of the [YouKuVideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping.youku/youkuvideoinfo) class.
4. Get information about the video and display it in the console.

The following code snippet can be used to get information about a video file such as Title, Description, Duration, Thumbnails, and Formats Count.
{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouKu;
...

	// URL of the video you want to extract data from
	string url = "https://v.youku.com/v_show/id_XMzgyODk3MDk0NA==.html?spm=a2h0c.8166622.PhoneSokuUgc_5.dscreenshot";
	
	// Initialize an instance of the MultimediaScraper class 
	using var multimediaScraper = new MultimediaScraper();
	
	// Create a multimedia object that collects information from the URL 
	using var multimedia = multimediaScraper.GetMultimedia(url);
	
	// Get a VideoInfo object
	var info = multimedia.CollectVideoInfo();
	
	if (info.MultimediaHost == MultimediaHost.YouKu)
	{
	    var youKuVideoInfo = (YouKuVideoInfo)info;
	
	    // Show YouKu video info
	    Console.WriteLine("Title: {0}", youKuVideoInfo.Title);
	    Console.WriteLine("Description: {0}", youKuVideoInfo.Description);
	    Console.WriteLine("Duration: {0}", youKuVideoInfo.Duration);
	    Console.WriteLine("Thumbnails count: {0}", youKuVideoInfo.Thumbnails.Count);
	    Console.WriteLine("Formats count: {0}", youKuVideoInfo.Formats.Count);        
	}    
{{< /highlight >}}

In the example above, we use the [GetMultimedia(`url`)](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper/methods/getmultimedia) method of MultimediaScraper class for initializing multimedia object that can receive information from the specified page URL. The [CollectVideoInfo()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/collectvideoinfo) method of the Multimedia class collects and provides video information from the associated URL. These can be the  [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) class properties such as Description, Duration, Formats, MultimediaHost, Thumbnails, and Title for a video file. 

You can get information about available video formats and download YouKu videos in different formats. For more information, please see the article [**How to Download a Video**](/html/net/web-scraping/video-download/).

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net). 
{{% /alert %}}  

## **How to Download YouKu Videos**

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
6. Download YouKu video using the [Download()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/download) method.

Here is a C# example of how to download YouKu videos and get information about them:
{{< highlight java >}}
using Aspose.Html.DataScraping.MultimediaScraping;
using Aspose.Html.DataScraping.MultimediaScraping.YouKu;
using System.Linq;
using System.IO;
...	

    // URL of the video you want to extract data from
    string url = "https://v.youku.com/v_show/id_XMzgyODk3MDk0NA==.html?spm=a2h0c.8166622.PhoneSokuUgc_5.dscreenshot";
    
    // Expected video properties, for example, "Title" and "Duration" 
    string expectedTitle = "News 24";
    int expectedDuration = 59;
    
    // File name for downloading video
    string filename = "News-24";
    
    // Initialize an instance of the MultimediaScraper class
    using var multimediaScraper = new MultimediaScraper();
    
    // Create a multimedia object that collects information from the URL
    using var multimedia = multimediaScraper.GetMultimedia(url);
    
    // Get a VideoInfo object
    var videoInfo = multimedia.CollectVideoInfo();
    
    // Cast a videoInfo to YouKuVideoInfo type
    var youKuVideoInfo = videoInfo as YouKuVideoInfo;
    
    if (youKuVideoInfo != null)
    {
        // Get the first element from the formats collection with minimal bitrate
        var format = youKuVideoInfo.Formats.OrderBy(f => f.Bitrate).First();
    
        // Get the extension for the output file
        var ext = string.IsNullOrEmpty(format.Extension) ? "mp4" : format.Extension;
    
        // Get the full file path for the output file
        var filePath = Path.Combine(OutputDir, filename + "." + ext);
    
        // Download YouKu video
        multimedia.Download(format, filePath);
    
        // Show YouKu video info
        Console.WriteLine("Title: {0}", youKuVideoInfo.Title);
        Console.WriteLine("Description: {0}", youKuVideoInfo.Description);
        Console.WriteLine("Duration: {0}", youKuVideoInfo.Duration);
        Console.WriteLine("Thumbnails count: {0}", youKuVideoInfo.Thumbnails.Count);
        Console.WriteLine("Formats count: {0}", youKuVideoInfo.Formats.Count);               
    } 
{{< /highlight >}}

The [Download(`format`, `filePath`)](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/download) method of the Multimedia class takes as parameters the information about the video file to download (it is a local VideoFormatInfo variable `format`) and a local path to the output file `filePath`; then, it downloads the video file to your local file system. 

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net). 
{{% /alert %}} 









