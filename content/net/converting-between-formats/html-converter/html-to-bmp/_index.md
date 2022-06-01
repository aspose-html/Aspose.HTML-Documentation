---
title: Convert HTML to BMP | C#
linktitle: Convert HTML to BMP
keywords: html to bmp, convert html to bmp, html to bmp conversion, html to bmp
  converter, save options
description: This article provides information on how to convert HTML to BMP
  using the Aspose.HTML API. You will learn about the supported HTML to BMP
  conversion scenarios and consider examples to illustrate them.
weight: 40
type: docs
url: /net/converting-between-formats/html-to-bmp/
lastmod: 2022-06-06
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

BMP files represent Bitmap Image files that are used to store high-quality bitmap digital images. The BMP file format can store data as two-dimensional digital images in both monochrome as well as color format with various color depths. It can save color data for each pixel in an image without any compression. With Aspose.HTML, you can convert HTML to BMP format programmatically with full control over a wide range of conversion parameters. 

In this article, you find information on how to convert  HTML to {{%BMP%}} by using [ConvertHTML(](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/index)) methods of the Converter class, and how to apply [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/html/net/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}} 
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/conversion/html-to-bmp" target="_blank">**HTML to BMP Converter**</a> that converts HTML to BMP image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}} 

<a href="https://products.aspose.app/html/conversion/html-to-bmp" target="_blank">![Text "Banner HTML to BMP Converter"](html-to-bmp.png#center)</a>

## **Convert HTML to BMP**
Converting a file to another format using the ConvertHTML() method is a sequence of operations among which document loading and saving:

1. Load an HTML file using the [HTMLDocument](https://apireference.aspose.com/html/net/aspose.html/htmldocument) class ([bmp.html](/html/net/converting-between-formats/html-to-bmp/bmp.html)).
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with BMP ImageFormat. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/3) method of the Converter class to save HTML as a BMP image. You need to pass the HTMLDocument, ImageSaveOptions, and output file path to the ConvertHTML() method to convert HTML to BMP.

Please take a look over the following C# code snippet which shows the process of converting HTML to BMP using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Prepare a path to a source HTML file
    string documentPath = Path.Combine(DataDir, "bmp.html");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "bmp-output.bmp");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Bmp);
    
    // Convert HTML to BMP
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

### **HTML Converter Live Demos**
You can convert HTML to BMP with Aspose.HTML for .NET API in real time. First, load an HTML file from your local drive and then run the example. In this example, the save options are set by default. You will immediately receive the conversion result as a separate file.

{{< app/html/converter HTML BMP "JPG|JPEG" TIFF PNG GIF PDF XPS DOCX MD MHTML >}}
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;

    using var document = new HTMLDocument("document.{{input lower}}");
{{#if_output 'PDF'}}
    var options = new PdfSaveOptions();
{{/if_output}}
{{#if_output 'DOCX'}}
    var options = new DocSaveOptions();
{{/if_output}}
{{#if_output 'XPS'}}
    var options = new XpsSaveOptions();
{{/if_output}}
{{#if_output 'MD'}}
    var options = new MarkdownSaveOptions();
{{/if_output}}
{{#if_output 'MHTML'}}
    var options = new MHTMLSaveOptions();
{{/if_output}}
{{#if_output 'BMP' 'JPG' 'GIF' 'PNG' 'TIFF'}}
    var options = new ImageSaveOptions(ImageFormat.{{output param2 camel}});
{{/if_output}}
    Converter.ConvertHTML(document, options, "output.{{output lower}}");   
{{< /app/html/converter>}}

## **Save Options**
Aspose.HTML allows converting HTML to BMP using default or custom save options. [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) usage enables you to customize the rendering process; you can specify the [image format](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat), [page size](https://apireference.aspose.com/html/net/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/html/net/aspose.html.drawing/page/properties/margin), [compression level](https://apireference.aspose.com/html/net/aspose.html.rendering.image/compression), [CSS media-type](https://apireference.aspose.com/html/net/aspose.html.rendering/mediatype), etc. 

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

## **Convert HTML to BMP using ImageSaveOptions**

To convert HTML to BMP with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the HTMLDocument class ([bmp.html](/html/net/converting-between-formats/html-to-bmp/bmp.html)). 
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with BMP ImageFormat and specify save options. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/3) method of the  Converter class to save HTML as a BMP image. You need to pass the [HTMLDocument](https://apireference.aspose.com/html/net/aspose.html/htmldocument), [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions), and output file path to the ConvertHTML() method to convert HTML to BMP.

The following C# code snippet shows how to convert HTML to BMP using custom save options:

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
    string documentPath = Path.Combine(DataDir, "bmp.html");

    // Prepare a path for converted file saving
    string savePath = Path.Combine(OutputDir, "bmp-output-options.bmp");
    
    // Initialize an HTML Document from the html file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Bmp)
    {
        SmoothingMode = SmoothingMode.Default,
        HorizontalResolution = 350,
        VerticalResolution = 350,
        BackgroundColor = Color.Beige
    };
    
    // Convert HTML to BMP
    Converter.ConvertHTML(document, options, savePath);    
{{< /highlight >}}

The [ImageSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initializes an instance of the ImageSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the above example, we apply:
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - SmoothingMode property that sets the rendering quality for this image. 

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to Image formats. Among these properties, SmoothingMode that enables you to set the rendering quality for the image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. You can select any value, considering the advantages and disadvantages of each one.

The figure shows the bmp-output-options.bmp file.

![Text "BMP image"](bmp-output-options.png#center)

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

You can check the quality of HTML to BMP conversion with our online [**HTML to BMP Converter**](https://products.aspose.app/html/conversion/html-to-bmp). You can convert multiple HTML files to BMP and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful HTML to BMP Converter for free now!

{{% /alert %}}







