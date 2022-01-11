---
title: Convert HTML to PNG | C#
linktitle: Convert HTML to PNG
keywords: HTML to PNG, convert HTML to PNG, HTML to PNG converter, save options,
  stream provider
description: This article provides information on how to convert HTML to PNG
  using Aspose.HTML API. You will learn about the supported HTML to PNG
  conversion scenarios and consider examples to illustrate them.
weight: 30
type: docs
url: /net/converting-between-formats/html-to-png/
lastmod: 2022-01-11
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

PNG is one of the most used image file formats. It supports lossless image compression that makes it popular among its users.  Converting HTML files to the PNG image may be required, for example, if you want to add a web page in a PowerPoint presentation, insert it on a blog for your readers, or send by e-mail. With Aspose.HTML, you can convert HTML to PNG format programmatically with full control over a wide range of conversion parameters. 

In this article, you find information on how to convert  HTML to {{%PNG%}} by using [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/index) methods of the Converter class, and how to apply [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/conversion/html-to-png" target="_blank">**HTML to PNG Converter**</a> that converts HTML to PNG image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/html-to-png" target="_blank">![Text "Banner HTML to PNG Converter"](html-to-png.png#center)</a>

## **HTML to PNG by a single line of code**

The static methods of the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class are primarily used as the easiest way to convert an HTML code into various formats. You can convert HTML to PNG in your C# application literally with a single line of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Invoke the ConvertHTML method to convert the HTML code to PNG image           
    Converter.ConvertHTML(@"<h1>Convert HTML to PNG!</h1>", ".", new ImageSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.png"));
{{< /highlight >}}

## **Convert HTML to PNG**
Converting a file to another format using the ConvertHTML() method is a sequence of operations among which document loading and saving:

1. Load an HTML file using the [HTMLDocument](https://apireference.aspose.com/html/net/aspose.html/htmldocument) class.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/3) method of the Converter class to save HTML as a PNG image. You need to pass the [HTMLDocument](https://apireference.aspose.com/html/net/aspose.html/htmldocument), [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions), and output file path to the ConvertHTML() method to convert HTML to PNG.

Please take a look over the following C# code snippet which shows the process of converting HTML to PNG using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "nature.html");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "nature-output.png");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Png);
    
    // Convert HTML to PNG
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Save Options**
Aspose.HTML allows converting HTML to PNG using default or custom save options. [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) usage enables you to customize the rendering process; you can specify the [image format](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat), [page size](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/html/net/aspose.html.drawing/page/properties/margin), [CSS media-type](https://apireference.aspose.com/html/net/aspose.html.rendering/mediatype), etc. 

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

{{% alert color="primary" %}} 

To learn more about the [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) class, please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.
{{% /alert %}}

## **Convert HTML to PNG using ImageSaveOptions**

To convert HTML to PNG with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the HTMLDocument class. 
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object and specify save options. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/3) method of the  Converter class to save HTML as a JPG image. You need to pass the HTMLDocument, ImageSaveOptions, and output file path to the ConvertHTML() method to convert HTML to PNG.

The following C# code snippet shows how to convert HTML to PNG using custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System.Drawing;
using System.Drawing.Drawing2D;
...
    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "nature.html");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "nature-output-options.png");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize ImageSaveOptions            
    var options = new ImageSaveOptions()
    {
        SmoothingMode = SmoothingMode.Default,
        HorizontalResolution = 100,
        VerticalResolution = 100,
        BackgroundColor = Color.Beige
    };
    
    // Convert HTML to PNG
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

The [ImageSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initializes an instance of the ImageSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the above example, we add:
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - SmoothingMode property that sets the rendering quality for this image. 

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to Image formats. Among these properties, SmoothingMode that enables you to set the rendering quality for the image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. You can select any value, considering the advantages and disadvantages of each one.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement the [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) interface to have manual control over the file creating process. This interface is designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering the document/page.

{{% alert color="primary" %}} 

Aspose.HTML for .NET provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance, {{%PDF%}}, {{%XPS%}}), others create multiple files (Image formats - JPG, PNG, etc.).

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
            // This method is called when only one output stream is required, for instance for XPS, PDF or TIFF formats.
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
    using var document = new HTMLDocument(@"<h1>Convert HTML to PNG File Format!</h1>", ".");
    
    // Convert HTML to PNG using the MemoryStreamProvider
    Converter.ConvertHTML(document, new ImageSaveOptions(ImageFormat.Png), streamProvider);
    
    // Get access to the memory stream that contains the result data
    var memory = streamProvider.Streams.First();
    memory.Seek(0, SeekOrigin.Begin);
    
    // Flush the result data to the output file
    using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.png")))
    {
        memory.CopyTo(fs);
    }
{{< /highlight >}}

{{% alert color="primary" %}} 

You can check the quality of HTML to PNG conversion with our online  [**HTML to PNG Converter**](https://products.aspose.app/html/conversion/html-to-png). You can convert multiple HTML files to PNG and merge them into a single document. Try our forceful HTML to PNG Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}







