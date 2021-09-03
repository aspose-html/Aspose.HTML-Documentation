---
title: Convert SVG to GIF
type: docs
weight: 50
url: /net/converting-between-formats/svg-to-gif/
description: This article provides information on how to convert SVG to GIF using Aspose.HTML API. You will learn about the supported SVG to GIF conversion scenarios and consider examples to illustrate them.  
keywords: svg to gif, convert svg to gif, svg to gif conversion, svg to gif converter, save options
lastmod: "2021-09-03"
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

With Aspose.HTML, you can convert SVG to GIF format programmatically with full control over a wide range of conversion parameters. In this article, you find information on how to convert SVG to {{%GIF%}} by using [ConvertSVG()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertsvg/index) methods of the Converter class and applying  [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions).

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/svg/en/conversion/svg-to-gif" target="_blank">**SVG to GIF Converter**</a> that converts SVG to GIF image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/svg/en/conversion/svg-to-gif" target="_blank">![Text "Banner SVG to GIF Converter"](svg-to-gif.png#center)</a>

## **SVG to GIF by a single line of code**

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an SVG file into various formats. You can convert SVG to GIF in your C# application literally with a single line of code!

In the following example, we take an SVG file in a local file system ([shapes.svg](/net/converting-between-formats/svg-converter/svg-to-jpg/shapes.svg)), convert and save it in the local file system.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
     // Invoke the ConvertSVG method for SVG to GIF conversion          
     Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new ImageSaveOptions(ImageFormat.Gif), Path.Combine(OutputDir, "convert-with-single-line.gif"));
{{< /highlight >}}

## **Convert SVG to GIF**
Converting a file to another format using the ConvertSVG() method is a sequence of operations among which document loading and saving. In the following example, we create an SVG file from code. 

1. Prepare code for an SVG document.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) object with GIF ImageFormat. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertSVG (`content`,`baseUri`, `options`, `outputPath`)](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/51) method of the Converter class to save SVG as a GIF image. 

Please take a look over the following C# code snippet which shows the process of converting SVG to GIF using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Prepare SVG code 
    var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
               "<circle cx ='100' cy ='100' r ='55' fill='none' stroke='red' stroke-width='8' />" +
               "</svg>";

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "circle.gif");
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Gif);
    
    // Convert SVG to GIF
    Converter.ConvertSVG(code, ".", options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Convert SVG to GIF using ImageSaveOptions**

To convert SVG to GIF with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an SVG file using one of the SVGDocument() constructors of the [SVGDocument](https://apireference.aspose.com/net/html/aspose.html.dom.svg/svgdocument) class. ([gradient.svg](/net/converting-between-formats/svg-converter/svg-to-gif/gradient.svg)). 
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) object with GIF ImageFormat and specify save options. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertSVG ()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/3) method to save SVG as a GIF image. You need to pass the SVGDocument, ImageSaveOptions, and output file path to the ConvertSVG () method to convert SVG to GIF.

The following C# code snippet shows how to convert SVG to GIF using custom save options:

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
     string savePath = Path.Combine(OutputDir, "gradient-options.gif");
    
     // Initialize an SVG document from the file
     using var document = new SVGDocument(documentPath);
    
     // Initialize ImageSaveOptions. Set up the SmoothingMode, resolutions, and change the background color to AliceBlue 
     var options = new ImageSaveOptions(ImageFormat.Gif)
     {
         SmoothingMode = SmoothingMode.HighQuality,
         HorizontalResolution = 200,
         VerticalResolution = 200,
         BackgroundColor = Color.AliceBlue                
     };
    
     // Convert SVG to GIF
     Converter.ConvertSVG(document, options, savePath);
{{< /highlight >}}

The [ImageSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initialize an instance of the ImageSaveOptions class that is passed to ConvertSVG () method. The ConvertSVG () method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the example, we use:
 - SmoothingMode property that sets the rendering quality for this image. 
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent.
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi.

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting SVG to Image formats. To learn more about [ImageOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions), please read the [Fine-Tuning Converters](http://localhost:1313/html/net/fine-tuning-converters/) article.

The figure illustrates the fragment of the gradient-options.gif file.


![Text "gradient-options image"](../gradient-options.png#center)


{{% alert color="primary" %}} 

Check the quality of SVG to GIF conversion with our online [**SVG to GIF Converter**](https://products.aspose.app/svg/en/conversion/svg-to-gif). Upload, convert your files and get results in a few seconds. Try our forceful SVG to GIF Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}







