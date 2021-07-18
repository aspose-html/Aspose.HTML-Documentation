---
title: Multimedia Scraping 
type: docs
weight: 20
aliases: /net/video-downloading/
---


## **Data Scraping Namespaces**
Data Scraping is a way to get data from websites. Aspose.HTML API provides Aspose.Html.DataScraping.MultimediaScraping and Aspose.Html.DataScraping.MultimediaScraping.YouTube Namespaces that provide various multimedia scraping classes:

|Class|**Description**|
| :- | :- |
|Multimedia|This class provides functionality to collect and download VideoInfo (information about video & audio) from the associated page.|
|MultimediaFactory|This class represents an abstract factory which is used for Multimedia objects creation.|
|MultimediaInfo|Represents multimedia information such as Description, Duration, Formats, MultimediaHost, Thumbnails, Titles.|
| MultimediaScraper |Provides functionality to register and select Multimedia object, which will be able to collect information from the specified page URL.|
|VideoFormatInfo|Represents information about video format: names of the audio and video codec; bitrate value in KBit/s, extension, file size, video track height and width in pixels, etc.|
|VideoFormatInfoCollection|Represents a VideoFormatInfo collection, i.e. information about all available video formats.|
|VideoInfo|Represents video information.|
|YouTubeVideoInfo|Represents YouTube specific video information.|



Using the mentioned classes, you can get information or download video data through the web as it follows:

The Aspose.HTML API includes a set of features for uploading video files. With this functionality, you can programically download videos through your own front end in your own application.
Here are a few of examples how to upload videos using the API and get information about them.



You may download video in a different formats: in the best available quality or, for example, in low size when you are on a slow or intermittent connection. 

Using &&& class you can explicitly specify desired format, select formats based on some criterion or criteria, setup precedence and much more.







For the more complicated scenarios, when you need to find a node based on a specific pattern (e.g., get the list of headers, links, etc.), you can use a specialized [TreeWalker](https://apireference.aspose.com/net/html/aspose.html.dom.document/createtreewalker/methods/2) or [NodeIterator](https://apireference.aspose.com/net/html/aspose.html.dom.document/createnodeiterator/methods/2) object with a custom [Filter](https://apireference.aspose.com/net/html/aspose.html.dom.traversal.filters/nodefilter) implementation.

The next example shows how to implement your own [NodeFilter](https://apireference.aspose.com/net/html/aspose.html.dom.traversal.filters/nodefilter) to skip all elements except images:



Once you implement a filter, you can use HTML navigation as it follows:




## **XPath**
The alternative to the *HTML Navigation* is [XML Path Language](https://www.w3.org/TR/xpath20/). The syntax of the XPath expressions is quite simple and what is more important, it is easy to read and support.

The following example shows how to use XPath queries within Aspose.HTML API::


## **CSS Selector**
Along with *HTML Navigation* and *XPath* you can use [CSS Selector API](http://www.w3.org/TR/selectors-4/) that is also supported by our library. This API is designed to create a search pattern to match elements in a document tree based on [CSS Selectors](https://www.w3.org/TR/selectors-3/#selectors) syntax.


