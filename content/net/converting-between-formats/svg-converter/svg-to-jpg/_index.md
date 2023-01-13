---
keywords: svg to jpg, convert svg to jpg, svg to jpg conversion, svg to jpg converter, save options, c# code, online converter
lastmod: 2022-07-28
url: /net/converting-between-formats/svg-to-jpg/
title: Convert SVG to JPG | C#
linktitle: Convert SVG to JPG
description: Convert SVG to JPG in C# using Aspose.HTML API. Consider various SVG to JPG conversion scenarios in C# examples. Try online SVG Converter.
weight: 20
type: docs
aliases:
  - /net/svg-to-image-conversion/
  - /net/converting-between-formats/svg-to-image-conversion/
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

JPG files can contain high-quality image data with lossless compression. This unique compression feature allows to quickly and efficiently share JPG images and use them widely on the Web, computers, and mobile devices. Using [ConvertSVG()](https://reference.aspose.com/html/net/aspose.html.converters/converter/convertsvg/) methods is the most common way to convert SVG into various formats. With Aspose.HTML, you can convert SVG to JPG format programmatically with full control over a wide range of conversion parameters. 

In this article, you find information on how to convert SVG to {{%JPG%}} using ConvertSVG() methods of the Converter class and how to apply [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/) and [ICreateStreamProvider](https://reference.aspose.com/html/net/aspose.html.io/icreatestreamprovider/) parameters.  Also, you can try an Online SVG Converter to test the Aspose.HTML API functionality and convert SVG on the fly.

## **Online SVG Converter**

You can convert SVG to other formats with Aspose.HTML API in real time. Please load SVG from the local file system, select the output format and run the example. The save options are set by default. You will immediately receive the conversion result as a separate file.

{{< app/svg/converter SVG "JPG|JPEG" BMP GIF XPS TIFF PNG DOCX PDF>}}
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

If you want to convert SVG to JPG image programmatically, please see the following C# code examples.

## **SVG to JPG by a single line of code**

The static methods of the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter/) class are primarily used as the easiest way to convert an SVG file into various formats. You can convert SVG to JPG in your C# application literally with a single line of code!

In the following example, we take an SVG file in a local file system ([shapes.svg](/html/net/converting-between-formats/svg-to-jpg/shapes.svg)), convert and save it in the local file system.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
     // Invoke the ConvertSVG method for SVG to JPG conversion          
     Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new ImageSaveOptions(ImageFormat.Jpeg), Path.Combine(OutputDir, "convert-with-single-line.jpg"));
{{< /highlight >}}

## **Convert SVG to JPG in C#**
Converting a file to another format using the ConvertSVG() method is a sequence of operations among which document loading and saving. In the following example, we create an SVG file from code. 

1. Prepare code for an SVG document.
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/) object with JPG ImageFormat. By default, the Format property is [PNG](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat/).
1. Use the [ConvertSVG(`content`,`baseUri`, `options`, `outputPath`)](https://reference.aspose.com/html/net/aspose.html.converters/converter/convertsvg/) method of the Converter class to save SVG as a JPG image. 

Please take a look over the following C# code snippet which shows the process of converting SVG to JPG using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Prepare SVG code 
    var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
               "<circle cx ='100' cy ='100' r ='55' fill='green' stroke='red' stroke-width='10' />" +
               "</svg>";

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "circle.jpg");
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Jpeg);
    
    // Convert SVG to JPG
    Converter.ConvertSVG(code, ".", options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Save Options**
Aspose.HTML allows converting SVG to JPG using default or custom save options. [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/) usage enables you to customize the rendering process. You can specify the image format, page size, margins, background color, etc. 

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



## **Convert SVG to JPG using ImageSaveOptions**

To convert SVG to JPG with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an SVG file using one of the SVGDocument() constructors of the [SVGDocument](https://reference.aspose.com/html/net/aspose.html.dom.svg/svgdocument/) class. ([flower.svg](/html/net/converting-between-formats/svg-to-jpg/flower.svg)). 
1. Create a new [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/) object with JPG ImageFormat and specify save options. By default, the Format property is [PNG](https://reference.aspose.com/html/net/aspose.html.rendering.image/imageformat/).
1. Use the [ConvertSVG()](https://reference.aspose.com/html/net/aspose.html.converters/converter/convertsvg/) method to save SVG as a JPG image. You need to pass the SVGDocument, ImageSaveOptions, and output file path to the ConvertSVG() method to convert SVG to JPG.

The following C# code snippet shows how to convert SVG to JPG using custom save options:

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
    string documentPath = Path.Combine(DataDir, "flower.svg");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "flower-options.jpg");
    
    // Initialize an SVG document from the file
    using var document = new SVGDocument(documentPath);
    
    // Initialize ImageSaveOptions. Set up the resolutions, SmoothingMode and change the background color to AliceBlue 
    var options = new ImageSaveOptions(ImageFormat.Jpeg)
    {
        SmoothingMode = SmoothingMode.HighQuality,
        HorizontalResolution = 200,
        VerticalResolution = 200,
        BackgroundColor = System.Drawing.Color.AliceBlue                
    };          
    
    // Convert SVG to JPG
    Converter.ConvertSVG(document, options, savePath);
{{< /highlight >}}

The [ImageSaveOptions()](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/imagesaveoptions/) constructor initializes an instance of the ImageSaveOptions class that is passed to ConvertSVG() method. The ConvertSVG() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the above example, we use:
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - SmoothingMode property that sets the rendering quality for this image.

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting SVG to Image formats. Among these properties, SmoothingMode that enables you to set the rendering quality for the image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. You can select any value, considering the advantages and disadvantages of each one.

The figure illustrates the fragment of the flower-options.jpg file.

![Text "Flower JPG image"](flower-options.jpg#center)

## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement the [ICreateStreamProvider](https://reference.aspose.com/html/net/aspose.html.io/icreatestreamprovider/) interface to have manual control over the file creating process. This interface is designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering the document/page.

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
using System.Linq;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Create an instance of MemoryStreamProvider
    using var streamProvider = new MemoryStreamProvider();

    // Prepare SVG code
    var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
               "<circle cx='50' cy='50' r='40' stroke='black' stroke-width='3' fill='red' />" +
               "</svg>";
    
    // Convert SVG to JPG using the MemoryStreamProvider
    Converter.ConvertSVG(code, ".", new ImageSaveOptions(ImageFormat.Jpeg), streamProvider);
    
    // Get access to the memory stream that contains the result data
    var memory = streamProvider.Streams.First();
    memory.Seek(0, SeekOrigin.Begin);
    
    // Flush the result data to the output file
    using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.jpg")))
    {
        memory.CopyTo(fs);
    }
{{< /highlight >}}

{{% alert color="primary" %}}
Check the quality of SVG to JPG conversion with our online [**SVG to JPG Converter**](https://products.aspose.app/svg/conversion/svg-to-jpg). Upload, convert your files and get results in a few seconds. Try our forceful SVG to JPG Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

<a href="https://products.aspose.app/svg/conversion/svg-to-jpg" target="_blank">![Text "Banner SVG to JPG Converter"](svg-to-jpg.png#center)</a>







