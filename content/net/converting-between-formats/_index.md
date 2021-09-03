---
title: Converting Between Formats
type: docs
weight: 30
aliases: /net/converting-between-formats/
description: This chapter provides a general description of conversion features of Aspose.HTML .NET. You find out how to convert HTML, SVG, MHTML, EPUB, MD documents to PDF, XPS, DOCX, MD, MHTML and Image formats using Aspose.HTML API. 
keywords: HTML converter, MHTML converter, SVG converter, EPUB converter, Markdown converter, html to pdf, html to jpg, svg to png, mhtml to pdf, md to html.
lastmod: "2021-09-03"
---

Welcome to the "Converting between Formats" guides. The articles in this section provide information on the list of supported conversion scenarios and how to perform them using a [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class that groups all low-level conversion operation in a single class to make it comfy and easy to use.

The main highlight of Aspose.HTML is the conversion feature. Converting between formats is required for various reasons: to work in a familiar, convenient format or to take advantage of different formats for specific tasks. In this chapter, you find the following sections: 

 - [HTML Converter](/net/converting-between-formats/html-converter/) - You learn how to convert an [HTML document](https://apireference.aspose.com/net/html/aspose.html/htmldocument) to different formats, including {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, {{%GIF%}}, {{%MD%}}, and {{%MHTML %}}.

 - [SVG Converter](/net/converting-between-formats/svg-converter/)  - You find information on how to convert {{%SVG %}} to {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}} formats.

 - [EPUB Converter](/net/converting-between-formats/epub-converter/)  - You find out how to convert {{%EPUB %}} to {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}} formats.

 - [MHTML Converter](/net/converting-between-formats/mhtml-converter/) provides a general description of how to convert {{%MHTML %}} to {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}} formats.

 - [Markdown Converter](/net/converting-between-formats/markdown-converter/) - You learn how to convert {{%MD%}} to {{%HTML%}}, {{%PDF%}}, {{%XPS%}}, {{%DOCX%}}, and Image file formats using Aspose.HTML API.

 - [Template Converter](/net/converting-between-formats/html-template/) - You learn how to populate an HTML template from XML or JSON data sources.

 - [Fine-Tuning Converters](/net/converting-between-formats/fine-tuning-converters/) - You will find information on using different rendering options and parameters to customize the rendering result.

{{% alert color="primary" %}} 

Aspose.HTML offers free online [**Converters**](https://products.aspose.app/html/en/conversion) for converting HTML, XHTML, MHTML, EPUB, XML and Markdown files to a variety of popular formats.  You can easily convert  [HTML to PDF](https://products.aspose.app/html/en/conversion/html-to-pdf), [HTML to JPG](https://products.aspose.app/html/en/conversion/html-to-jpg), [SVG to PDF](https://products.aspose.app/svg/en/conversion/svg-to-pdf), [MHTML to PDF](https://products.aspose.app/html/en/conversion/mhtml-to-pdf) or [MD to HTML](https://products.aspose.app/html/en/conversion/md-to-html). Just select the file, choose the format to convert, and you're done. It's fast and completely free!

{{% /alert %}} 



Aspose.HTML for .NET offer the static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class  as an understandable and straightforward way to convert HTML, SVG, MHTML, EPUB, MD documents to PDF, XPS, DOCX, MD, MHTML and Image formats. Don't delay! Test the conversion between formats!

The following example demonstrates converting HTML to PDF with one line of code.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
...
     // Invoke the ConvertHTML method to convert the HTML code to PDF           
     Converter.ConvertHTML(@"<h1>Hello, World!</h1>", ".", new PdfSaveOptions(), Path.Combine(OutputDir, "convert-with-single-line.pdf"));
{{< /highlight >}}



