---
title: Download Website - How to Download Website in C#
linktitle: Download Website
type: docs
weight: 20
url: /net/download-website/
description: Learn how to download website from URL in C# and customize the downloading process - download entire website or download web page.
keywords: download website, download web page, download entire website, download html website, download html file, download website offline, how to download website, download website from url, read website offline, download website c#, download html page c#, downloading process, save website offline
lastmod: "2023-03-25"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

While wired internet or Wi-Fi is available everywhere these days, it happens that you may not have an internet connection from time to time; for example, between subway stops, on a trip, or on a flight. To be able to access information without a network connection, you need to download the contents of different websites in order to use them offline, perhaps for reading, research, or entertainment.

There are a few reasons why you would want to download website:
 - access the information without a network connection;
 - extracting useful information from websites for analysis or other purposes;
 - recording the page's content lest the data becomes unavailable for whatever reason. Maybe you have experience with broken bookmarks;
 - moving static HTML websites to another host;
 - archiving content and creating backups;
 - learning purposes such as design or webpage templates study and more.

This article provides ways to download website from URL using Aspose.HTML for .NET API. You can customize the downloading process - download entire website or download web page.

## **How to Download Website**

You can use [Aspose.HTML for .NET library](https://products.aspose.com/html/net/) to download website from URL for offline reading without any hassles. To download website from URL you should take a few following steps:

1. Use the [HTMLDocument(`Url`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_4) constructor to load an `HTMLdocument` object from a URL.
1. Create an instance of the [HTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/htmlsaveoptions/) class and set the required properties to customize the loading process. If you don't initialize `HTMLSaveOptions`, the loading process will work with the default save options, as shown in the example below.
1. Call the [Save(`savePath)`](https://reference.aspose.com/html/net/aspose.html/htmldocument/save/#save_10) or the [Save(`savePath`, `options`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/save/#save_12) method to save website offline.

The following C# example shows how to download website from URL with default save options. You download only a separate web page with related resources using the default save options. Please note that only resources that are in the same domain as the site page will be saved.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
...
    // Initialize HTML document from URL
    using var document = new HTMLDocument("https://docs.aspose.com/html/net/message-handlers/");           
    
    // Save the HTML document to the specified file
    document.Save(Path.Combine(OutputDir, "root/result.html"));
{{< /highlight >}}

Using the functionality described in this article, you can save both individual pages and entire websites with resources. To customize the downloading process, you can specify the resource handling options for the [HTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/htmlsaveoptions/) object.

## **Resource Handling Options**

Using the [HTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/htmlsaveoptions/) and [ResourceHandlingOptions](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/) classes allows you to customize the downloading process. For example, you can manipulate the depth of pages that will be handled and download entire website or only save only individual web pages.

The table below summarizes the main properties of the [ResourceHandlingOptions](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/) class. They provide options for handling maximum page depth, applying limits, or handling external resources such as images, CSS files, and JavaScript when loading an HTML document using the API.

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [Default ](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/default/) | Gets or sets an enum representing the default resource handling method. Currently, `Save`, `Ignore`, and `Embed` values are supported. The default value is `Save`, meaning the resource will be saved as a file. |
| [JavaScript ](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/javascript/) | Represents the way scripts are handled. Currently, `Save`, `Ignore`, `Discard`, and `Embed` values are supported. The default value is `Save`, meaning the resource will be saved as a file. |
| [MaxHandlingDepth](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/maxhandlingdepth/) | This property contains information about the maximum depth of pages that will be handled. Using this property, you can manipulate the depth of pages that will be handled and download entire website or only save individual web pages. A depth of 1 means only pages directly referenced from the saved document will be handled. Setting this property to -1 will lead to the handling of all pages. The default value is 0. |
| [PageUrlRestriction](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/pageurlrestriction/) | Contains information about restrictions applied to URLs of handled pages. The default value is `RootAndSubFolders`, meaning only resources in the root and subfolders are processed. |
| [ResourceUrlRestriction](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/resourceurlrestriction/) | This property contains information about restrictions applied to URLs of handled resources such as CSS, js, images, etc. The default value is `SameHost`, meaning only resources in the same host are processed. |

## **Download Website using `JavaScript` Property**

Aspose.HTML provides the ability to control the logic for saving scripts. They can be saved in separate files, embedded, or thrown out of the resulting document. The following C# example shows how to download website and embed all the JavaScripts to be saved into resulted HTML document.

To download website from URL you should take a few following steps:
1. Use the [HTMLDocument(`Url`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_4) constructor to load an HTMLdocument object from a URL.
1. Create an instance of the [HTMLSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/htmlsaveoptions/) class and set the [JavaScripts](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/javascript/) property with `ResourceHandling.Embed` value.
1. Call the [Save(`savePath`, `options`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/save/#save_12) method to save website offline.

In the following example, the `ResourceHandling.Embed` option specifies that any `JavaScript` resources should be embedded in the HTML document when saved. This means the resulting HTML file will contain all of the `JavaScript` resources within the document rather than referencing them as external files.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Saving;
...
    // Initialize HTML document from URL
    using var document = new HTMLDocument("https://docs.aspose.com/html/net/message-handlers/");

    // Create an HTMLSaveOptions object and set JavaScript property
    var options = new HTMLSaveOptions
    {
        ResourceHandlingOptions =
        {
            JavaScript = ResourceHandling.Embed
        }
    };

    // Prepare a path to save the downloaded file
    string savePath = Path.Combine(OutputDir, "rootAndEmbedJs/result.html");

    // Save website offline
    document.Save(savePath, options);
{{< /highlight >}}

## **Download Website using `MaxHandlingDepth` Property**

The [MaxHandlingDepth](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/maxhandlingdepth/) property specifies the maximum depth of the HTML document element hierarchy to be loaded and processed. The API will not load or process any elements beyond this depth. Therefore, the `MaxHandlingDepth` optimizes the performance of the downloading process, helping to reduce the memory and processing power required by the API by limiting the number of elements to be processed.

Only the open document and its resources are saved by default as an individual web page, but you can control the handling depth with the `MaxHandlingDepth` property. The following example shows how to save not only the document but also all the pages to which it links and whose URL is nested relative to the URL of this page. Let's look at the C# example when this property is set to 1, which means that only elements up to a depth of 1 in the HTML document hierarchy will be downloaded:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Saving;
...
    // Load an HTML document from URL
    using var document = new HTMLDocument("https://docs.aspose.com/html/net/message-handlers/");

    // Create an HTMLSaveOptions object and set MaxHandlingDepth property
    var options = new HTMLSaveOptions
    {
        ResourceHandlingOptions =
        {
            MaxHandlingDepth = 1
        }
    };

    // Prepare a path for downloaded file saving 
    string savePath = Path.Combine(OutputDir, "rootAndAdjacent/result.html");

    // Save the HTML document to the specified file
    document.Save(savePath, options);
{{< /highlight >}}

## **Download Website using `PageUrlRestriction` Property**

Aspose.HTML for .NET provides various options for filtering the URLs of saved pages for a website. The [PageUrlRestriction](https://reference.aspose.com/html/net/aspose.html.saving/resourcehandlingoptions/pageurlrestriction/) property restricts loading web pages from specific URLs or domains when saving an HTML document. This property helps improve the saved page’s security by preventing potentially malicious web pages from downloading.

By default, the `PageUrlRestriction` property is set to `RootAndSubFolders`, meaning only pages in the root and subfolders are processed. However, you can set this property to another value - `SameHost` or `None`. Setting it to `None` will allow you to load web pages from any domain whose URLs are on the saved website. Using this property cautiously is essential, as allowing web pages to be loaded from any domain can increase the risk of security vulnerabilities.

In the following example, all pages to which an HTML document refers and those in the same domain will be saved in addition to the document:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Saving;
...
    // Initialize HTML document from URL
    using var document = new HTMLDocument("https://docs.aspose.com/html/net/message-handlers/");

    // Create an HTMLSaveOptions object and set MaxHandlingDepth and PageUrlRestriction properties
    var options = new HTMLSaveOptions
    {
        ResourceHandlingOptions =
        {
            MaxHandlingDepth = 1,
            PageUrlRestriction = UrlRestriction.SameHost
        }
    };

    // Prepare a path to save the downloaded file
    string savePath = Path.Combine(OutputDir, "rootAndManyAdjacent/result.html");

    // Save website offline
    document.Save(savePath, options);
{{< /highlight >}}


{{% alert color="primary" %}}
You can download the complete C# examples and data files from [**GitHub.**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)

Aspose.HTML offers a free online [**Web Page Downloader**](https://products.aspose.app/html/web-downloader) that is a way to save webpages from URLs quickly and easily. Using our web extracting tool, you’re able to get data from the Internet in seconds. Our Web Page Downloader is safe, works on any platform, and does not require any software installation. The application is easy and clear to use yet forceful and reliable. To download web page, copy the URL of the page you want to save, paste it into the text input field, and click the “Download” button!
{{% /alert %}}

<a href="https://products.aspose.app/html/web-downloader" target="_blank">![Text "Banner Free Online Web Page Downloader"](./../../../images/web-page-downloader.png#center)</a>
