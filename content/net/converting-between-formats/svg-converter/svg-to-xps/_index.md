---
keywords: svg to xps, convert svg to xps, svg to xps conversion, svg to xps converter, save options, c# code, online converter
lastmod: 2022-07-28
url: /net/converting-between-formats/svg-to-xps/
title: Convert SVG to XPS | C#
linktitle: Convert SVG to XPS
description: Convert SVG to XPS in C# using Aspose.HTML API. Consider various SVG to XPS conversion scenarios in C# examples. Try online SVG Converter.
weight: 70
type: docs
aliases:
  - /net/svg-to-xps-conversion/
  - /net/converting-between-formats/svg-to-xps-conversion/
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

XPS is a document storage and viewing format developed by Microsoft. An XPS file has a set of advantages that support security features, such as digital signatures to provide greater document security and more. With Aspose.HTML, you can convert SVG to XPS format programmatically with full control over a wide range of conversion parameters. 

In this article, you find information on how to convert SVG to {{%XPS%}} using [ConvertSVG()](https://reference.aspose.com/html/net/aspose.html.converters/converter/convertsvg/) methods of the Converter class and how to apply  [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/) and [ICreateStreamProvider](https://reference.aspose.com/html/net/aspose.html.io/icreatestreamprovider/) parameters.  Also, you can try an Online SVG Converter to test the Aspose.HTML API functionality and convert SVG on the fly.

## **Online SVG Converter**

You can convert SVG to other formats with Aspose.HTML API in real time. Please load SVG from the local file system, select the output format and run the example. The save options are set by default. You will immediately receive the conversion result as a separate file.

{{< app/svg/converter SVG XPS PDF "JPG|JPEG" GIF BMP TIFF PNG DOCX>}}
using Aspose.Html;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Converters;
using Aspose.Html.Saving;

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

If you want to convert SVG to XPS file programmatically, please see the following C# code examples.

## **SVG to XPS by a single line of code**

The static methods of the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter/) class are primarily used as the easiest way to convert an SVG file into various formats. You can convert SVG to XPS in your C# application literally with a single line of code!

In the following example, we take an SVG file in a local file system ([shapes.svg](/html/net/converting-between-formats/svg-to-jpg/shapes.svg)), convert and save it in the local file system.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Invoke the ConvertSVG method for SVG to XPS conversion          
     Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new XpsSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.xps"));
{{< /highlight >}}

## **Convert SVG to XPS**
Converting a file to another format using the ConvertSVG() method is a sequence of operations among which document loading and saving. In the following example, we create an SVG file from code. 

1. Prepare code for an SVG document.
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/) object.
1. Use the [ConvertSVG(`content`, `baseUri`, `options`, `outputPath`)](https://reference.aspose.com/html/net/aspose.html.converters/converter/convertsvg/) method of the Converter class to save SVG as an XPS file. 

Please take a look over the following C# code snippet which shows the process of converting SVG to XPS using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Prepare SVG code 
    var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
               "<circle cx ='100' cy ='100' r ='60' fill='green' stroke='red' stroke-width='10' />" +
               "</svg>";

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "circle.xps");
    
    // Initialize XpsSaveOptions 
    var options = new XpsSaveOptions();
    
    // Convert SVG to XPS
    Converter.ConvertSVG(code, ".", options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Save Options**
Aspose.HTML allows converting SVG to XPS using default or custom save options. [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/) usage enables you to customize the rendering process; you can specify the page size, margins, background color, etc. 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [PageSetup](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/) | This property gets a page setup object and uses it for configuration output page-set. |
| [Css](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/css/) | Gets a [CssOptions](https://reference.aspose.com/html/net/aspose.html.rendering/cssoptions/) object which is used for configuration of CSS properties processing. |
| [BackgroundColor](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/backgroundcolor/) | This property sets the color that will fill the background of every page. By default, this property is Transparent. |
| [HorizontalResolution](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/horizontalresolution/) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://reference.aspose.com/html/net/aspose.html.rendering.image/imagerenderingoptions/verticalresolution/) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |

## **Convert SVG to XPS using XpsSaveOptions**

To convert SVG to XPS with XpsSaveOptions specifying, you should follow a few steps: 

1. Load an SVG file using one of the SVGDocument() constructors of the [SVGDocument](https://reference.aspose.com/html/net/aspose.html.dom.svg/svgdocument/) class. ([aspose.svg](/html/net/converting-between-formats/svg-to-pdf/aspose.svg)). 
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/) object and specify save options. 
1. Use the [ConvertSVG()](https://reference.aspose.com/html/net/aspose.html.converters/converter/convertsvg/) method to save SVG as an XPS file. You need to pass the SVGDocument, XpsSaveOptions, and output file path to the ConvertSVG() method for SVG to XPS conversion.

The following C# code snippet shows how to convert SVG to XPS using custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Drawing;
using System.Drawing;
...
    // Prepare a path to a source SVG file
    string documentPath = Path.Combine(DataDir, "aspose.svg");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "aspose-options.xps");
    
    // Initialize an SVG document from the file
    using var document = new SVGDocument(documentPath);
    
    // Initialize XpsSaveOptions. Set up the page-size 500x500 pixels, margins, resolutions and change the background color to AliceBlue 
    var options = new XpsSaveOptions()
    {
        HorizontalResolution = 200,
        VerticalResolution = 200,
        BackgroundColor = Color.AliceBlue               
    };
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(500, 500), new Margin(30, 10, 10, 10));
    
    // Convert SVG to XPS
    Converter.ConvertSVG(document, options, savePath);
{{< /highlight >}}

The [XpsSaveOptions()](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/xpssaveoptions/) constructor initializes an instance of the XpsSaveOptions class that is passed to ConvertSVG() method. The ConvertSVG() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the above example, we use:
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent.
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi.
 - PageSetup property that specifies the [page size](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/) and [margins](https://reference.aspose.com/html/net/aspose.html.drawing/page/margin/).

The XpsSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting SVG to XPS format. To learn more about [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

The figure illustrates the aspose-options.xps file with specified page size, background color, etc.

![Text "Image of the Aspose logo"](../aspose-options.png#center)

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
using Aspose.Html.Saving;
...
    // Create an instance of MemoryStreamProvider
    using var streamProvider = new MemoryStreamProvider();

    // Prepare SVG code
    var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
               "<circle cx='50' cy='50' r='40' stroke='black' stroke-width='3' fill='red' />" +
               "</svg>";
    
    // Convert SVG to XPS using the MemoryStreamProvider
    Converter.ConvertSVG(code, ".", new XpsSaveOptions(), streamProvider);
    
    // Get access to the memory stream that contains the result data
    var memory = streamProvider.Streams.First();
    memory.Seek(0, SeekOrigin.Begin);
    
    // Flush the result data to the output file
    using (FileStream fs = File.Create(Path.Combine(OutputDir, "stream-provider.xps")))
    {
        memory.CopyTo(fs);
    }
{{< /highlight >}}

{{% alert color="primary" %}} 

Check the quality of SVG to XPS conversion with our online [**SVG to XPS Converter**](https://products.aspose.app/svg/conversion/svg-to-xps). Upload, convert your files and get results in a few seconds. Try our forceful SVG to XPS Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

<a href="https://products.aspose.app/svg/conversion/svg-to-xps" target="_blank">![Text "Banner SVG to XPS Converter"](svg-to-xps.png#center)</a>







