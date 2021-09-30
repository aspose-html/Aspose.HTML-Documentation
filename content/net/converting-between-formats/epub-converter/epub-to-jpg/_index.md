---
keywords: epub to jpg, convert epub to jpg, epub to jpg conversion, epub to jpg
  converter, save options
lastmod: 2021-09-03
url: /net/converting-between-formats/epub-to-jpg/
title: Convert EPUB to JPG | C#
description: This article provides information on how to convert EPUB to JPG
  using Aspose.HTML API. You will learn about the supported EPUB to JPG
  conversion scenarios and consider examples to illustrate them.
weight: 40
type: docs
aliases:
  - /net/converting-between-formats/epub-to-image-conversion/
  - /net/epub-to-image-conversion/
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

JPG files can contain high-quality image data with lossless compression. This unique compression feature allows to quickly and efficiently share JPG images and use them widely on the Web, computers, and mobile devices. With Aspose.HTML, you can convert EPUB to JPG format programmatically with full control over a wide range of conversion parameters.

In this article, you find information on how to convert  {{%EPUB%}} to {{%JPG%}} using [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/index) methods of the Converter class, and how to apply [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/epub-to-jpg" target="_blank">**EPUB to JPG Converter**</a> that converts EPUB to JPG image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/epub-to-jpg" target="_blank">![Text "Banner EPUB to JPG Converter"](epub-to-jpg.png#center)</a>

## **EPUB to JPG by two lines of code**

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an EPUB file into various formats. You can convert EPUB to JPG in your C# application literally with two lines of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Open an existing EPUB file for reading.
    using var stream = File.OpenRead(DataDir + "input.epub");

    // Invoke the ConvertEPUB method to convert the EPUB code to JPG image           
    Converter.ConvertEPUB(stream, new ImageSaveOptions(ImageFormat.Jpeg), Path.Combine(OutputDir, "convert-by-two-lines.jpg"));
{{< /highlight >}}

## **Convert EPUB to JPG**
To convert EPUB to JPG, you should follow a few steps: 

1. Open an existing EPUB file. In the example, we use the OpenRead() method of System.IO.FileStream class to open and read an EPUB file from the file system at the specified path.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) object with JPG ImageFormat. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertEPUB()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertepub/methods/27) method of the Converter class to save EPUB as a JPG image. You need to pass the EPUB file stream, ImageSaveOptions, and output file path to the ConvertEPUB() method for EPUB to JPG conversion.

Please take a look over the following C# code snippet which shows the process of converting EPUB to JPG using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Open an existing EPUB file for reading
    using var stream = File.OpenRead(DataDir + "input.epub");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "input-output.jpg");            
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Jpeg);
    
    // Call the ConvertEPUB method to convert EPUB to JPG
    Converter.ConvertEPUB(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Save Options**
Aspose.HTML allows converting EPUB to JPG using default or custom save options. [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) usage enables you to tune the rendering process. You can specify the [image format](https://apireference.aspose.com/net/html/aspose.html.rendering.image/imageformat), [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/net/html/aspose.html.drawing/page/properties/margin), [CSS media-type](https://apireference.aspose.com/net/html/aspose.html.rendering/mediatype), etc. 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [Compression](https://apireference.aspose.com/net/html/aspose.html.rendering.image/compression) | Sets Tagged Image File Format (TIFF) [Compression](https://apireference.aspose.com/html/net/aspose.html.rendering.image/compression). By default, this property is [LZW](https://apireference.aspose.com/html/net/aspose.html.rendering.image/compression). |
| [CSS](https://apireference.aspose.com/html/net/aspose.html.rendering/mediatype) | Gets a [CssOptions](https://apireference.aspose.com/html/net/aspose.html.rendering/cssoptions) object which is used for configuration of CSS properties processing. |
| [Format](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat) | Sets the [ImageFormat](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat) (JPG, PNG, BMP, TIFF, or GIF). By default, this property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat). |
| [BackgroundColor](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/backgroundcolor) | This property sets the color that will fill the background. By default, this property is Transparent. |
| [PageSetup](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup) | This property gets a page setup object and uses it for configuration output page-set. |
| [HorizontalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/horizontalresolution) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/verticalresolution) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |
| [SmoothingMode](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/smoothingmode) | This property sets the rendering quality for this image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. |
| [Text](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/properties/text) | Gets a [TextOptions](https://apireference.aspose.com/html/net/aspose.html.rendering.image/textoptions) object which is used for configuration of text rendering. |

{{% alert color="primary" %}} 

To learn more about the [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) class, please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.
{{% /alert %}}

## **Convert EPUB to JPG using ImageSaveOptions**

To convert EPUB to JPG with ImageSaveOptions specifying, you should follow a few steps: 

1. Open an existing EPUB file. 
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) object with JPG ImageFormat and specify save options. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertEPUB()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertepub/methods/27) method of the  Converter class to save EPUB as a JPG image. You need to pass the EPUB file stream, ImageSaveOptions, and output file path to the ConvertEPUB() method to convert EPUB to JPG.

The following C# code snippet shows how to convert EPUB to JPG using custom save options:

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
    // Open an existing EPUB file for reading
    using var stream = File.OpenRead(DataDir + "input.epub");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "input-options.jpg");
                
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Jpeg)
    {
        SmoothingMode = SmoothingMode.HighQuality,
        HorizontalResolution = 400,
        VerticalResolution = 400,
        BackgroundColor = Color.AliceBlue
    };
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(800, 500), new Margin(30, 20, 10, 10));
    
    // Call the ConvertEPUB method to convert EPUB to JPG
    Converter.ConvertEPUB(stream, options, savePath);
{{< /highlight >}}

The [ImageSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initialize an instance of the ImageSaveOptions class that is passed to ConvertEPUB() method. The ConvertEPUB() method takes the `stream`, `options`,  output file path `savePath` and performs the conversion operation.

In the above example, we use:
 - BackgroundColor property that specifies the color that the background will be filled in. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - SmoothingMode property that sets the rendering quality for this image;
 - PageSetup property that specifies the [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup) and [margins](https://apireference.aspose.com/net/html/aspose.html.drawing/page/properties/margin) in pixels.

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the EPUB to JPG conversion process. Among these properties, SmoothingMode that enables you to set the rendering quality for the image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. You can select any value, considering the advantages and disadvantages of each one.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement the [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) interface to have manual control over the file creating process. This interface is designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering the document/page.

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
    // Open an existing EPUB file for reading
    using var stream = File.OpenRead(DataDir + "input.epub");

    // Create an instance of MemoryStreamProvider
    using var streamProvider = new MemoryStreamProvider();
    
    // Convert HTML to JPG using the MemoryStreamProvider
    Converter.ConvertEPUB(stream, new ImageSaveOptions(ImageFormat.Jpeg), streamProvider);
    
    // Get access to the memory streams that contain the resulted data
    for (int i = 0; i < streamProvider.Streams.Count; i++)
    {
        var memory = streamProvider.Streams[i];
        memory.Seek(0, System.IO.SeekOrigin.Begin);
    
        // Flush the page to the output file
        using (FileStream fs = File.Create(Path.Combine(OutputDir, $"input-page_{i + 1}.jpg")))
        {
            memory.CopyTo(fs);
        }
{{< /highlight >}}

The ConvertEPUB(`Stream`, `ImageSaveOptions`, `ICreateStreamProvider`) method takes the conversion source, options, and instance of MemoryStreamProvider, which will be used to get an output stream, and performs the conversion operation.

{{% alert color="primary" %}} 

You can check the quality of EPUB to JPG conversion with our online [**EPUB to JPG Converter**](https://products.aspose.app/html/en/conversion/epub-to-jpg). Upload, convert your files and get results in a few seconds. Try our forceful EPUB to JPG Converter for free now!

{{% /alert %}}

