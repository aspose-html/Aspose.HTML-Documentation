---
title: Convert HTML to GIF
keywords: HTML to GIF, convert HTML to GIF, HTML to GIF conversion, HTML to GIF
  converter, save options
description: This article provides information on how to convert HTML to GIF
  using the Aspose.HTML API. You will learn about the supported HTML to GIF
  conversion scenarios and consider examples to illustrate them.
weight: 60
type: docs
url: /net/converting-between-formats/html-to-gif/
lastmod: 2021-09-03
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Using [Converter.ConvertHTML](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/converthtml/index) methods is the most common way to convert HTML code into various formats. With Aspose.HTML, you can convert HTML to GIF format programmatically with full control over a wide range of conversion parameters. 

GIF is a popular image format that supports animated images and frequently used in web publishing. HTML to GIF conversion allows you to save an HTML document as a GIF image. In this article, you find information on how to convert  HTML to {{%GIF%}} using ConvertHTML() methods of the Converter class, and how to apply [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/html-to-gif" target="_blank">**HTML to GIF Converter**</a> that converts HTML to GIF image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!

{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/html-to-gif" target="_blank">![Text "Banner HTML to GIF Converter"](html-to-gif.png#center)</a>

## **Convert HTML to GIF**
Converting a file to another format using the ConvertHTML() method is a sequence of operations among which document loading and saving:

1. Load an HTML file using the [HTMLDocument](https://apireference.aspose.com/net/html/aspose.html/htmldocument) class ([spring.html](/html/net/converting-between-formats/html-to-pdf/spring.html)).
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) object with GIF ImageFormat. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/3) method of the Converter class to save HTML as a GIF image. You need to pass the HTMLDocument, ImageSaveOptions, and output file path to the ConvertHTML() method for HTML to GIF conversion.

Please take a look over the following C# code snippet which shows the process of converting HTML to GIF using Aspose.HTML for .NET.

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
    string savePath = Path.Combine(OutputDir, "spring-output.gif");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Gif);
    
    // Convert HTML to GIF
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Save Options**
Aspose.HTML allows converting HTML to GIF using default or custom save options. [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) usage enables you to customize the rendering process; you can specify the [image format](https://apireference.aspose.com/net/html/aspose.html.rendering.image/imageformat), [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/net/html/aspose.html.drawing/page/properties/margin), [compression level](https://apireference.aspose.com/net/html/aspose.html.rendering.image/compression), [CSS media-type](https://apireference.aspose.com/net/html/aspose.html.rendering/mediatype), etc. 

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

## **Convert HTML to GIF using ImageSaveOptions**

To convert HTML to GIF with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an HTML file using one of the HTMLDocument() constructors of the HTMLDocument class (color.html). 
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) object with GIF ImageFormat and specify save options. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/3) method of the  Converter class to save HTML as a GIF image. You need to pass the HTMLDocument, ImageSaveOptions, and output file path to the ConvertHTML() method to convert HTML to GIF.

The following C# code snippet shows how to convert HTML to GIF using custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System.Drawing;
using System.Drawing.Drawing2D;
...
    string documentPath = Path.Combine(OutputDir, "convert-to-gif.html");
    string savePath = Path.Combine(OutputDir, "convert-to-gif-options.gif");

    // Prepare HTML code and save it to a file
    var code = "<h1> HTML to GIF Converter </h1>\r\n" +
               "<p> HTML to GIF conversion allows you to save an HTML document as a GIF image.</p>\r\n";
    
    File.WriteAllText(documentPath, code);
    
    // Initialize an  HTML Document from the html file
    using var document = new HTMLDocument(documentPath);
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Gif)
    {
        SmoothingMode = SmoothingMode.Default,
        HorizontalResolution = 100,
        VerticalResolution = 100,
        BackgroundColor = Color.MistyRose
    };
     options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(500, 200), new Margin(30, 20, 10, 10));
    
    // Convert HTML to GIF
    Converter.ConvertHTML(document, options, savePath);   
{{< /highlight >}}

The [ImageSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initialize an instance of the ImageSaveOptions class that is passed to ConvertHTML() method. The ConvertHTML() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the above example, we apply:
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - SmoothingMode property that sets the rendering quality for this image.
 -  PageSetup property that specifies the [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup) and [margins](https://apireference.aspose.com/net/html/aspose.html.drawing/page/properties/margin).



The figure illustrates the convert-to-gif-options.gif file.

![Text "convert-to-gif-options.gif image"](convert-to-gif-options.gif#center)

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

You can check the quality of HTML to GIF conversion with our online [**HTML to GIF Converter**](https://products.aspose.app/html/en/conversion/html-to-gif). You can convert multiple HTML files to GIF and merge them into a single document. Upload, convert your files and get results in a few seconds. Try our forceful HTML to GIF Converter for free now!

{{% /alert %}}







