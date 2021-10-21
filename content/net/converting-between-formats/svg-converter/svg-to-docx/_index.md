---
title: Convert SVG to DOCX | C#
linktitle: Convert SVG to DOCX
keywords: svg to docx, convert svg to docx, svg to docx conversion, svg to docx converter
description: This article provides information on how to convert SVG to DOCX
  using Aspose.HTML API. You will learn about the supported SVG to DOCX
  conversion scenarios and consider examples to illustrate them.
weight: 40
type: docs
url: /net/converting-between-formats/svg-to-docx/
lastmod: 2021-09-03
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

A DOCX format is popular because of the variety of options it offers users to write any type of documents. This file format is one of the most widely used and is available through numerous programs. With Aspose.HTML, you can convert SVG to DOCX format programmatically. In this article, you find information on how to convert SVG to {{%DOCX%}} by using [ConvertSVG()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertsvg/index) methods of the Converter class and applying  [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions).

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/svg/en/conversion/svg" target="_blank">**SVG Converter**</a> that converts SVG files to a variety of popular formats with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/svg/en/conversion/svg" target="_blank">![Text "Banner SVG Converter"](svg.png#center)</a>

## **SVG to DOCX by a single line of code**

The static methods of the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class are primarily used as the easiest way to convert an SVG file into various formats. You can convert SVG to DOCX in your C# application literally with a single line of code!

In the following example, we take an SVG file in a local file system ([shapes.svg](/html/net/converting-between-formats/svg-to-jpg/shapes.svg)), convert and save it in the local file system.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Invoke the ConvertSVG method to convert SVG to DOCX           
     Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new DocSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.docx"));
{{< /highlight >}}

## **Convert SVG to DOCX**
Converting a file to another format using the ConvertSVG() method is a sequence of operations among which document loading and saving. In the following example, we create an SVG file from code. 

1. Prepare code for an SVG document.
1. Create a new [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions) object. 
1. Use the [ConvertSVG(`content`, `baseUri`, `options`, `outputPath`)](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/49) method of the Converter class to save SVG as a DOCX file. 

Please take a look over the following C# code snippet which shows the process of converting SVG to DOCX using Aspose.HTML for .NET.

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
    string savePath = Path.Combine(OutputDir, "circle.docx");
    
    // Initialize DocSaveOptions 
    var options = new DocSaveOptions();
    
    // Convert SVG to DOCX
    Converter.ConvertSVG(code, ".", options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Convert SVG to DOCX using DocSaveOptions**

To convert SVG to DOCX with DocSaveOptions specifying, you should follow a few steps: 

1. Load an SVG file using one of the SVGDocument() constructors of the [SVGDocument](https://apireference.aspose.com/html/net/aspose.html.dom.svg/svgdocument) class.
1. Create a new [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions) object and specify save options.
1. Use the [ConvertSVG()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/1) method to save SVG as a DOCX file. You need to pass the SVGDocument, DocSaveOptions, and output file path to the ConvertSVG() method to convert SVG to DOCX.

The following C# code snippet shows how to convert SVG to DOCX using custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System.Drawing;
...
     // Prepare a path to a source SVG file
     string documentPath = Path.Combine(DataDir, "shapes.svg");

     // Prepare a path for converted file saving 
     string savePath = Path.Combine(OutputDir, "shapes-options.docx");
    
     // Initialize an SVG document from the file
     using var document = new SVGDocument(documentPath);
    
     // Initialize DocSaveOptions. Set up the page-size and margins 
     var options = new DocSaveOptions();            
     options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(500, 500), new Margin(30, 10, 10, 10));
    
     // Convert SVG to DOCX
     Converter.ConvertSVG(document, options, savePath);
{{< /highlight >}}

The [DocSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions/constructors/main) constructor initializes an instance of the DocSaveOptions class that is passed to ConvertSVG() method. The ConvertSVG() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.  In the example, we use the PageSetup property that specifies the page size of the DOCX document. To learn more about [DocSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/docsaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

{{% alert color="primary" %}} 

Check the quality of SVG conversion with our online [**SVG Converter**](https://products.aspose.app/svg/en/conversion/svg). Upload, convert your files and get results in a few seconds. Try our forceful SVG Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}







