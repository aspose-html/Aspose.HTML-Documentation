---
title: Convert Markdown to PDF
type: docs
weight: 20
url: /net/converting-between-formats/markdown-to-pdf/
description: This article provides information on how to convert Markdown to PDF using the Aspose.HTML API. You will learn about the supported Markdown to PDF conversion scenarios and consider examples to illustrate them.  
keywords: markdown to pdf, convert markdown to pdf, markdown to pdf conversion, markdown to pdf converter
lastmod: "2021-09-03"
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{%Markdown%}} is a markup language with a plain-text-formatting syntax. Markdown is often used as a format for documentation and readme files since it allows writing in an easy-to-read and easy-to-write style. Its design allows it to be easily converted to many output formats, but initially, it was created to convert only to HTML. Using the Aspose.HTML class library in your C# application, you can easily convert Markdown into a PDF file with just a few lines of code!

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/md-to-pdf" target="_blank">**MD to PDF Converter**</a> that converts Markdown to PDF file with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/md-to-pdf" target="_blank">![Text "Banner MD to PDF Converter"](md-to-pdf.png#center)</a>

## **Convert Markdown to PDF**

If your scenario is required rendering Markdown document, for instance, to the PDF file format, the following example demonstrates how that is simple: 

1. Prepare a source Markdown document. In the example, we create a Markdown file from code. 
1. Prepare a path for converted file saving. 
1. Convert Markdown to HTML. Use the [ConvertMarkdown(`sourcePath`)](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmarkdown/methods/4) method to save Markdown as an HTML document. 
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/7) method to render the intermediary HTML document to PDF format. You need to pass the HTMLDocument, PdfSaveOptions, and output file path to the ConvertHTML() method for HTML to PDF conversion.

If your case is to create a Markdown document from a user string directly in your code and convert it to a PDF file, the following example could help you: 

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
    string savePath = Path.Combine(OutputDir, "document-output.pdf");
    
    // Convert Markdown to HTML document
    using var document = Converter.ConvertMarkdown(sourcePath);
    
    // Convert HTML document to PDF image file format
    Converter.ConvertHTML(document, new PdfSaveOptions(), savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Convert Markdown to PDF using PdfSaveOptions**
If your case is to convert an existing Markdown document from a local file system, the following example could help you. You need to follow a few steps:

1. Open an existing Markdown document. In the example, we load a Markdown file from a local file system ([nature.md](https://github.com/aspose-html/Aspose.HTML-Documentation/blob/oa_conversion/content/tests-net/tests-data/nature.md)). 
1. Prepare a path for converted PDF file saving. 
1. Convert Markdown to HTML. Use the [ConvertMarkdown(`sourcePath`)](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmarkdown/methods/4) method of the Converter class to save Markdown as an HTML document. 
1. Create a new [PdfSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/pdfsaveoptions) object and specify the required properties.
1. Use the [ConvertHTML()](https://apireference.aspose.com/net/html/aspose.html.converters.converter/converthtml/methods/7) method to render the intermediary HTML document to PDF format. You need to pass the HTMLDocument, PdfSaveOptions, and output file path to the ConvertHTML() method.

The following code snippet shows how to convert Markdown to PDF using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using System.Drawing;
...
    // Prepare a path to a source Markdown file
    string sourcePath = Path.Combine(DataDir, "nature.md");

    // Prepare a path for converted PDF file saving 
    string savePath = Path.Combine(OutputDir, "nature-output.pdf");
    
    // Convert Markdown to HTML document
    using var document = Converter.ConvertMarkdown(sourcePath);
    
    // Initialize PdfSaveOptions. Set up the resolutions, JpegQuality and change the background color to AliceBlue 
    var options = new PdfSaveOptions()
    {
        HorizontalResolution = 200,
        VerticalResolution = 200,
        BackgroundColor = Color.AliceBlue,
        JpegQuality = 100
    };            
    
    // Convert HTML document to PDF image file format
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

The PdfSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting Markdown to PDF format. To learn more about [PdfSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/pdfsaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.

In the above example, we use:

 - JpegQuality property that enables you to specify the quality of JPEG compression for images. The default value is 95;  
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent;
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi.


{{% alert color="primary" %}} 
You can check the quality of Markdown to PDF conversion with our online [**MD to PDF Converter**](https://products.aspose.app/html/en/conversion/md-to-pdf). Upload, convert your files and get results in a few seconds. Try our forceful Markdown to PDF Converter for free now!
{{% /alert %}}

