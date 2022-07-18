---
title: Convert SVG to BMP | C#
linktitle: Convert SVG to BMP
keywords: svg to bmp, convert svg to bmp, svg to bmp conversion, svg to bmp
  converter, save options
description: This article provides information on how to convert SVG to BMP
  using the Aspose.HTML API. You will learn about the supported SVG to BMP
  conversion scenarios and consider C# examples to illustrate them.
weight: 40
type: docs
url: /net/converting-between-formats/svg-to-bmp/
lastmod: 2022-06-01
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

BMP files represent Bitmap Image files that are used to store high-quality bitmap digital images. With Aspose.HTML, you can convert SVG to BMP format programmatically with full control over a wide range of conversion parameters. In this article, you find information on SVG to {{%BMP%}} conversion by using [ConvertSVG()](https://reference.aspose.com/html/net/aspose.html.converters/converter/methods/convertsvg/index) methods of the Converter class and applying  [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions).

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/svg/conversion/svg-to-bmp" target="_blank">**SVG to BMP Converter**</a> that converts SVG to BMP image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/svg/conversion/svg-to-bmp" target="_blank">![Text "Banner SVG to BMP Converter"](svg-to-bmp.png#center)</a>

## **SVG to BMP by a single line of code**

The static methods of the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter) class are primarily used as the easiest way to convert an SVG file into various formats. You can convert SVG to BMP in your C# application literally with a single line of code!

In the following example, we take an SVG file in a local file system ([shapes.svg](/html/net/converting-between-formats/svg-to-jpg/shapes.svg)), convert and save it in the local file system.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
     // Invoke the ConvertSVG method for SVG to BMP conversion          
     Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new ImageSaveOptions(ImageFormat.Bmp), Path.Combine(OutputDir, "convert-with-single-line.bmp"));
{{< /highlight >}}

## **Convert SVG to BMP**
Converting a file to another format using the ConvertSVG() method is a sequence of operations among which document loading and saving. In the following example, we create an SVG file from code. 

1. Prepare code for an SVG document.
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with BMP ImageFormat. By default, the Format property is [PNG](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertSVG(`content`, `baseUri`, `options`, `outputPath`)](https://reference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/51) method of the Converter class to save SVG as a BMP image. 

Please take a look over the following C# code snippet which shows the process of converting SVG to BMP using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Prepare SVG code 
    var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
               "<circle cx ='100' cy ='100' r ='50' fill='none' stroke='red' stroke-width='10' />" +
               "</svg>";

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "circle.bmp");
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Bmp);
    
    // Convert SVG to BMP
    Converter.ConvertSVG(code, ".", options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

### **SVG Converter Live Demos**
You can convert SVG to other formats with Aspose.HTML API in real time. First, load an SVG file from your local drive and then run the example. The save options are set by default. You will immediately receive the conversion result as a separate file.

{{< app/svg/converter SVG BMP PDF "JPG|JPEG" GIF XPS TIFF PNG DOCX>}}
using Aspose.Html;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Rendering.Image;

    using var document = new SVGDocument("image.svg");
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
{{#if_output 'BMP' 'JPG' 'GIF' 'PNG' 'TIFF'}}
    var options = new ImageSaveOptions(ImageFormat.{{output param2 camel}});
{{/if_output}}
    Converter.ConvertSVG(document, options, "output.{{output lower}}");   
{{< /app/svg/converter>}}

## **Convert SVG to BMP using ImageSaveOptions**

To convert SVG to BMP with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an SVG file using one of the SVGDocument() constructors of the [SVGDocument](https://reference.aspose.com/html/net/aspose.html.dom.svg/svgdocument) class. ([flower1.svg](/html/net/converting-between-formats/svg-to-png/flower1.svg)). 
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with BMP ImageFormat and specify save options. By default, the Format property is [PNG](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertSVG()](https://reference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/3) method to save SVG as a BMP image. You need to pass the SVGDocument, ImageSaveOptions, and output file path to the ConvertSVG() method to convert SVG to BMP.

The following C# code snippet shows how to convert SVG to BMP using custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System.Drawing;
using System.Drawing.Drawing2D;
...
    // Prepare a path to a source SVG file
    string documentPath = Path.Combine(DataDir, "flower1.svg");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "flower-options.bmp");
    
    // Initialize an SVG document from the file
    using var document = new SVGDocument(documentPath);
    
    // Initialize ImageSaveOptions. Set up the SmoothingMode, resolutions, and change the background color to AliceBlue 
    var options = new ImageSaveOptions(ImageFormat.Bmp)
    {
        HorizontalResolution = 200,
        VerticalResolution = 200,
        BackgroundColor = Color.AliceBlue,
        SmoothingMode = SmoothingMode.HighQuality
    };           
    
    // Convert SVG to BMP
    Converter.ConvertSVG(document, options, savePath);
{{< /highlight >}}

The [ImageSaveOptions()](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initializes an instance of the ImageSaveOptions class that is passed to ConvertSVG() method. The ConvertSVG() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the above example, we use:
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - SmoothingMode property that sets the rendering quality for this image.

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting SVG to Image formats. Among these properties, SmoothingMode that enables you to set the rendering quality for the image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. You can select any value, considering the advantages and disadvantages of each one. To learn more about [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

The figure illustrates the fragment of the flower-options.bmp file.

![Text ""flower-options" image"](../flower-options.png#center)



{{% alert color="primary" %}} 

Check the quality of SVG to BMP conversion with our online [**SVG to BMP Converter**](https://products.aspose.app/svg/conversion/svg-to-bmp). Upload, convert your files and get results in a few seconds. Try our forceful SVG to BMP Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}







