---
title: Convert SVG to TIFF | C#
linktitle: Convert SVG to TIFF
keywords: svg to tiff, convert svg to tiff, svg to tiff conversion, svg to tiff converter, c# code, online converter
description: Convert SVG to TIFF in C# using Aspose.HTML API. Consider various SVG to TIFF conversion scenarios in C# examples. Try online SVG Converter.
weight: 60
type: docs
url: /net/converting-between-formats/svg-to-tiff/
lastmod: 2022-07-28
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

With Aspose.HTML, you can convert SVG to TIFF format programmatically with full control over a wide range of conversion parameters. In this article, you find information on how to convert SVG to {{%TIFF%}} by using [ConvertSVG()](https://reference.aspose.com/html/net/aspose.html.converters/converter/methods/convertsvg/index) methods of the Converter class and how to apply  [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions).  Also, you can try an Online SVG Converter to test the Aspose.HTML API functionality and convert SVG on the fly.

## **Online SVG Converter**

You can convert SVG to other formats with Aspose.HTML API in real time. Please load SVG from the local file system, select the output format and run the example. The save options are set by default. You will immediately receive the conversion result as a separate file.

{{< app/svg/converter SVG TIFF BMP PDF "JPG|JPEG" GIF XPS PNG DOCX>}}
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
{{#if_output 'BMP' 'JPG' 'GIF' 'PNG' 'TIFF'}}
    var options = new ImageSaveOptions(ImageFormat.{{output param2 camel}});
{{/if_output}}
    Converter.ConvertSVG(document, options, "output.{{output lower}}");
{{< /app/svg/converter>}}

If you want to convert SVG to TIFF  image programmatically, please see the following C# code examples.

## **SVG to TIFF by a single line of code**

The static methods of the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter) class are primarily used as the easiest way to convert an SVG file into various formats. You can convert SVG to TIFF in your C# application literally with a single line of code!

In the following example, we take an SVG file in a local file system ([shapes.svg](/html/net/converting-between-formats/svg-to-jpg/shapes.svg)), convert and save it in the local file system.

{{< highlight java >}}
using System.IO;

using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
     // Invoke the ConvertSVG method for SVG to TIFF conversion          
     Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new ImageSaveOptions(ImageFormat.Tiff), Path.Combine(OutputDir, "convert-with-single-line.tiff"));
{{< /highlight >}}

## **Convert SVG to TIFF**
Converting a file to another format using the ConvertSVG() method is a sequence of operations among which document loading and saving. In the following example, we create an SVG file from code. 

1. Prepare code for an SVG document.
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with TIFF ImageFormat. By default, the Format property is [PNG](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertSVG(`content`, `baseUri`, `options`, `outputPath`)](https://reference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/51) method of the Converter class to save SVG as a TIFF image. 

Please take a look over the following C# code snippet which shows the process of converting SVG to TIFF using Aspose.HTML for .NET.

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
    string savePath = Path.Combine(OutputDir, "circle.tiff");
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Tiff);
    
    // Convert SVG to TIFF
    Converter.ConvertSVG(code, ".", options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Convert SVG to TIFF using ImageSaveOptions**

To convert SVG to TIFF with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an SVG file using one of the SVGDocument() constructors of the [SVGDocument](https://reference.aspose.com/html/net/aspose.html.dom.svg/svgdocument) class. ([gradient.svg](/net/converting-between-formats/svg-to-gif/gradient.svg)). 
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with TIFF ImageFormat and specify save options. By default, the Format property is [PNG](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertSVG()](https://reference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/3) method to save SVG as a TIFF image. You need to pass the SVGDocument, ImageSaveOptions, and output file path to the ConvertSVG() method to convert SVG to TIFF.

The following C# code snippet shows how to convert SVG to TIFF using custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System.Drawing;
...
    // Prepare a path to a source SVG file
    string documentPath = Path.Combine(DataDir, "gradient.svg");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "gradient-options.tiff");
    
    // Initialize an SVG document from the file
    using var document = new SVGDocument(documentPath);
    
    // Initialize ImageSaveOptions. Set up the compression, resolutions, and change the background color to AliceBlue 
    var options = new ImageSaveOptions(ImageFormat.Tiff)
    {
        Compression = Compression.None,
        HorizontalResolution = 200,
        VerticalResolution = 200,
        BackgroundColor = Color.AliceBlue                
    };
    
    // Convert SVG to TIFF
    Converter.ConvertSVG(document, options, savePath);
{{< /highlight >}}

The [ImageSaveOptions()](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initializes an instance of the ImageSaveOptions class that is passed to ConvertSVG() method. The ConvertSVG() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the example, we use:
 - Compression property that sets TIFF compression. We use None compression schema. By default, this property is [LZW](https://reference.aspose.com/html/net/aspose.html.rendering.image/compression).
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent.
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi.

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting SVG to Image formats. Among these properties, the Compression that enables you to set a compression value for TIFF images.  Available values are LVZ, CCITT3, CCITT4, Rle, and None. To learn more about [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.



The figure illustrates the fragment of the gradient-options.tiff file.

![Text "gradient-options image"](../gradient-options.png#center)



{{% alert color="primary" %}} 
Check the quality of SVG to TIFF conversion with our online [**SVG to TIFF Converter**](https://products.aspose.app/svg/conversion/svg-to-tiff). Upload, convert your files and get results in a few seconds. Try our forceful SVG to TIFF Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

<a href="https://products.aspose.app/svg/conversion/svg-to-tiff" target="_blank">![Text "Banner SVG to TIFF Converter"](svg-to-tiff.png#center)</a>







