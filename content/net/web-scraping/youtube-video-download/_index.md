---
title: Download YouTube Videos | C# Examples
linktitle: Download YouTube Videos
keywords: how to download youtube video, download youtube video, youtube video info, video formats,
  extract data, data scraping
description: In this article, you find the description and a few examples of how
  to download youtube videos using the Aspose.HTML API and get information about them.
weight: 30
type: docs
url: /net/web-scraping/download-youtube-videos/

---

YouTube is a free service and a great place to find what you love. Many people use YouTube to watch music videos, how-to guides, comedy shows,  recipes, funny science lessons, fashion tips, and more. YouTube is popular among over a billion users who record and share their own videos, watch and upload all kinds of video content.

{{% alert color="primary" %}} 
Aspose.HTML offers [**YouTube Video Downloader**](https://products.aspose.app/html/en/youtube-video-downloader) for your favorite videos. Just click on the button and save the favorite video to review it at any time! 
{{% /alert %}}  

<a href="https://products.aspose.app/html/en/youtube-video-downloader" target="_blank">![Text "Banner YouTube Video Downloader"](download-youtube.png#center)</a>

Aspose.HTML for .NET API provides a powerful toolset to analyze and collect information from HTML documents and gives a possibility to download YouTube video by its URL.  Using API functionalities, you can easily create your own application or just download and watch your favorite video offline without any internet connection.

## **Get YouTube Video Info**

Getting information about a video file using Aspose.HTML API, the following steps should be done:
1. Set a URL of the video you want to extract data from.
2. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
3. Create a multimedia object that collects information from the specified  URL.
4. Create a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object.
5. Get information about the video and display it in the console.

The following code snippet can be used to get information about a video file such as Title, Description, Duration, Thumbnails, and Formats Count.




In the example above, we use the [GetMultimedia()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper/methods/getmultimedia) method of MultimediaScraper class for initializing multimedia object that can collect information from the specified page URL. The [CollectVideoInfo()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/collectvideoinfo) method of the Multimedia class collects and provides video information from the associated URL. These can be the VideoInfo class properties such as Description, Duration, Formats, MultimediaHost, Thumbnails, and Title for a video file. 

## **YouTube Video Formats Info**

You may download a YouTube video in different formats: in the best available quality or, for example, in low size when you are on a slow or intermittent connection. Using the [VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo) class, you can select a video format based on some criterion or criteria.

Consider the following code snippet to get information about all the available formats for the selected video:



{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}}  

## **How to Download YouTube Videos**

{{% alert color="primary" %}} 
**Note:** If you want to add a URL of the required video to download, first of all, make sure this uploading is not dedicated to copyright infringement.
{{% /alert %}}

The Aspose.HTML API includes a set of features for downloading video files. With this functionality, you can programmatically download videos through your own front end in your own application. You may download a video in different formats: in the best available quality or, for example, in low size when you are on a slow or intermittent connection. Using the  [VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo) class, you can select a video format based on some criterion or criteria and specify the desired file extension.

To download a video file with Aspose.HTML, you should follow a few steps:
1. Set a URL and file name to download the video.
2. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
3. Create a multimedia object.
4. Create a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object.
5.  Select a format based on some criterion or criteria. For example, select the first element from the collection of video formats with minimal bitrate and present audio and video codecs.
6. Specify a video format and full file path for the output file.
7. Download video using [Download()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/download) method.

Here is an example of how to download videos using the API and get information about them.



The Download() method of the Multimedia class takes as parameters the information about the video file to download (it is a local VideoFormatInfo variable `format`) and a local path to the output file `filePath`; then, it downloads the video file to your local file system. 

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation). 
{{% /alert %}} 

{{% alert color="primary" %}} 
Aspose.HTML offers free online Apps for data scraping that help you extract data from the web on any device in seconds. [**Data Scrapers**](https://products.aspose.app/html/en/scrapers) are free and do not require any software installation. They are easy and clear to use yet forceful and reliable. Try the Data Scrapers Apps and extract data from any web page now!
{{% /alert %}}   









