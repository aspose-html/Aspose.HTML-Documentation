---
title: Convert HTML to TIFF | C# Examples
linktitle: Convert HTML to TIFF
type: docs
weight: 50
url: /net/converting-between-formats/html-to-tiff/
description: This article provides information on how to convert HTML to TIFF using Aspose.HTML API. You will learn about the supported HTML to TIFF conversion scenarios and consider examples to illustrate them.  
keywords: HTML to TIFF, convert HTML to TIFF, HTML to TIFF conversion, HTML to TIFF converter, save options, online converter, c# code
lastmod: "2022-07-28"
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Using [Converter.ConvertHTML](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) methods is the most common way to convert HTML code into various formats. Converting HTML files to TIFF images may be required, for example, if you want to add a web page in a PowerPoint presentation or send it by e-mail. With Aspose.HTML, you can convert HTML to TIFF format programmatically with full control over a wide range of conversion parameters. 

HTML to TIFF conversion allows you to save an HTML document as a TIFF image. In this article, you find information on how to convert  HTML to {{%TIFF%}} using [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/) methods of the Converter class, and how to apply [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/) and [ICreateStreamProvider](https://reference.aspose.com/html/net/aspose.html.io/icreatestreamprovider/) parameters.


## **Online HTML Converter**

You can check the Aspose.HTML API functionality and convert HTML in real-time. Please load HTML from the local file system, select the output format and run the example. In the example, the save options are set by default. You will immediately receive the result as a separate file.

{{< app/html/converter HTML TIFF GIF BMP "JPG|JPEG" PNG  PDF XPS DOCX MD MHTML >}}
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Rendering.Image;

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

If you want to convert HTML to TIFF programmatically, please see the following C# code examples.

## **Convert HTML to TIFF**
Converting a file to another format using the ConvertHTML() method is a sequence of operations among which document loading and saving:

1. Load an HTML file using the [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/) class.
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/) object with TIFF ImageFormat. By default, the Format property is [PNG](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat/).
1. Use the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) method of the Converter class to save HTML as a TIFF image. You need to pass the [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/), [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/), and output file path to the ConvertHTML() method to convert HTML to TIFF.

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

## **Save Options**
Aspose.HTML allows converting HTML to TIFF using default or custom save options. [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/) usage enables you to customize the rendering process. You can specify the [image format](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat/), [page size](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/), [margins](https://reference.aspose.com/html/net/aspose.html.drawing/page/margin/), [compression level](https://reference.aspose.com/html/net/aspose.html.rendering.image/compression/), [CSS media-type](https://reference.aspose.com/html/net/aspose.html.rendering/mediatype/), etc. 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [Compression](https://reference.aspose.com/html/net/aspose.html.rendering.image/compression/) | Sets Tagged Image File Format (TIFF) [Compression](https://reference.aspose.com/html/net/aspose.html.rendering.image/compression/). By default, this property is [LZW](https://reference.aspose.com/html/net/aspose.html.rendering.image/compression/). |
| [CSS](https://reference.aspose.com/html/net/aspose.html.rendering/mediatype/) | Gets a [CssOptions](https://reference.aspose.com/html/net/aspose.html.rendering/cssoptions/) object which is used for configuration of CSS properties processing. |
| [Format](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat/) | Sets the [ImageFormat](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat/) (JPG, PNG, BMP, TIFF, or GIF). By default, this property is [PNG](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat/). |
| [BackgroundColor](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/backgroundcolor/) | This property sets the color that will fill the background. By default, this property is Transparent. |
| [PageSetup](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/) | This property gets a page setup object and uses it for configuration output page-set. |
| [HorizontalResolution](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/horizontalresolution/) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/verticalresolution/) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |
| [SmoothingMode](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/smoothingmode/) | This property sets the rendering quality for this image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. |
| [Text](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/text/) | Gets a [TextOptions](https://reference.aspose.com/html/net/aspose.html.rendering.image/textoptions/) object which is used for configuration of text rendering. |

{{% alert color="primary" %}} 

To learn more about the [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/) class, please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.
{{% /alert %}}

## **Convert HTML to TIFF using ImageSaveOptions**

To convert HTML to TIFF with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the HTMLDocument class. 
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/) object with TIFF ImageFormat and specify save options. By default, the Format property is [PNG](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat/).
1. Use the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) method of the  Converter class to save HTML as a TIFF image. You need to pass the [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument/), [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/), and output file path to the ConvertHTML() method to convert HTML to TIFF.

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
        BackgroundColor = System.Drawing.Color.Bisque,
        HorizontalResolution = 150,
        VerticalResolution = 150,
        SmoothingMode = SmoothingMode.AntiAlias
    };
    
    // Convert HTML to TIFF
    Converter.ConvertHTML(document, options, savePath);   
{{< /highlight >}}

The [ImageSaveOptions()](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/imagesaveoptions/) constructor initializes an instance of the ImageSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the above example, we add:
 - Compression property that sets TIFF compression. Available values are LVZ, CCITT3, CCITT4, Rle, and None. We use None compression schema. By default, this property is [LZW](https://reference.aspose.com/html/net/aspose.html.rendering.image/compression/).
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - SmoothingMode property that sets the rendering quality for this image. 

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting HTML to Image formats. Among these properties, SmoothingMode that enables you to set the rendering quality for the image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. You can select any value, considering the advantages and disadvantages of each one.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

Aspose.HTML offers a free online <a href="https://products.aspose.app/html/conversion/html-to-tiff" target="_blank">**HTML to TIFF Converter**</a> that converts HTML to TIFF image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/html-to-tiff" target="_blank">![Text "Banner HTML to TIFF Converter"](html-to-tiff.png#center)</a>







