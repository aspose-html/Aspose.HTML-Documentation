---
title: SVG Converter | C#
linktitle: SVG Converter
keywords: svg converter, convert svg, svg to pdf, svg to jpg, svg to docx, svg
  to png, svg to bmp, svg to gif, svg to tiff
description: In this article, you find out the supported SVG conversions and consider C# examples to illustrate them.
weight: 40
type: docs
url: /net/converting-between-formats/svg-converter/
lastmod: 2021-11-10
---

{{%SVG%}} files are Scalable Vector Graphics Files that use XML based text format for describing the appearance of an image. The word Scalable refers to the fact that SVG can be scaled to different sizes without losing any quality. A text-based description of such files makes them independent of resolution. It is one of the most used formats for website building and print graphics to achieve scalability.

The main highlight of Aspose.HTML is the conversion feature. Converting between formats is required for various reasons: to work in a familiar, convenient format or to take advantage of different formats for specific tasks. The [Aspose.Html.Converters](https://apireference.aspose.com/html/net/aspose.html.converters) namespace implements easy access to conversion methods. It provides a wide range of SVG conversions to popular formats, such as {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}.

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}} 

The articles in this section provide information on the list of supported SVG conversions and how to perform them using  [ConverterSVG()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertsvg/index) methods.  It can be different scenarios, but any SVG conversion can be made with a few required steps: 

1. Load an SVG document. You can load SVG from a file, SVG code, stream, or URL.
2. Create a Save Options object. You may customize the rendering process to get the desired result.
3. Invoke one of the [ConvertSVG()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertsvg/index) methods and pass the required parameters to it.

Please take a look over the following C# code snippet, which shows the process of converting SVG to PNG with ImageSaveOptions specifying:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System.Drawing;
using System.Drawing.Drawing2D;
...  

    // Prepare a path to a source SVG file
    string documentPath = Path.Combine(DataDir, "flower1.svg");
    
    // Prepare a path for converted file saving 
    string outputPath = Path.Combine(OutputDir, "flower-options.png");
    
    // Initialize an SVG document from the file
    using var document = new SVGDocument(documentPath);
    
    // Initialize ImageSaveOptions. Set up the SmoothingMode and change the background color to AliceBlue 
    var options = new ImageSaveOptions()
    {
        BackgroundColor = Color.AliceBlue,
        SmoothingMode = SmoothingMode.HighQuality,
    };            
    
    // Convert SVG to PNG
    Converter.ConvertSVG(document, options, outputPath);
{{< /highlight >}} 

In the example, the [SVGDocument(`address`)](https://apireference.aspose.com/html/net/aspose.html.dom.svg/svgdocument/constructors/10) constructor initializes an SVG document from the file. The ImageSaveOptions() constructor creates a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with PNG ImageFormat,  SmoothingMode and BackgroundColor properties. By default, the Format property is PNG. Then, the [ConvertSVG()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/3) method takes SVGDocument,  ImageSaveOptionss, and output path and performs SVG to PNG conversion.

{{% alert color="primary" %}} 
Aspose.HTML offers free online [**SVG Converters**](https://products.aspose.app/svg/en/conversion) for converting SVG files to a variety of popular formats. You can easily convert  [SVG to PDF](https://products.aspose.app/svg/en/conversion/svg-to-pdf), SVG to XPS, [SVG to JPG](https://products.aspose.app/svg/en/conversion/svg-to-jpg), [SVG to PNG](https://products.aspose.app/svg/en/conversion/svg-to-png), SVG to BMP, SVG to TIFF, or SVG to GIF. Just select the file, choose the format to convert, and you're done. It's fast and completely free!
{{% /alert %}} 

