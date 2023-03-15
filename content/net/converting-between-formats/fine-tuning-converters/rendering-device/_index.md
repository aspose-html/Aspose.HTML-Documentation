---
title: Rendering Device - C#
linktitle: Rendering Device
type: docs
weight: 10
url: /net/fine-tuning-converters/rendering-device/
description: Learn how to use rendering devices - PdfDevice, XpsDevice, DocDevice, and ImageDevice to render HTML to PDF, XPS, DOCX, and Images.
keywords: rendering device, rendering process, output device, rendering html, render HTML, PdfDevice, ImageDevice, XpsDevice, DocDevice
sitemap:
    changefreq: "weekly"
    priority: 0.7
lastmod: 2023-03-18
---

Using the [ConvertHTML](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) methods of the Converter class is the most common way to convert HTML documents into various formats. However, [Aspose.HTML for .NET API](https://products.aspose.com/html/net/) also provides alternative ways to render HTML documents with that can give you more control over the rendering process in your C# application.

{{% alert color="primary" %}}
In this article, we describe how to use rendering devices - [PdfDevice,](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfdevice/) [XpsDevice,](https://reference.aspose.com/html/net/aspose.html.rendering.xps/xpsdevice/) [DocDevice,](https://reference.aspose.com/html/net/aspose.html.rendering.doc/pdfdevice/) and [ImageDevice](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagedevice/) to render HTML to PDF, XPS, DOCX, and Images. In the C# examples, the rendering process is considered with default rendering options. To learn more, please read the [Rendering Options](/html/net/fine-tuning-converters/rendering-options/) article.
{{% /alert %}}

## **What is Rendering Device in Aspose.HTML?**

The rendering device encapsulates a 2D drawing surface, whose API is implemented using the [IDevice](https://reference.aspose.com/html/net/aspose.html.rendering/idevice/) interface. Currently, API provides the following implementations: PdfDevice, XpsDevice, DocDevice, and ImageDevice, which are used to generate PDF, XPS, DOCX, and Image file formats, respectively.

The rendering devices in Aspose.HTML API are [PdfDevice,](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfdevice/) [XpsDevice,](https://reference.aspose.com/html/net/aspose.html.rendering.xps/xpsdevice/) [DocDevice,](https://reference.aspose.com/html/net/aspose.html.rendering.doc/pdfdevice/) and [ImageDevice.](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagedevice/) These are classes with constructors, properties, and methods that represent rendering HTML to PDF, XPS, DOCX, and image documents, respectively. <!--In contrast, the output device refers to the target device or medium where the resulting output will be displayed or saved.--> Every rendering device has its own unique set of options implemented with classes [PdfRenderingOptions,](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfrenderingoptions/) [XpsRenderingOptions,](https://reference.aspose.com/html/net/aspose.html.rendering.xps/xpsrenderingoptions/) [DocRenderingOptions,](https://reference.aspose.com/html/net/aspose.html.rendering.doc/docrenderingoptions/) and [ImageRenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/) respectively.

Our C# library offers a set of namespaces with classes, methods, and properties to render HTML to output formats. Let's consider them in more detail.

## **PdfDevice**

The [Aspose.Html.Rendering.Pdf](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/) namespace provides a specific [PdfDevice](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfdevice/) class as well as a few rendering options classes responsible for rendering to a PDF document. The PdfDevice class implements the [IDevice](https://reference.aspose.com/html/net/aspose.html.rendering/idevice/) interface, which defines the basic functionality for rendering an HTML document.

The next C# example shows how to use [PdfDevice](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfdevice/) to render HTML to PDF. The rendering process is considered with default rendering options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
...
	// Prepare HTML code
    var code = @"<span>Hello World!!</span>";

    // Prepare a path to save a converted file 
    string savePath = Path.Combine(OutputDir, "document.pdf");

    // Initialize an HTML document from the HTML code
    using (var document = new HTMLDocument(code, "."))
    {
        // Create a PDF Device and specify the output file to render
        using (var device = new PdfDevice(savePath))
        {
            // Render HTML to PDF
            document.RenderTo(device);
        }
    }
{{< /highlight >}}

Let's explain C# code snippet above:

1. First, we create an HTML document from a string of code. So, in the `code` variable, we put the `content` that will be converted to PDF.
1. Then, we prepare a path for converted file saving - `savePath`.
1. Using the [HTMLDocument(`content`, `baseUri`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/htmldocument/#constructor_14) constructor, we create an instance of HTMLDocument.
1. We create a rendering device - an instance of the [PdfDevice](https://reference.aspose.com/html/net/aspose.html.rendering.pdf/pdfdevice/) class. For this, we use PdfDevice(`savePath`) constructor.
1. And finally, we call [RenderTo(`device`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/renderto/) method with the specified device.

{{% alert color="primary" %}}
Rendering options give you additional control over the rendering process. To learn more about them, please read the [Rendering options](/html/net/fine-tuning-converters/rendering-options/) article.

If you are interested in how to use rendering options to resize document pages to the size of the content and vice versa, please visit the article [How to Resize Document During Conversion from HTML?](/html/net/resize-document/)
{{% /alert %}}

## **ImageDevice**

The [Aspose.Html.Rendering.Image](https://reference.aspose.com/html/net/aspose.html.rendering.image/) namespace provides a specific [ImageDevice](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagedevice/) class as well as a few rendering options classes responsible for rendering HTML files to raster formats: JPG, PNG, BMP, GIF, and TIFF.

In the С# example, to render HTML to JPG image, we follow several steps:
1. Load a source file from a local file system using [HTMLDocument(`documentPath`)]() constructor.
1. Create an instance of the [ImageRenderingOptions](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/) class with `ImageFormat` specifying. By default, the image format is PNG.
1. Create a rendering device - an instance of the [ImageDevice](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagedevice/) class. Use [ImageDevice(`imageOptions`, `savePath`)](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagedevice/imagedevice/#constructor_3) constructor that takes rendering options and output file path as parameters.
1. Render HTML to JPG image using [RenderTo(`device`)](https://reference.aspose.com/html/net/aspose.html/htmldocument/renderto/) method. This method takes an instance of the ImageDevice class as a parameter.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Image;
...
    // Prepare path to a source HTML file
    string documentPath = Path.Combine(DataDir, "spring.html");

    // Prepare path for converted file saving 
    string savePath = Path.Combine(OutputDir, "spring-output.jpg");

    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);

    // Create an instance of the ImageRenderingOptions class
    var imageOptions = new ImageRenderingOptions(ImageFormat.Jpeg);

    // Create an instance of the ImageDevice 
    using var device = new ImageDevice(imageOptions, savePath);

    // Render HTML to JPG
    document.RenderTo(device);
{{< /highlight >}}

{{% alert color="primary" %}}
If you are interested in how to apply rendering options for HTML to image rendering process, please see the [Rendering Options](/html/net/fine-tuning-converters/rendering-options/) article.
{{% /alert %}} 

## **XpsDevice**

The [Aspose.Html.Rendering.Xps](https://reference.aspose.com/html/net/aspose.html.rendering.xps/) namespace provides a specific [XpsDevice](https://reference.aspose.com/html/net/aspose.html.rendering.xps/xpsdevice/) class for rendering HTML files to an XPS document. In the following C# example, the rendering process is considered with default rendering options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Xps;
...
    // Prepare path to a source HTML file
    string documentPath = Path.Combine(DataDir, "spring.html");

    // Prepare path for converted file saving 
    string savePath = Path.Combine(OutputDir, "spring.xps");

    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);    

    // Create the XPS Device and specify the output file to render
    using var device = new XpsDevice(savePath);

    // Render HTML to XPS
    document.RenderTo(device);
{{< /highlight >}}

## **DocDevice**

The [Aspose.Html.Rendering.Doc](https://reference.aspose.com/html/net/aspose.html.rendering.doc/) namespace provides a specific [DocDevice](https://reference.aspose.com/html/net/aspose.html.rendering.doc/docdevice/) class for rendering HTML files to DOCX format. In the following C# example, the rendering process is considered with default rendering options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Rendering.Doc;
...
    // Prepare path for converted file saving 
    string savePath = Path.Combine(OutputDir, "document.docx");

    // Load a document from 'https://docs.aspose.com/html/net/working-with-documents/creating-a-document/document.html' web page
    using var document = new HTMLDocument("https://docs.aspose.com/html/net/working-with-documents/creating-a-document/document.html");    

    // Create the DOC Device and specify the output file to render
    using var device = new DocDevice(savePath);

    // Render HTML to DOCX
    document.RenderTo(device);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete C# examples and data files from [**GitHub.**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net)

Aspose.HTML offers free online [**Converters**](https://products.aspose.app/html/conversion) that can convert HTML, XHTML, MHTML, EPUB, XML, and Markdown files to a range of popular formats. You can easily convert your HTML-based documents to PDF, XPS, DOCX, JPG, PNG, GIF, TIFF, and others. Just select the file, choose the format to convert, and you’re done. Best of all, it's completely free!
{{% /alert %}} 