---
title: Convert Markdown to XPS | C#
linktitle: Convert Markdown to XPS
type: docs
weight: 40
url: /net/converting-between-formats/markdown-to-xps/
description: Convert Markdown to XPS in C# using Aspose.HTML API. Consider various Markdown to XPS conversion scenarios in C# examples. Try online Markdown Converter. 
keywords: Markdown to XPS, convert Markdown to XPS, Markdown to XPS conversion, Markdown to XPS converter, c# code, online converter
lastmod: "2022-07-28"
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{%Markdown%}} is a markup language with a plain-text-formatting syntax. Markdown is often used as a format for documentation and readme files since it allows writing in an easy-to-read and easy-to-write style. Its design allows it to be easily converted to many output formats, but initially, it was created to convert only to HTML. Using the Aspose.HTML class library in your C# application, you can easily convert Markdown into an XPS file with just a few lines of code!

## **Online Markdown Converter**

You can convert Markdown to other formats with Aspose.HTML for .NET API in real time. Please load a Markdown file from the local file system, select the output format and run the example.  The save options are set by default. You will immediately receive the conversion result as a separate file.

{{< app/html/converter MD XPS "JPG|JPEG" GIF BMP TIFF PNG PDF DOCX >}}
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;

    using var document = Converter.ConvertMarkdown("input.md");
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
    Converter.ConvertHTML(document, options, "output.{{output lower}}");
{{< /app/html/converter>}}

If you want to convert Markdown to XPS programmatically, please see the following C# code examples.

## **Convert Markdown to XPS in C#**

Conversions from Markdown to other formats go through the Markdown to HTML conversion stage. If your scenario is required rendering Markdown document, for instance, to the XPS file format, the following example demonstrates how that is simple: 

1. Prepare a source Markdown document. In the example, we create a Markdown file from code. 
1. Prepare a path for converted file saving. 
1. Convert Markdown to HTML. Use the [ConvertMarkdown(`sourcePath`)](https://reference.aspose.com/html/net/aspose.html.converters/converter/convertmarkdown/) method to save Markdown as an HTML document. 
1. Use the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) method to render the intermediary HTML document to XPSformat. You need to pass the HTMLDocument, XpsSaveOptions, and output file path to the ConvertHTML() method for HTML to XPS conversion.

If your case is to create a Markdown document from a user string directly in your code and convert it to an XPS file, the following example could help you: 

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
    // Prepare a path to a source Markdown file
     string sourcePath = Path.Combine(OutputDir, "document.md");

     // Prepare a simple Markdown example
     var code = "### Hello, World!" +
                "\r\n" +
                "[visit applications](https://products.aspose.app/html/family)";
     // Create a Markdown file
     File.WriteAllText(sourcePath, code);
    
     // Prepare a path for converted file saving 
     string savePath = Path.Combine(OutputDir, "document-output.xps");
    
     // Convert Markdown to HTML 
     using var document = Converter.ConvertMarkdown(sourcePath);
    
     // Convert HTML to XPS file format
     Converter.ConvertHTML(document, new XpsSaveOptions(), savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

## **Convert Markdown to XPS using XpsSaveOptions**
If your case is to convert an existing Markdown document from a local file system, the following example could help you. You need to follow a few steps:

1. Open an existing Markdown document. In the example, we load a Markdown file from a local file system ([nature.md](https://github.com/aspose-html/Aspose.HTML-Documentation/blob/main/content/tests-net/tests-data/nature.md)). 
1. Prepare a path for converted XPS file saving. 
1. Convert Markdown to HTML. Use the [ConvertMarkdown(`sourcePath`)](https://reference.aspose.com/html/net/aspose.html.converters/converter/convertmarkdown/) method of the Converter class to save Markdown as an HTML document. 
1. Create a new [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/) object and specify the required properties.
1. Use the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) method for HTML to XPS conversion. You need to pass the HTMLDocument, XpsSaveOptions, and output file path to the ConvertHTML() method.

The following code snippet shows how to convert Markdown to XPS using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html.Drawing;
using System.Drawing;
...
    // Prepare a path to a source Markdown file
    string sourcePath = Path.Combine(DataDir, "nature.md");

    // Prepare a path for converted PDF file saving 
    string savePath = Path.Combine(OutputDir, "nature-output.xps");
    
    // Convert Markdown to HTML
    using var document = Converter.ConvertMarkdown(sourcePath);
    
    // Initialize XpsSaveOptions. Set up the resilutions, page-size, margins and change the background color to AntiqueWhite 
    var options = new XpsSaveOptions()
    {
        HorizontalResolution = 200,
        VerticalResolution = 200,
        BackgroundColor = System.Drawing.Color.AntiqueWhite
    };
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(Length.FromInches(5.0f), Length.FromInches(10.0f)), new Margin(30, 20, 10, 10));
    
    // Convert the HTML document to XPS file format
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

The XpsSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting Markdown to XPS format. To learn more about [XpsSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/xpssaveoptions/), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

In the example, we use:

 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi;
 - PageSetup property that specifies the [page size](https://reference.aspose.com/html/net/aspose.html.rendering/renderingoptions/pagesetup/) and [margins](https://reference.aspose.com/html/net/aspose.html.drawing/page/margin/).

{{% alert color="primary" %}} 
You can check the quality of Markdown to XPS conversion with our online [**MD to XPS Converter**](https://products.aspose.app/html/conversion/md-to-xps). Upload, convert your files and get results in a few seconds. Try our forceful Markdown to XPS Converter for free now!
{{% /alert %}}

<a href="https://products.aspose.app/html/conversion/md-to-xps" target="_blank">![Text "Banner MD to XPS Converter"](md-to-xps.png#center)</a>
