---
keywords: MHTML to JPG, convert MHTML to JPG, MHTML to JPG converter, MHTML to
  PNG, MHTML to BMP, MHTML to GIF, MHTML to TIFF, save options
lastmod: 2021-09-03
url: /net/converting-between-formats/mhtml-to-image/
title: Convert MHTML to Image | C#
linktitle: Convert MHTML to Image
description: This article provides information on how to convert MHTML to Image
  file formats using Aspose.HTML API. You will learn about the supported MHTML
  to Image conversion scenarios and consider examples to illustrate them.
weight: 40
type: docs
aliases:
  - /net/converting-between-formats/mhtml-to-image-conversion/
  - /net/mhtml-to-image-conversion/
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

In this article, you will find information on how to convert an {{%MHTML%}} file to Image File Formats such as {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, or {{%GIF%}} and how to use [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/mhtml-to-jpg" target="_blank">**MHTML to JPG Converter**</a> that converts MHTML to JPG image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/mhtml-to-jpg" target="_blank">![Text "Banner MHTML to JPG Converter"](mhtml-to-jpg.png#center)</a>

## **MHTML to JPG by two lines of code**

The static methods of the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class are primarily used as the easiest way to convert an MHTML file into various formats. You can convert MHTML to JPG in your C# application literally with two lines of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Open an existing MHTML file for reading
    using var stream = File.OpenRead(DataDir + "sample.mht");

    // Invoke the ConvertMHTML method to convert MHTML to JPG           
    Converter.ConvertMHTML(stream, new ImageSaveOptions(ImageFormat.Jpeg), Path.Combine(OutputDir, "convert-by-two-lines.jpg"));
{{< /highlight >}}

## **Convert MHTML to JPG**
Converting a file to another format using the ConvertMHTML() method is a sequence of operations among which document loading and saving:

1. Open an existing MHTML file.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with JPG ImageFormat. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/27) method of the Converter class to save MHTML as a JPG image. You need to pass the MHTML file stream, ImageSaveOptions, and output file path to the ConvertMHTML() method for MHTML to JPG conversion.

Please take a look over the following C# code snippet which shows the process of converting MHTML to JPG using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Open an existing MHTML file for reading
    using var stream = File.OpenRead(DataDir + "sample.mht");
                
    // Create an instance of ImageSaveOptions
    var options = new ImageSaveOptions(ImageFormat.Jpeg);
    
    // Call the ConvertMHTML method to convert MHTML to JPG
    Converter.ConvertMHTML(stream, options, Path.Combine(OutputDir, "sample-output.jpg"));
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Convert MHTML to PNG**
Converting a file to another format using the ConvertMHTML() method is a sequence of operations among which document loading and saving:

1. Open an existing MHTML file.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/27) method of the Converter class to save MHTML as a PNG image. You need to pass the MHTML file stream, ImageSaveOptions, and output file path to the ConvertMHTML() method for MHTML to PNG converting.

The following C# code snippet shows how to convert MHTML to PNG using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Open an existing MHTML file for reading
    using var stream = File.OpenRead(DataDir + "sample.mht");

    // Create an instance of ImageSaveOptions
    var options = new ImageSaveOptions(ImageFormat.Png);
    
    // Call the ConvertMHTML method to convert MHTML to PNG
    Converter.ConvertMHTML(stream, options, Path.Combine(OutputDir, "sample-output.png"));
{{< /highlight >}}


## **Convert MHTML to BMP**
Converting a file to another format using the ConvertMHTML() method is a sequence of operations among which document loading and saving:

1. Open an existing MHTML file.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with BMP ImageFormat. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/27) method of the Converter class to save MHTML as a BMP image. You need to pass the MHTML file stream, ImageSaveOptions, and output file path to the ConvertMHTML() method for MHTML to BMP conversion.

Please take a look over the following C# code snippet which shows the process of converting MHTML to BMP using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Open an existing MHTML file for reading
    using var stream = File.OpenRead(DataDir + "sample.mht");

    // Create an instance of ImageSaveOptions
    var options = new ImageSaveOptions(ImageFormat.Bmp);
    
    // Call the ConvertMHTML method to convert MHTML to BMP
    Converter.ConvertMHTML(stream, options, Path.Combine(OutputDir, "sample-output.bmp"));
{{< /highlight >}}


{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Convert MHTML to GIF**
Converting a file to another format using the ConvertMHTML() method is a sequence of operations among which document loading and saving:

1. Open an existing MHTML file.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with GIF ImageFormat. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/27) method of the Converter class to save MHTML as a GIF image. You need to pass the MHTML file stream, ImageSaveOptions, and output file path to the ConvertMHTML() method for MHTML to GIF converting.

Please take a look over the following C# code snippet which shows the process of converting MHTML to GIF using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Open an existing MHTML file for reading
    using var stream = File.OpenRead(DataDir + "sample.mht");

    // Create an instance of ImageSaveOptions
    var options = new ImageSaveOptions(ImageFormat.Gif);
    
    // Call the ConvertMHTML method to convert MHTML to GIF
    Converter.ConvertMHTML(stream, options, Path.Combine(OutputDir, "sample-output.gif"));
{{< /highlight >}}

## **Convert MHTML to TIFF**
Converting a file to another format using the ConvertMHTML() method is a sequence of operations among which document loading and saving. To convert MHTML to TIFF, you should follow a few steps:

1. Open an existing MHTML file.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with TIFF ImageFormat. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/27) method of the Converter class to save MHTML as a TIFF image. You need to pass the MHTML file stream, ImageSaveOptions, and output file path to the ConvertMHTML() method for MHTML to TIFF converting.

Please take a look over the following C# code snippet, which shows the process of MHTML to TIFF conversion using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Open an existing MHTML file for reading
    using var stream = File.OpenRead(DataDir + "sample.mht");

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "sample-options.tiff");
    
    // Create an instance of ImageSaveOptions
    var options = new ImageSaveOptions(ImageFormat.Tiff);
    
    // Call the ConvertMHTML method to convert MHTML to TIFF
    Converter.ConvertMHTML(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Save Options**
Aspose.HTML allows converting MHTML to Image using default or custom save options. [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) usage enables you to tune the rendering process. You can specify the [image format](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat), [page size](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/html/net/aspose.html.drawing/page/properties/margin), [CSS media-type](https://apireference.aspose.com/html/net/aspose.html.rendering/mediatype), etc. 

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

## **Convert MHTML to JPG using ImageSaveOptions**

To convert MHTML to JPG with ImageSaveOptions specifying, you should follow a few steps: 

1. Open an existing MHTML file.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with JPG ImageFormat and specify save options. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertMHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmhtml/methods/27) method of the Converter class to save MHTML as a JPG image. 

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting MHTML to Image formats. The following C# code snippet shows how to convert MHTML to JPG using custom save options:

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
    // Open an existing MHTML file for reading
    using var stream = File.OpenRead(DataDir + "sample.mht");

    // Prepare a path to save the converted file 
    string savePath = Path.Combine(OutputDir, "sample-options.jpg");
    
    // Initailize the ImageSaveOptions with a custom page-size and a background color 
    var options = new ImageSaveOptions(ImageFormat.Jpeg)
    {
        PageSetup =
            {
                AnyPage = new Page()
                {
                    Size = new Aspose.Html.Drawing.Size(Length.FromPixels(1000), Length.FromPixels(500))
                }
            },
        BackgroundColor = Color.Beige
    };
    
    // Call the ConvertMHTML method to convert MHTML to JPG
    Converter.ConvertMHTML(stream, options, savePath);
{{< /highlight >}}

The [ImageSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initializes an instance of the ImageSaveOptions class that is passed to ConvertMHTML() method. The ConvertHTML() method takes the `stream`, `options`,  output file path `savePath` and performs the conversion operation.

In the example, we use:
 - BackgroundColor property that specifies the color that the background will be filled in. The default BackgroundColor is Transparent;
 - PageSetup property that specifies the page size of the JPG image. 

## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) interface to have manual control over the file creating process. This interface is designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering the document/page.

{{% alert color="primary" %}} 

Aspose.HTML for .NET provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance {{%PDF%}}, {{%XPS%}}), others create multiple files (Image formats {{%JPG%}}, {{%PNG%}}, etc.).

{{% /alert %}} 

The example below shows how to implement and use your own *MemoryStreamProvider* in the application:

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
using Aspose.Html.Saving;
...
     // Create an instance of MemoryStreamProvider
     using var streamProvider = new MemoryStreamProvider();

     // Open an existing MHTML file for reading
     using var stream = File.OpenRead(DataDir + "sample.mht");
    
     // Prepare a path to save the converted file 
     string savePath = Path.Combine(OutputDir, "stream-provider.jpg");
    
     // Convert MHTML to JPG by using the MemoryStreamProvider class
     Converter.ConvertMHTML(stream, new ImageSaveOptions(ImageFormat.Jpeg), streamProvider);
    
     // Get access to the memory streams that contain the resulted data
     for (int i = 0; i < streamProvider.Streams.Count; i++)
     {
         var memory = streamProvider.Streams[i];
         memory.Seek(0, SeekOrigin.Begin);
    
         // Flush the page to the output file
         //using (FileStream fs = File.Create($"page_{i + 1}.jpg"))
         using (FileStream fs = File.Create(savePath))
         {
             memory.CopyTo(fs);
         }
{{< /highlight >}}

{{% alert color="primary" %}} 
You can check the quality of MHTML to JPG, PNG, BMP, GIF or TIFF conversion with our online [**MHTML Converter**](https://products.aspose.app/html/en/conversion/mhtml). You can convert multiple MHTML files to JPG or other image formats and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful MHTML Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

