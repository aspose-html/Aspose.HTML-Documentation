---
title: Convert Markdown to DOCX | C#
type: docs
weight: 30
url: /net/converting-between-formats/markdown-to-docx/
description: This article provides information on how to convert Markdown to DOCX using the Aspose.HTML API. You will learn about the supported Markdown to DOCX conversion scenarios and consider examples to illustrate them.  
keywords: markdown to docx, convert markdown to docx, markdown to docx conversion, markdown to docx converter
lastmod: "2021-09-03"
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{%Markdown%}} is a markup language with a plain-text-formatting syntax. Markdown is often used as a format for documentation and readme files since it allows writing in an easy-to-read and easy-to-write style. Its design allows it to be easily converted to many output formats, but initially, it was created to convert only to HTML. Using the Aspose.HTML class library in your C# application, you can easily convert Markdown into a DOCX file with just a few lines of code!

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/en/conversion/md-to-docx" target="_blank">**MD to DOCX Converter**</a> that converts Markdown to DOCX file with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/html/en/conversion/md-to-docx" target="_blank">![Text "Banner MD to DOCX Converter"](md-to-docx.png#center)</a>

## **Convert Markdown to DOCX**

If your scenario is required converting Markdown document, for instance, to the DOCX file format, the following example demonstrates how that is simple: 

1. Prepare a source Markdown document. In the example, we create a Markdown file from code. 
1. Prepare a path for converted DOCX file saving. 
1. Convert Markdown to HTML. Use the [ConvertMarkdown(`sourcePath`)](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmarkdown/methods/4) method to save Markdown as an HTML document. 
1. Use the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/1) method. You need to pass the HTMLDocument, DocSaveOptions, and output file path to the ConvertHTML() method for HTML to DOCX conversion.

If your case is to create a Markdown document from a user string directly in your code and convert it to a DOCX file, the following example could help you: 

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
               "Convert Markdown to DOCX!";
    // Create a Markdown file
    File.WriteAllText(sourcePath, code);
    
    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "document-output.docx");
    
    // Convert Markdown to HTML document
    using var document = Converter.ConvertMarkdown(sourcePath);
    
    // Convert HTML document to DOCX file format
    Converter.ConvertHTML(document, new DocSaveOptions(), savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}

## **Convert Markdown to DOCX using DocSaveOptions**
If your case is to convert an existing Markdown document from a local file system, the following example could help you. You need to follow a few steps:

1. Open an existing Markdown document. In the example, we load a Markdown file from a local file system ([nature.md](https://github.com/aspose-html/Aspose.HTML-Documentation/blob/oa_conversion/content/tests-net/tests-data/nature.md)). 
1. Prepare a path for converted DOCX file saving. 
1. Convert Markdown to HTML. Use the [ConvertMarkdown(`sourcePath`)](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertmarkdown/methods/4) method of the Converter class to save Markdown as an HTML document. 
1. Create a new [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions) object and specify the required properties.
1. Use the [ConvertHTML()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/1) method. You need to pass the HTMLDocument, PdfSaveOptions, and output file path to the ConvertHTML() method.

The following code snippet shows how to convert Markdown to DOCX with custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Drawing;
using Aspose.Html.Saving;
...
    // Prepare a path to a source Markdown file
    string sourcePath = Path.Combine(DataDir, "nature.md");

    // Prepare a path for converted DOCX file saving 
    string savePath = Path.Combine(OutputDir, "nature-output.docx");
    
    // Convert Markdown to HTML document
    using var document = Converter.ConvertMarkdown(sourcePath);
    
    // Initialize DocSaveOptions. Set up the page-size 600x400 pixels and margins 
    var options = new DocSaveOptions();
    options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(500, 1000), new Margin(20, 20, 10, 10));
    
    // Convert HTML document to DOCX file format
    Converter.ConvertHTML(document, options, savePath);
{{< /highlight >}}

The [DocSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/docsaveoptions) class provides properties that give you full control over a wide range of parameters and improve the process of converting Markdown to DOCX format. In the example, we use the PageSetup property that specifies the page size of the DOCX document. To learn more about DocSaveOptions, please read the [Fine-Tuning Converters](http://localhost:1313/html/net/converting-between-formats/fine-tuning-converters/) article.

{{% alert color="primary" %}} 
You can check the quality of Markdown to DOCX conversion with our online [**MD to DOCX Converter**](https://products.aspose.app/html/en/conversion/md-to-docx). Upload, convert your files and get results in a few seconds. Try our forceful Markdown to DOCX Converter for free now!
{{% /alert %}}
