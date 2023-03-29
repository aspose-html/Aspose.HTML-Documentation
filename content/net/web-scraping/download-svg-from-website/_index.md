---
title: Download SVG From Website - C# Examples
linktitle: Download SVG From Website
type: docs
weight: 50
url: /net/download-svg-from-website/
description: Learn how to download SVG from website. Consider C# examples to automate downloading inline and external SVG from any website.
keywords: download svg from website, download svg, download svg file, download svg image, inline svg, external svg
lastmod: "2023-03-25"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

SVG is a vector graphics format designed primarily for the web, often used in HTML documents. The main advantage of SVG is its unsurpassed ability to scale to any size without compromising quality. Along with other benefits such as programmability, small file size, styling, interactivity, and more, SVG can improve web pages' visual appeal and functionality. If you are a designer or developer, sometimes you prefer to get SVG images from a website. 

Loading SVG is not as easy as it might seem. If you have ever used a right-click to save or open an image from a web page, you have probably noticed that SVG files are challenging to download from a website. Sometimes right-clicking won't allow you to open it in a new tab or save it. And what to do? Is look at SVG tags and determine where the SVG starts and ends in the web page's HTML code? Fortunately, you can use [Aspose.HTML for .NET library](https://products.aspose.com/html/net/) to download SVG from website programmatically.

{{% alert color="primary" %}}
SVG images in HTML documents come in two forms - **inline SVG** and **external SVG**. In this article, we look at how to download both types of these images using Aspose.HTML for .NET API. Using our C# library will help you download all SVGs from any website. It's better than digging and looking for them manually. Let's try!
{{% /alert %}}

## **Download SVG from Website - Inline SVG**

**Inline SVG** images are SVG elements `<svg>` whose content describes the image. Inline SVG refers to embedding SVG code directly into HTML code rather than linking to an external SVG file. This is a popular technique for creating website icons, logos, and other graphical elements.

To save inline SVG images, we will find all `<svg>` elements in an HTML document and use the [OuterHTML](https://reference.aspose.com/html/net/aspose.html.dom/element/outerhtml/) property to get their content. So, to download SVG from website, you should take a few following steps:

1. Use the [HTMLDocument(`Url`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_4) constructor to create an instance of the `HTMLDocument` class and pass it the URL of the website from which you want to download inline SVG images.
1. Use the [GetElementsByTagName(`"svg"`)](https://reference.aspose.com/html/net/aspose.html.dom/document/getelementsbytagname/) method to collect all `<svg>` elements. The method returns a list of the HTML document's `<svg>` elements.
1. Create a loop to iterate through each SVG image in the `images` array.
1. For each image in the array, use the [OuterHTML](https://reference.aspose.com/html/net/aspose.html.dom/element/outerhtml/) property to get the SVG element content and the `File.WriteAllText()` method, which wrote the SVG content to a local file.

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Net;
using System.IO;
using System.Linq;
...
    // Open a document you want to download inline SVG images from
    using var document = new HTMLDocument("https://docs.aspose.com/svg/net/drawing-basics/svg-shapes/");

    // Collect all inline SVG images
    var images = document.GetElementsByTagName("svg");

    for (var i = 0; i < images.Length; i++)
    {
        // Save every SVG image to a local file system
        File.WriteAllText(Path.Combine(OutputDir, $"{i}.svg"), images[i].OuterHTML);
    }
{{< /highlight >}}

{{% alert color="primary" %}}
**Note:** Some SVG files may be protected by copyright, so check the terms of use before downloading and using them. For example, using the company logo or other downloaded SVG files in your design projects might be considered plagiarism, and you shouldn't do it. It might be a good idea to ask the website owners for permission before you use their files.
{{% /alert %}}

## **Download SVG from Website - External SVG**

**External SVG** is an SVG file stored outside an HTML document and loaded into the document using, for example, a `<img>`  tag. Separating SVG files from HTML makes it possible to reuse the same SVG image in multiple places without duplicating the code, making web pages more efficient and easier to maintain.

External SVG images are represented by the `<img>` element, which in turn can also refer to other types of images, so SVG images should be further filtered. Let's look at how to download SVG from website using the Aspose.HTML for .NET library:

1. Use the [HTMLDocument(`Url`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_4) constructor to create an instance of the `HTMLDocument` class and pass it the URL of the website from which you want to download external SVGs.
1. Use the [GetElementsByTagName(`"img"`)](https://reference.aspose.com/html/net/aspose.html.dom/document/getelementsbytagname/) method to collect all `<img>` elements. The method returns a list of the HTML document's `<img>` elements.
1. Use the `Select()` method to create a distinct collection of relative image URLs and the [GetAttribute(`"src"`)](https://reference.aspose.com/html/net/aspose.html.dom/element/getattribute/) method to extract the `src` attribute of each `<img>` element.
1. To filter out non-SVG images, use the `Where()` and the `EndsWith()` methods to check if the URL ends with the .svg extension.
1. Create absolute SVG image URLs using the [Url](https://reference.aspose.com/html/net/aspose.html/url/) class and the [BaseURI](https://reference.aspose.com/html/net/aspose.html.dom/document/baseuri/) property of the `HTMLDocument` class.
1. Then, for each absolute URL, create a request using the [RequestMessage](https://reference.aspose.com/html/net/aspose.html.net/requestmessage/) class.
1. Use the document's [Context.Network.Send(`request`)](https://reference.aspose.com/html/net/aspose.html.net/inetwork/send/) method to send the request. The response is checked to ensure it was successful.
1. Finally, if the response was successful, use the `File.WriteAllBytes()` method to save SVG to a local file.

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Net;
using System.IO;
using System.Linq;
...
    // Open the document you want to download external SVGs from
    using var document = new HTMLDocument("https://docs.aspose.com/html/net/message-handlers/");

    // Collect all image elements
    var images = document.GetElementsByTagName("img");

    // Create a distinct collection of relative image URLs
    var urls = images.Select(element => element.GetAttribute("src")).Distinct();

    // Filter out non SVG images
    var svgUrls = urls.Where(url => url.EndsWith(".svg"));

    // Create absolute SVG image URLs
    var absUrls = svgUrls.Select(src => new Url(src, document.BaseURI));

    foreach (var url in absUrls)
    {
        // Create a downloading request
        using var request = new RequestMessage(url);

        // Download SVG image
        using var response = document.Context.Network.Send(request);

        // Check whether response is successful
        if (response.IsSuccess)
        {
            // Save SVG image to local file system
            File.WriteAllBytes(Path.Combine(OutputDir, url.Pathname.Split('/').Last()), response.Content.ReadAsByteArray());
        }
    }
{{< /highlight >}}

You can use these C# examples to automate downloading all SVG images from a webpage, which can be helpful for tasks such as archiving or analyzing web content. Also, this is great for designers and developers wanting to pull SVGs from sites without diving into the source code.

{{% alert color="primary" %}}
You can download the complete C# examples and data files from [**GitHub.**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)

Aspose.HTML offers a free online [**Web Page Downloader**](https://products.aspose.app/html/web-downloader) that is a way to save webpages from URLs quickly and easily. Using our web extracting tool, you’re able to get data from the Internet in seconds. Our Web Page Downloader is safe, works on any platform, and does not require any software installation. The application is easy and clear to use yet forceful and reliable. To download web page, copy the URL of the page you want to save, paste it into the text input field, and click the “Download” button!
{{% /alert %}}

<a href="https://products.aspose.app/html/web-downloader" target="_blank">![Text "Banner Free Online Web Page Downloader"](./../../images/web-page-downloader.png#center)</a>
