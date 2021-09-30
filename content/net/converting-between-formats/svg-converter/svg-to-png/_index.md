---
title: Convert SVG to PNG | C#
linktitle: Convert SVG to PNG
keywords: svg to png, convert svg to png, svg to png conversion, svg to png
  converter, save options
description: This article provides information on how to convert SVG to PNG
  using Aspose.HTML API. You will learn about the supported SVG to PNG
  conversion scenarios and consider examples to illustrate them.
weight: 30
type: docs
url: /net/converting-between-formats/svg-to-png/
lastmod: 2021-09-03
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

PNG file format supports lossless image compression that makes it popular among its users. It has two major uses: the World Wide Web and image-editing. It widely takes to transmit pictures over the network, display photos and graphics on web pages and reserve in cloud storages. There are some restrictions on SVG usage on web pages, so conversion SVG to PNG is sometimes necessary. With Aspose.HTML, you can convert SVG to PNG format programmatically with full control over a wide range of conversion parameters. 

In this article, you find information on SVG to {{%PNG%}} conversion by using [ConvertSVG()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertsvg/index) methods of the Converter class and applying  [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/svg/en/conversion/svg-to-png" target="_blank">**SVG to PNG Converter**</a> that converts SVG to PNG image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/svg/en/conversion/svg-to-png" target="_blank">![Text "Banner SVG to PNG Converter"](svg-to-png.png#center)</a>

## **SVG to PNG by a single line of code**

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an SVG file into various formats. You can convert SVG to PNG in your C# application literally with a single line of code!

In the following example, we take an SVG file in a local file system ([shapes.svg](/html/net/converting-between-formats/svg-to-jpg/shapes.svg)), convert and save it in the local file system.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
     // Invoke the ConvertSVG method for SVG to PNG conversion          
     Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new ImageSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.png"));
{{< /highlight >}}

## **Convert SVG to PNG**
Converting a file to another format using the ConvertSVG() method is a sequence of operations among which document loading and saving. In the following example, we create an SVG file from code. 

1. Prepare code for an SVG document.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) object. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertSVG(`content`, `baseUri`, `options`, `outputPath`)](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/51) method of the Converter class to save SVG as a PNG image. 

Please take a look over the following C# code snippet which shows the process of converting SVG to PNG using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Prepare SVG code 
    var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
               "<circle cx ='100' cy ='100' r ='60' fill='none' stroke='red' stroke-width='10' />" +
               "</svg>";

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "circle.png");
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions();
    
    // Convert SVG to PNG
    Converter.ConvertSVG(code, ".", options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Save Options**
Aspose.HTML allows converting SVG to PNG using default or custom save options. [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) usage enables you to customize the rendering process. You can specify the image format, page size, margins, background color, etc. 

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



## **Convert SVG to PNG using ImageSaveOptions**

To convert SVG to PNG with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an SVG file using one of the SVGDocument() constructors of the [SVGDocument](https://apireference.aspose.com/net/html/aspose.html.dom.svg/svgdocument) class. ([flower1.svg](/html/net/converting-between-formats/svg-to-png/flower1.svg)). 
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/imagesaveoptions) object and specify save options. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertSVG()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/3) method to save SVG as a PNG image. You need to pass the SVGDocument, ImageSaveOptions, and output file path to the ConvertSVG() method to convert SVG to PNG.

The following C# code snippet shows how to convert SVG to PNG using custom save options:

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
     string savePath = Path.Combine(OutputDir, "flower-options.png");
    
     // Initialize an SVG document from the file
     using var document = new SVGDocument(documentPath);
    
     // Initialize ImageSaveOptions. Set up the SmoothingMode, resolutions, and change the background color to AliceBlue 
     var options = new ImageSaveOptions()
     {
         HorizontalResolution = 200,
         VerticalResolution = 200,
         BackgroundColor = Color.AliceBlue,
         SmoothingMode = SmoothingMode.HighQuality,
     };            
    
     // Convert SVG to PNG
     Converter.ConvertSVG(document, options, savePath);
{{< /highlight >}}

The [ImageSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initialize an instance of the ImageSaveOptions class that is passed to ConvertSVG() method. The ConvertSVG() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the above example, we use:
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - SmoothingMode property that sets the rendering quality for this image.

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting SVG to Image formats. Among these properties, SmoothingMode that enables you to set the rendering quality for the image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. You can select any value, considering the advantages and disadvantages of each one.

The figure illustrates the fragment of the flower-options.png file.

![Text ""Flower" PNG image"](../flower-options.png#center)

## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement the [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) interface to have manual control over the file creating process. This interface is designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering the document/page.

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
    
    // Convert SVG to PNG using the MemoryStreamProvider
    Converter.ConvertSVG(code, ".", new ImageSaveOptions(), streamProvider);
    
    // Get access to the memory stream that contains the result data
    var memory = streamProvider.Streams.First();
    memory.Seek(0, SeekOrigin.Begin);
    
    // Flush the result data to the output file
    using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.png")))
    {
        memory.CopyTo(fs);
    }
{{< /highlight >}}

{{% alert color="primary" %}} 

Check the quality of SVG to PNG conversion with our online [**SVG to PNG Converter**](https://products.aspose.app/svg/en/conversion/svg-to-png). Upload, convert your files and get results in a few seconds. Try our forceful SVG to PNG Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}







