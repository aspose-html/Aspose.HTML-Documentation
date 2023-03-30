---
title: Download Images From Website - C# Examples
linktitle: Download Images From Website
type: docs
weight: 40
url: /net/download-images/
description: Learn how to download images from link. Consider C# examples to automate downloading images from website using Aspose.HTML.
keywords: download images from website, download images, download icons, download image from url, download images from link, download icon from website, download from website
lastmod: "2023-03-31"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../style.css" rel="stylesheet" type="text/css" />

Suppose you are a web developer, graphic designer, researcher, journalist, or student, in a word, a person working on his own project. In that case, you will obviously need images for your project in the development process. To download images from link manually, you spend a very long time. You will have to copy each image URL and then download the image, but you can use [Aspose.HTML for .NET library](https://products.aspose.com/html/net/) to download images from website programmatically.

{{% alert color="primary" %}}
In this article, we look at how to download from website various types of images by using Aspose.HTML for .NET API. Using our C# library will help you download images from link. It's better than digging and looking for them manually. Let's try! Download images from website programmatically!
{{% /alert %}}

## **Download Images from Website - C# code**

Most pictures in an HTML document are represented using the `<img>` element. Here is an example of how to use Aspose.HTML to download images from website specified by this element. So, to download images from link, you should take a few following steps:

1. Use the [HTMLDocument(`Url`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_4) constructor to create an instance of the `HTMLDocument` class and pass it the URL of the website from which you want to download images.
1. Use the [GetElementsByTagName(`"svg"`)](https://reference.aspose.com/html/net/aspose.html.dom/document/getelementsbytagname/) method to collect all `<img>` elements. The method returns a list of the HTML document's `<img>` elements.
1. Use the `Select()` method to create a distinct collection of relative image URLs and the [GetAttribute(`"src"`)](https://reference.aspose.com/html/net/aspose.html.dom/element/getattribute/) method to extract the `src` attribute of each `<img>` element.
1. Create absolute image URLs using the [Url](https://reference.aspose.com/html/net/aspose.html/url/) class and the [BaseURI](https://reference.aspose.com/html/net/aspose.html.dom/document/baseuri/) property of the `HTMLDocument` class.
1. For each absolute URL, create a request using the [RequestMessage(`url`)](https://reference.aspose.com/html/net/aspose.html.net/requestmessage/requestmessage/#constructor) constructor.
1. Use the document's [Context.Network.Send(`request`)](https://reference.aspose.com/html/net/aspose.html.net/inetwork/send/) method to send the request. The response is checked to ensure it was successful.
1. Finally, if the response was successful, use the `File.WriteAllBytes()` method to save each image to a local file.


{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Net;
using System.IO;
using System.Linq;
...
    // Open a document you want to download images from
    using var document = new HTMLDocument("https://docs.aspose.com/svg/net/drawing-basics/svg-shapes/");

    // Collect all <img> elements
    var images = document.GetElementsByTagName("img");

    // Create a distinct collection of relative image URLs
    var urls = images.Select(element => element.GetAttribute("src")).Distinct();

    // Create absolute image URLs
    var absUrls = urls.Select(src => new Url(src, document.BaseURI));

    foreach (var url in absUrls)
    {
        // Create an image request message
        using var request = new RequestMessage(url);

        // Download image
        using var response = document.Context.Network.Send(request);

        // Check whether a response is successful
        if (response.IsSuccess)
        {
            // Save image to a local file system                    
            File.WriteAllBytes(Path.Combine(OutputDir, url.Pathname.Split('/').Last()), response.Content.ReadAsByteArray());                   
        }
    }
{{< /highlight >}}

{{% alert color="primary" %}}

**Note:** Respecting copyright laws and obtaining proper permission or licensing before using downloaded images for commercial purposes is important. We do not support downloading data and using other people’s files for commercial purposes without their permission.
{{% /alert %}}

## **Download Icons from Website - C# code**

Icons are a kind of image in HTML documents that are specified using `<link>` elements with the `rel` attribute set to `icon`. Let's look at how to download icons from website using the Aspose.HTML for .NET library:

1. Use the [HTMLDocument(`Url`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_4) constructor to create an instance of the `HTMLDocument` class and pass it the URL of the website from which you want to download icons.
1. Use the [GetElementsByTagName(`"link"`)](https://reference.aspose.com/html/net/aspose.html.dom/document/getelementsbytagname/) method to collect all `<link>` elements.
1. To filter out non-icon images, use the `Where()` method that filters the collection based on the `link => link.GetAttribute("rel") == "icon"`  expression. Thus, the `icons` collection will contain only `links` with a `rel` attribute with the value `icon`.
1. Use the `Select()` method to create a distinct collection of relative icon URLs and the [GetAttribute(`"href"`)](https://reference.aspose.com/html/net/aspose.html.dom/element/getattribute/) method to extract the `href` attribute of each `<link>` element.
1. Create absolute icon URLs using the [Url](https://reference.aspose.com/html/net/aspose.html/url/) class and the [BaseURI](https://reference.aspose.com/html/net/aspose.html.dom/document/baseuri/) property of the `HTMLDocument` class.
1. Then, for each absolute URL, create a request using the [RequestMessage](https://reference.aspose.com/html/net/aspose.html.net/requestmessage/) class.
1. Use the document's [Context.Network.Send(`request`)](https://reference.aspose.com/html/net/aspose.html.net/inetwork/send/) method to send the request. The response is checked to ensure it was successful.
1. If the response was successful, use the `File.WriteAllBytes()` method to save icons to a local file. As a result, you will have a collection of icons from website in your local folder.

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Net;
using System.IO;
using System.Linq;
...
    // Open a document you want to download icons from
    using var document = new HTMLDocument("https://docs.aspose.com/html/net/message-handlers/");

    // Collect all <link> elements
    var links = document.GetElementsByTagName("link");

    // Leave only "icon" elements
    var icons = links.Where(link => link.GetAttribute("rel") == "icon");

    // Create a distinct collection of relative icon URLs
    var urls = icons.Select(icon => icon.GetAttribute("href")).Distinct();

    // Create absolute icon URLs
    var absUrls = urls.Select(src => new Url(src, document.BaseURI));

    foreach (var url in absUrls)
    {
        // Create a downloading request
        using var request = new RequestMessage(url);

        // Download icon
        using var response = document.Context.Network.Send(request);

        // Check whether a response is successful
        if (response.IsSuccess)
        {
            // Save icon to a local file system                    
            File.WriteAllBytes(Path.Combine(OutputDir, url.Pathname.Split('/').Last()), response.Content.ReadAsByteArray());

            Assert.True(File.Exists(Path.Combine(OutputDir, url.Pathname.Split('/').Last())));
        }
    }
{{< /highlight >}}

You can use these C# examples to automate downloading all images from website, which can be helpful for tasks such as archiving, researching, analyzing web content, or any other application for personal use. Also, this is great for web designers and developers wanting to pull images from sites without diving into the source code.

{{% alert color="primary" %}}
You can download the complete C# examples and data files from [**GitHub.**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)

Aspose.HTML offers a free online [**Image Downloader**](https://products.aspose.app/html/image-downloader) that is a way to download images from link quickly and easily. Using our web extracting tool, you can get images from any public website in seconds. Our Image Downloader is safe, works on any platform, and does not require any software installation. The application is easy and clear to use yet forceful and reliable. To download images from website, copy  website URL, paste it into the text input field, and click the “Extract” button!
{{% /alert %}}

<a href="https://products.aspose.app/html/image-downloader" target="_blank">![Text "Banner Free Online Image Downloader"](./../../images/image-downloader.png#center)</a>
