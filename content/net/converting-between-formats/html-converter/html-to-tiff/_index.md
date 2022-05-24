---
title: Convert HTML to TIFF | C#
linktitle: Convert HTML to TIFF
type: docs
weight: 50
url: /net/converting-between-formats/html-to-tiff/
description: This article provides information on how to convert HTML to TIFF using Aspose.HTML API. You will learn about the supported HTML to TIFF conversion scenarios and consider examples to illustrate them.  
keywords: HTML to TIFF, convert HTML to TIFF, HTML to TIFF conversion, HTML to TIFF converter, save options
lastmod: "2022-01-11"
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Using [Converter.ConvertHTML](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/converthtml/index) methods is the most common way to convert HTML code into various formats. Converting HTML files to TIFF images may be required, for example, if you want to add a web page in a PowerPoint presentation or send it by e-mail. With Aspose.HTML, you can convert HTML to TIFF format programmatically with full control over a wide range of conversion parameters. 

HTML to TIFF conversion allows you to save an HTML document as a TIFF image. In this article, you find information on how to convert  HTML to {{%TIFF%}} using [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/index) methods of the Converter class, and how to apply [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/conversion/html-to-tiff" target="_blank">**HTML to TIFF Converter**</a> that converts HTML to TIFF image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/html-to-tiff" target="_blank">![Text "Banner HTML to TIFF Converter"](html-to-tiff.png#center)</a>

## **Convert HTML to TIFF**
Converting a file to another format using the ConvertHTML() method is a sequence of operations among which document loading and saving:

1. Load an HTML file using the [HTMLDocument](https://apireference.aspose.com/html/net/aspose.html/htmldocument) class.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with TIFF ImageFormat. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/3) method of the Converter class to save HTML as a TIFF image. You need to pass the [HTMLDocument](https://apireference.aspose.com/html/net/aspose.html/htmldocument), [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions), and output file path to the ConvertHTML() method to convert HTML to TIFF.

Please take a look over the following C# code snippet which shows the process of converting HTML to TIFF using Aspose.HTML for .NET.

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
    string savePath = Path.Combine(OutputDir, "nature-output.tiff");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Tiff);
    
    // Convert HTML to TIFF
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

### **Live Example**
The following live example demonstrates how to convert HTML to TIFF using Aspose.HTML for .NET API. First, please load an HTML file from the local drive, then run the example. You will get the result as a separate TIFF file.

{{< app/html/converter HTML BMP JPG PNG GIF TIFF >}}
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Rendering.Image;

    using var document = new HTMLDocument("input.html");    
    var options = new ImageSaveOptions(ImageFormat.{{output camel}});
    Converter.ConvertHTML(document, options, "output.{{output lower}}");
{{< /app/html/converter>}}

## **Save Options**
Aspose.HTML allows converting HTML to TIFF using default or custom save options. [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) usage enables you to customize the rendering process. You can specify the [image format](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat), [page size](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/html/net/aspose.html.drawing/page/properties/margin), [compression level](https://apireference.aspose.com/html/net/aspose.html.rendering.image/compression), [CSS media-type](https://apireference.aspose.com/html/net/aspose.html.rendering/mediatype), etc. 

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

## **Convert HTML to TIFF using ImageSaveOptions**

To convert HTML to TIFF with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the HTMLDocument class. 
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with TIFF ImageFormat and specify save options. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/3) method of the  Converter class to save HTML as a TIFF image. You need to pass the [HTMLDocument](https://apireference.aspose.com/html/net/aspose.html/htmldocument), [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions), and output file path to the ConvertHTML() method to convert HTML to TIFF.

The following C# code snippet shows how to convert HTML to TIFF using custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System.Drawing;
using System.Drawing.Drawing2D;
...
    string documentPath = Path.Combine(DataDir, "nature.html");
    string savePath = Path.Combine(OutputDir, "nature-output-options.tiff");

    // Initialize an HTML Document from the html file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Tiff)
    {
        Compression = Compression.None,
        BackgroundColor = Color.Bisque,
        HorizontalResolution = 150,
        VerticalResolution = 150,
        SmoothingMode = SmoothingMode.AntiAlias
    };
    
    // Convert HTML to TIFF
    Converter.ConvertHTML(document, options, savePath);   
{{< /highlight >}}

The [ImageSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initializes an instance of the ImageSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the above example, we add:
 - Compression property that sets TIFF compression. Available values are LVZ, CCITT3, CCITT4, Rle, and None. We use None compression schema. By default, this property is [LZW](https://apireference.aspose.com/html/net/aspose.html.rendering.image/compression).
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - SmoothingMode property that sets the rendering quality for this image. 

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to Image formats. Among these properties, SmoothingMode that enables you to set the rendering quality for the image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. You can select any value, considering the advantages and disadvantages of each one.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

You can check the quality of HTML to TIFF conversion with our online [**HTML to TIFF Converter**](https://products.aspose.app/html/conversion/html-to-tiff). You can convert multiple HTML files to TIFF and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful HTML to TIFF Converter for free now!

{{% /alert %}}







