---
keywords: html to jpg, convert html to jpg, html to jpg conversion, html to jpg
  converter, save options
lastmod: 2022-01-11
url: /net/converting-between-formats/html-to-jpg/
title: Convert HTML to JPG | C#
linktitle: Convert HTML to JPG
description: This article provides information on how to convert HTML to JPG
  using the Aspose.HTML API. You will learn about the supported HTML to JPG
  conversion scenarios and consider examples to illustrate them.
weight: 20
type: docs
aliases:
  - /net/converting-between-formats/html-to-image-conversion/
  - /net/html-to-image-conversion/
  - /display/htmlnet/HTML+to+Image+Conversion
  - /htmlnet/HTML+to+Image+Conversion
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

JPG files can contain high-quality image data with lossless compression. This unique compression feature allows to quickly and efficiently share JPG images and use them widely on the Web, computers, and mobile devices. Converting HTML files to the JPG image may be required, for example, if you want to add a web page in a PowerPoint presentation or send it by e-mail. Using [Converter.ConvertHTML](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/converthtml/index) methods is the most common way to convert HTML code into various formats. JPG is a commonly used format for storing images, and HTML to JPG conversion is very popular. With Aspose.HTML, you can convert HTML to JPG format programmatically with full control over a wide range of conversion parameters. 

In this article, you find information on converting HTML to {{%JPG%}} by using [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/index) methods of the Converter class and applying  [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/conversion/html-to-jpg" target="_blank">**HTML to JPG Converter**</a> that converts HTML to JPG image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/html-to-jpg" target="_blank">![Text "Banner HTML to JPG Converter"](html-to-jpg.png#center)</a>

## **HTML to JPG by a single line of code**

The static methods of the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class are primarily used as the easiest way to convert HTML code into various formats. You can convert HTML to JPG in your C# application literally with a single line of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Invoke the ConvertHTML method to convert the HTML code to JPG image           
    Converter.ConvertHTML(@"<h1>Convert HTML to JPG!</h1>", ".", new ImageSaveOptions(ImageFormat.Jpeg), Path.Combine(OutputDir, "convert-with-single-line.jpg"));
{{< /highlight >}}

## **Convert HTML to JPG**
Converting a file to another format using the ConvertHTML() method is a sequence of operations among which document loading and saving:

1. Load an HTML file using the [HTMLDocument](https://apireference.aspose.com/html/net/aspose.html/htmldocument) class ([spring.html](/html/net/converting-between-formats/html-to-pdf/spring.html)).
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with JPG ImageFormat. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/3) method of the Converter class to save HTML as a JPG image. You need to pass the HTMLDocument, ImageSaveOptions, and output file path to the ConvertHTML() method to convert HTML to JPG.

Please take a look over the following C# code snippet which shows the process of converting HTML to JPG using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "spring.html");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "spring-output.jpg");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Jpeg);
    
    // Convert HTML to JPG
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

The figure illustrates the spring-output.jpg file.

![Text "spring-output.jpg image"](../spring-output.png#center)

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

### **Free App**
You can convert HTML to JPG with Aspose.HTML for .NET API in real time. First, load an HTML file from your local drive and then run the example. You will immediately get the result as a separate JPG file.

{{< html-converter HTML JPG PNG BMP GIF TIFF >}}
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Rendering.Image;

    using var document = new HTMLDocument("input.html");    
    var options = new ImageSaveOptions(ImageFormat.Jpeg);   
    Converter.ConvertHTML(document, options, "output.jpeg");   
{{< /html-converter >}}

## **Save Options**
Aspose.HTML allows converting HTML to JPG using default or custom save options. [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) usage enables you to customize the rendering process. You can specify the [image format](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat), [page size](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/html/net/aspose.html.drawing/page/properties/margin), [CSS media-type](https://apireference.aspose.com/html/net/aspose.html.rendering/mediatype), etc. 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [Compression](https://apireference.aspose.com/html/net/aspose.html.rendering.image/compression) | Sets Tagged Image File Format (TIFF) [Compression](https://apireference.aspose.com/html/net/aspose.html.rendering.image/compression). By default, this property is [LZW](https://apireference.aspose.com/html/net/aspose.html.rendering.image/compression). |
| [CSS](https://apireference.aspose.com/html/net/aspose.html.rendering/mediatype) | Gets a [CssOptions](https://apireference.aspose.com/html/net/aspose.html.rendering/cssoptions) object which is used for configuration of CSS properties processing. |
| [Format](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat) | Sets the [ImageFormat](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat) (JPG, PNG, BMP, TIFF, or GIF). By default, this property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat). |
| [BackgroundColor](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/backgroundcolor) | This property sets the color that will fill the background. By default, this property is Transparent. |
| [PageSetup](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup) | This property gets a page setup object and uses it for configuration output page-set. |
| [HorizontalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/horizontalresolution) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/verticalresolution) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |
| [SmoothingMode](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/smoothingmode) | This property sets the rendering quality for this image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. |
| [Text](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/text) | Gets a [TextOptions](https://apireference.aspose.com/html/net/aspose.html.rendering.image/textoptions) object which is used for configuration of text rendering. |

The following example shows how to use ImageSaveOptions and create the output image with custom save options such as a page size and background color:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System.Drawing;
using Aspose.Html.Drawing;
...
    string documentPath = Path.Combine(OutputDir, "save-options.html");
    string savePath = Path.Combine(OutputDir, "save-options-output.jpg");

    // Prepare HTML code and save it to a file
    var code = "<h1>  Image SaveOptions </h1>\r\n" +
               "<p>Using ImageSaveOptions Class, you can programmatically apply a wide range of conversion parameters such as BackgroundColor, Format, Compression, PageSetup, etc.</p>\r\n";
    
    File.WriteAllText(documentPath, code);
    
    // Initialize an HTML Document from the html file
    using var document = new HTMLDocument(documentPath);
    
    // Set up the page-size 400x250 pixels, margins and change the background color to AntiqueWhite
    var options = new ImageSaveOptions(ImageFormat.Jpeg)
    {
        BackgroundColor = Color.AntiqueWhite                    
    };
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(400, 250), new Margin(40, 40, 20, 20));                                     
    
    // Convert HTML to JPG
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 

To learn more about the [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) class, please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.
{{% /alert %}}

## **Convert HTML to JPG using ImageSaveOptions**

To convert HTML to JPG with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the HTMLDocument class ([color.html](/html/net/converting-between-formats/html-to-jpg/color.html)). 
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with JPG ImageFormat and specify save options. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/3) method of the  Converter class to save HTML as a JPG image. You need to pass the HTMLDocument, ImageSaveOptions, and output file path to the ConvertHTML() method to convert HTML to JPG.

The following C# code snippet shows how to convert HTML to JPG using custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System.Drawing;
using Aspose.Html.Drawing;
using System.Drawing.Drawing2D;
...
    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "color.html");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "color-output-options.jpg");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Jpeg)
    {
        SmoothingMode = SmoothingMode.HighQuality,
        HorizontalResolution = 200,
        VerticalResolution = 200,
        BackgroundColor = Color.AliceBlue
    };
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(500, 500), new Margin(30, 20, 10, 10));
    
    // Convert HTML to JPG
    Converter.ConvertHTML(document, options, savePath)
{{< /highlight >}}

The [ImageSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initializes an instance of the ImageSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the above example, we use:
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - SmoothingMode property that sets the rendering quality for this image;
 - PageSetup property that specifies the [page size](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup) and [margins](https://apireference.aspose.com/html/net/aspose.html.drawing/page/properties/margin) in pixels. 

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to Image formats. Among these properties, SmoothingMode that enables you to set the rendering quality for the image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. You can select any value, considering the advantages and disadvantages of each one.

The figure illustrates the color-output-options.jpg file.

![Text ""Color" JPG image"](color-output-options.jpg#center)

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement the [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) interface to have manual control over the file creating process. This interface is designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering the document/page.

{{% alert color="primary" %}} 

Aspose.HTML for .NET provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance, {{%PDF%}}, {{%XPS%}}), others create multiple files (Image formats - {{%JPG%}}, {{%PNG%}}, etc.).

{{% /alert %}} 

The example below shows how to implement and use  your own *MemoryStreamProvider* in the application:
{{< highlight java >}}
using System.IO;
using System.Collections.Generic;
...
    class MemoryStreamProvider : Aspose.Html.IO.ICreateStreamProvider
    {
        // List of MemoryStream objects created during the document rendering
        public List<MemoryStream> Streams { get; } = new List<MemoryStream>();

        public Stream GetStream(string name, string extension)
        {
            // This method is called when the only one output stream is required, for instance for XPS, PDF or TIFF formats.
            MemoryStream result = new MemoryStream();
            Streams.Add(result);
            return result;
        }
    
        public Stream GetStream(string name, string extension, int page)
        {
            // This method is called when the creation of multiple output streams are required. For instance, during the rendering HTML to list of image files (JPG, PNG, etc.)
            MemoryStream result = new MemoryStream();
            Streams.Add(result);
            return result;
        }
    
        public void ReleaseStream(Stream stream)
        {
            //  Here you can release the stream filled with data and, for instance, flush it to the hard-drive
        }
    
        public void Dispose()
        {
            // Releasing resources
            foreach (var stream in Streams)
                stream.Dispose();
        }
    }
{{< /highlight >}}

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using System.Linq;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Create an instance of MemoryStreamProvider
    using var streamProvider = new MemoryStreamProvider();

    // Initialize an HTML document
    using var document = new HTMLDocument(@"<h1>Convert HTML to JPG File Format!</h1>", ".");
    
    // Convert HTML to JPG using the MemoryStreamProvider
    Converter.ConvertHTML(document, new ImageSaveOptions(ImageFormat.Jpeg), streamProvider);
    
    // Get access to the memory stream that contains the result data
    var memory = streamProvider.Streams.First();
    memory.Seek(0, SeekOrigin.Begin);
    
    // Flush the result data to the output file
    using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.jpg")))
    {
        memory.CopyTo(fs);
    }
{{< /highlight >}}

{{% alert color="primary" %}} 

Check the quality of HTML to JPG conversion with our online [**HTML to JPG Converter**](https://products.aspose.app/html/conversion/html-to-jpg). You can convert multiple HTML files to JPG and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful HTML to JPG Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}







