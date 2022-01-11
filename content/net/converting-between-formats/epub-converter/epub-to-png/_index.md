---
title: Convert EPUB to PNG | C#
linktitle: Convert EPUB to PNG
keywords: epub to png, convert epub to png, epub to png conversion, epub to png
  converter, save options
description: This article provides information on how to convert EPUB to PNG
  using the Aspose.HTML API. You will learn about the supported EPUB to PNG
  conversion scenarios and consider examples to illustrate them.
weight: 50
type: docs
url: /net/converting-between-formats/epub-to-png/
lastmod: 2022-01-11
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

PNG file format supports lossless image compression that makes it popular among its users. It widely takes to transmit pictures over the network, display photos and graphics on web pages and reserve in cloud storages. With Aspose.HTML, you can convert EPUB to PNG format programmatically with full control over a wide range of conversion parameters.

In this article, you find information on how to convert  {{%EPUB%}} to {{%PNG%}} using [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/index) methods of the Converter class, and how to apply [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/conversion/epub-to-png" target="_blank">**EPUB to PNG Converter**</a> that converts EPUB to PNG image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/epub-to-png" target="_blank">![Text "Banner EPUB to PNG Converter"](epub-to-png.png#center)</a>

## **EPUB to PNG by a single line of code**

The static methods of the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class are primarily used as the easiest way to convert an EPUB file into various formats. You can convert EPUB to PNG in your C# application literally with a single line of code!

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Invoke the ConvertEPUB method to convert the EPUB code to PNG image           
    Converter.ConvertEPUB(File.OpenRead(DataDir + "input.epub"), new ImageSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.png"));
{{< /highlight >}}

## **Convert EPUB to PNG**
Using [Converter.ConvertEPUB](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertepub/index) methods is the most common way to convert EPUB files into various formats. You should follow a few steps:

1. Open an existing EPUB file. In the example, we use the OpenRead() method of System.IO.FileStream class to open and read an EPUB file from the file system at the specified path.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertEPUB()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertepub/methods/27) method of the Converter class to save EPUB as a PNG image. You need to pass the EPUB file stream, ImageSaveOptions, and output file path to the ConvertEPUB() method for EPUB to PNG conversion.

Please take a look over the following C# code snippet which shows the process of converting EPUB to PNG using Aspose.HTML for .NET.

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
   string savePath = Path.Combine(OutputDir, "input-output.png");

   // Initialize ImageSaveOptions 
   var options = new ImageSaveOptions();

   // Call the ConvertEPUB method to convert EPUB to PNG
   Converter.ConvertEPUB(stream, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Save Options**
Aspose.HTML allows converting EPUB to PNG using default or custom save options. [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) usage enables you to tune the rendering process. You can specify the [page size](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/html/net/aspose.html.drawing/page/properties/margin), [CSS media-type](https://apireference.aspose.com/html/net/aspose.html.rendering/mediatype), etc. 

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

## **Convert EPUB to PNG using ImageSaveOptions**

To convert EPUB to PNG with ImageSaveOptions specifying, you should follow a few steps: 

1. Open an existing EPUB file. 
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object and specify save options.
1. Use the [ConvertEPUB()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertepub/methods/27) method of the  Converter class to save EPUB as a PNG image. You need to pass the EPUB file stream, ImageSaveOptions, and output file path to the ConvertEPUB() method to convert EPUB to PNG.

The following C# code snippet shows how to convert EPUB to PNG using custom save options:

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
    string savePath = Path.Combine(OutputDir, "input-options.png");
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions()
    {
        SmoothingMode = SmoothingMode.HighQuality,
        HorizontalResolution = 400,
        VerticalResolution = 400,
        BackgroundColor = Color.AliceBlue
    };            
    
    // Call the ConvertEPUB method to convert EPUB to PNG
    Converter.ConvertEPUB(stream, options, savePath);
{{< /highlight >}}

The [ImageSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initializes an instance of the ImageSaveOptions class that is passed to ConvertEPUB() method. The ConvertEPUB() method takes the `stream`, `options`,  output file path `savePath` and performs the conversion operation.

In the example, we use:
 - BackgroundColor property that specifies the color that the background will be filled in. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - SmoothingMode property that sets the rendering quality for this image. 

{{% alert color="primary" %}} 

Check the quality of EPUB to PNG conversion with our online [**EPUB to PNG Converter**](https://products.aspose.app/html/conversion/epub-to-png). You can convert multiple EPUB files to JPG and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful EPUB to PNG Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}