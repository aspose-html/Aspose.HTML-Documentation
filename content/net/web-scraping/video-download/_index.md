---
title: How to Download a Video | C#
linktitle: How to Download a Video
keywords: how to download video, download video, download youtube video, download youku video, download zoom video, video info, video formats, extract data, data scraping, C# example
description: In this article, you find the description and a few C# examples of how to download videos using the Aspose.HTML API and get information about them.
weight: 20
type: docs
aliases: /net/how-to-download-video/
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

Aspose.HTML for .NET API provides a powerful toolset to analyze and collect information from HTML documents and gives a possibility to download video by its URL. You can easily create your own application using API functionalities or just download and watch your favorite video offline without any internet connection.

{{% alert color="primary" %}} 
You can download video to your device from popular video hubs in any format with our Free Online [**Video Grabber**](https://products.aspose.app/html/en/video-grabber) App. 
{{% /alert %}}  

<a href="https://products.aspose.app/html/en/video-grabber" target="_blank">![Text "Banner Video Grabber"](video-grabber.png#center)</a>

## **Data Scraping Namespaces**
Data Scraping is a way to get data from websites. Aspose.HTML API provides [DataScraping.MultimediaScraping Namespace](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping) that implements various multimedia scraping classes:

|**Class** |**Description**|
| :- | :- |
|[Multimedia](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia)|This class provides functionality to collect and download [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) (information about video & audio) from the associated page.|
|[MultimediaFactory](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediafactory)|This class represents an abstract factory which is used for Multimedia objects creation.|
|[MultimediaInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo)|Represents multimedia information such as [Description](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/description), [Duration](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/duration), [MultimediaHost](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/multimediahost), [Thumbnails](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/thumbnails), [Titles](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/title).|
| [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) |Provides functionality to register and select Multimedia object, which will be able to collect information from the specified page URL.|
| [MultimediaHost](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediahost) |Represents host of the multimedia object.|
|[VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo)|Represents information about a video format: names of the audio and video codec; bitrate value in KBit/s, extension, file size, video track height and width in pixels, etc.|
|[VideoFormatInfoCollection](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfocollection)|Represents a [VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo) collection, i.e. information about all available video formats.|
|[VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo)|Represents video information such as [Description](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/description), [Duration](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/duration), [Formats](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo/properties/formats), [MultimediaHost](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/multimediahost), [Thumbnails](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/thumbnails), [Titles](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediainfo/properties/title).|

Using the mentioned classes, you can get information or download video data through the web. 

The Aspose.Html provides Namespaces responsible for [YouTube](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping.youtube), [YouKu](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping.youku) and [Zoom](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping.zoom) multimedia data scraping. You find the description and C# examples of getting video info and downloading videos from YouTube, YouKu and Zoom in the following articles: 

 - [Download YouTube Videos](/html/net/web-scraping/download-youtube-videos/) - You learn how to get specific video information and download YouTube videos.
 - [Download Zoom Videos](/html/net/web-scraping/download-zoom-videos/) - This article provides a general description of how to get specific video information and download Zoom videos.
 - [Download YouKu Videos](/html/net/web-scraping/download-youku-videos/) - You will find C # examples for getting specific video information and downloading YouKu videos.

{{% alert color="primary" %}} 
For a complete list of classes and methods represented in the DataScraping Namespaces, please visit [DataScraping Namespaces](https://apireference.aspose.com/html/net/aspose.html.datascraping/index).
{{% /alert %}}  

## **Video Info**

Getting information about a video file using Aspose.HTML API, the following steps should be done:
1. Set a URL of the video you want to extract data from.
2. Initialize an instance of the [MultimediaScraper](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper) class.
3. Create a multimedia object that collects information from the specified  URL.
4. Create a [VideoInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoinfo) object.
5. Get information about the video and display it in the console.

The following code snippet can be used to get information about a video file such as Title, Description, Duration, Thumbnails, and Formats Count.


{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-WebScraping-MultimediaScraping-GetVideoInfoTest1.cs" >}}

In the example above, we use the [GetMultimedia(`url`)](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimediascraper/methods/getmultimedia) method of MultimediaScraper class for initializing multimedia object that can receive information from the specified page URL. The [CollectVideoInfo()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/collectvideoinfo) method of the Multimedia class collects and provides video information from the associated URL. These can be the VideoInfo class properties such as Description, Duration, Formats, MultimediaHost, Thumbnails, and Title for a video file. 

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net). 
{{% /alert %}} 

## **Video Formats Info**

You may download a video in different formats: in the best available quality or, for example, in low size when you are on a slow or intermittent connection. Using the  [VideoFormatInfo](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/videoformatinfo) class, you can select a video format based on some criterion or criteria.

Consider the following code snippet to get information about all the available formats for the selected video:

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-WebScraping-MultimediaScraping-GetVideoFormatInfo.cs" >}}

## **Download a Video**

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
7. Download video using the [Download()](https://apireference.aspose.com/html/net/aspose.html.datascraping.multimediascraping/multimedia/methods/download) method.

Here is a C# example of how to download videos using the API and get information about them.

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-WebScraping-MultimediaScraping-DownloadVideo.cs" >}}

The Download() method of the Multimedia class takes as parameters the information about the video file to download (it is a local VideoFormatInfo variable `format`) and a local path to the output file `filePath`; then, it downloads the video file to your local file system. 



{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net). 

Aspose.HTML offers free online Apps for data scraping that help you extract data from the web on any device in seconds. [**Data Scrapers**](https://products.aspose.app/html/en/scrapers) are free and do not require any software installation. They are easy and clear to use yet forceful and reliable. Try the Data Scrapers Apps and extract data from any web page now!
{{% /alert %}}   

<a href="https://products.aspose.app/html/en/scrapers" target="_blank">![Text "Banner Data Scrapers"](./../data-scrapers.png#center)</a> 









