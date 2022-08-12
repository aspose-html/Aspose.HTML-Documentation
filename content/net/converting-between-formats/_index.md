---
title: Converting Between Formats | C# Examples
linktitle: Converting Between Formats
keywords: htmlL converter, mhtmlL converter, svg converter, epub converter, markdown converter, online converter, html to pdf, html to jpg, svg to png, mhtml to pdf, md to html
description: You find out how to convert HTML, MHTML, EPUB, Markdown and SVG files using methods of the Converter class or the RenderTo() method.
weight: 30
type: docs
aliases: /net/converting-between-formats/
lastmod: 2022-07-28
---

Welcome to the "Converting between Formats" guides! The main highlight of Aspose.HTML is the conversion feature. Converting between formats is required for various reasons: to work in a familiar, convenient format or to take advantage of different formats for specific tasks. This chapter provides a general description of the conversion features  of Aspose.HTML .NET. In the article you find out how to convert HTML, MHTML, EPUB, Markdown and SVG files using .NET library.

## **A Few Ways to Convert files**

Aspose.HTML for .NET offers several ways to convert between formats: converting can perform by using methods of the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter/) class or the [RenderTo()](https://reference.aspose.com/html/net/aspose.html/htmldocument/renderto/#renderto) method.

1. The static Converter class is a shared facade that provides HTML, MHTML, EPUB, Markdown and SVG file conversions to the popular formats and allows to make these operations convenient and easy. The static methods as an understandable and straightforward way to convert HTML, SVG, MHTML, EPUB, MD documents to PDF, XPS, DOCX, MD, MHTML and Image formats. 

2. The RenderTo() method is used to render HTML or SVG to another format and send a document to the output device. Aspose.HTML API provides the following output devices implementation: the PdfDevice, XpsDevice, DocDevise, and ImageDevice classes, which perform rendering to PDF, XPS, DOCX and Image file formats respectively.

The following example demonstrates converting HTML to PDF using  the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter/) class, with one line of code:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Invoke the ConvertHTML() method to convert the HTML code to PDF           
     Converter.ConvertHTML(@"<h1>Hello, World!</h1>", ".", new PdfSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.pdf"));
{{< /highlight >}}

In the example, we use the [ConvertHTML(`content, baseUri, options, outputPath`)](https://reference.aspose.com/html/net/aspose.html.converters/converter/converthtml/) method of the Converter class. Despite the HTML to PDF conversion is required only one line of code, the following operations were performed:

1. Prepare code for an HTML document.
2. Create a new PdfSaveOptions object with default options. 
3. Use the ConvertHTML() method that takes as parameters `content`, `baseUri`, `options`, and `outputPath`. **Note:** You need to specify the path to the output file in your local file system (`outputPath`).

To convert HTML to PDF using the  [RenderTo()](https://reference.aspose.com/html/net/aspose.html/htmldocument/renderto/#renderto) method, you can use the following code snippet:

{{< highlight java >}}
using Aspose.Html;
using Aspose.Html.Rendering.Pdf;
using System.IO;
...

    // Prepare path to a source HTML file
    string documentPath = Path.Combine(DataDir, "spring.html");
    
    // Prepare path for converted file saving 
    string savePath = Path.Combine(OutputDir, "spring-output.pdf");
    
    // Initialize an HTML document from the file
    using var document = new HTMLDocument(documentPath);
    
    // Create an instance of the PdfRenderingOptions class
    var pdfOptions = new PdfRenderingOptions();
    
    // Create the PDF Device and specify the output file to render
    using var device = new PdfDevice(pdfOptions, savePath);
    
    // Render HTML to PDF
    document.RenderTo(device);
{{< /highlight >}}

In the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article, you will find more information on using different rendering options and parameters to customize the rendering result.

## **Popular Converters** 

The current chapter describes popular converters, as well as C# examples for most common conversions scenarios. Using the examples, you can understand that the conversion process is quite universal and includes only a few necessary steps. The articles in this chapter provide information on the list of supported popular conversions and how to perform them using the [Converter](https://reference.aspose.com/html/net/aspose.html.converters/converter/) class that groups all low-level conversion operations in a single class to make it comfy and easy to use. Don’t delay! Test the conversion between formats!

 - [HTML Converter](/html/net/converting-between-formats/html-converter/) - allows convert an [HTML document](https://reference.aspose.com/html/net/aspose.html/htmldocument/) to {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, {{%GIF%}}, {{%MD%}}, and {{%MHTML %}}.
 - [SVG Converter](/html/net/converting-between-formats/svg-converter/)  - You find information on how to convert {{%SVG %}} to {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}} formats.
 - [EPUB Converter](/html/net/converting-between-formats/epub-converter/)  - You find out how to convert {{%EPUB %}} to {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}} formats.
 - [MHTML Converter](/html/net/converting-between-formats/mhtml-converter/) provides a general description of how to convert {{%MHTML %}} to {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}} formats.
 - [Markdown Converter](/html/net/converting-between-formats/markdown-converter/) - You learn how to convert {{%MD%}} to {{%HTML%}}, {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, and Image file formats using Aspose.HTML API.

{{% alert color="primary" %}} 

Aspose.HTML offers free online [**Converters**](https://products.aspose.app/html/conversion) for converting HTML, XHTML, MHTML, EPUB, XML and Markdown files to a variety of popular formats.  You can easily convert  [HTML to PDF](https://products.aspose.app/html/conversion/html-to-pdf), [HTML to JPG](https://products.aspose.app/html/conversion/html-to-jpg), [SVG to PDF](https://products.aspose.app/svg/conversion/svg-to-pdf), [MHTML to PDF](https://products.aspose.app/html/conversion/mhtml-to-pdf) or [MD to HTML](https://products.aspose.app/html/conversion/md-to-html). Just select the file, choose the format to convert, and you're done. It's fast and completely free!{{% /alert %}} 

