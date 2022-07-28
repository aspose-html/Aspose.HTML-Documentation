---
title: Markdown Converter | C#
linktitle: Markdown Converter
keywords: Markdown converter, convert markdown, convert markdown to html, markdown to html, convert markdown to jpg, markdown to jpg, c# code, online converter
description: In this article, you learn how to convert Markdown to other formats using Aspose.HTML API and consider C# example of Markdown to JPG conversion.
weight: 40
type: docs
url: /net/converting-between-formats/markdown-converter/
lastmod: 2022-07-28
---

Markdown is a lightweight markup language designed to indicate formatting in plain text. MD files use Markdown language that was proposed and developed by John Gruber. They include inline text characters that determine how text is formatted, such as indentation, table formatting, fonts, and headings. In addition, MD files can be converted to HTML, PDF or images to take advantage of other formats for specific tasks. 

The main highlight of Aspose.HTML is a conversion feature. The [Aspose.Html.Converters](https://reference.aspose.com/html/net/aspose.html.converters) namespace implements easy access to conversion methods. It provides a wide range of conversions to popular formats, such as Markdown to HTML, Markdown to DOCX, or Markdown to PDF. 

{{% alert color="primary" %}}
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}} 

This section provides information on the list of supported Markdown conversions and how to perform them using [ConvertMarkdown()](https://reference.aspose.com/html/net/aspose.html.converters/converter/methods/convertmarkdown/index) methods. All of these methods allow for the basic Markdown to HTML conversion. Conversions from Markdown to other formats go through the Markdown to HTML conversion stage.

Please take a look at the following C# example, which shows Markdown to JPG conversion with [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) specifying:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System.Drawing;
...  

    // Prepare a path to a source Markdown file
    string sourcePath = Path.Combine(DataDir, "nature.md");            
    
    // Prepare a path for converted file saving 
    string outputPath = Path.Combine(OutputDir, "nature-options.jpg");
    
    // Convert Markdown to HTML
    using var document = Converter.ConvertMarkdown(sourcePath);
    
    // Initialize an instance of ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Jpeg)
    {
        BackgroundColor = Color.AliceBlue
    };
    
    // Convert HTML document to JPG image file format
    Converter.ConvertHTML(document, options, outputPath);

{{< /highlight >}} 

In the example, the [ConvertMarkdown(`sourcePath`)](https://reference.aspose.com/html/net/aspose.html.dom.svg/svgdocument/constructors/10) method takes the source path of an Markdown file and results an [HTMLDocument](https://reference.aspose.com/html/net/aspose.html/htmldocument). The ImageSaveOptions() constructor creates a new [ImageSaveOptions](https://reference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with JPG ImageFormat and BackgroundColor properties. Then, the [ConvertHTML()](https://reference.aspose.com/html/net/aspose.html.converters.converter/converthtml/methods/3) method takes HTMLDocument, ImageSaveOptions, and output path and completes the Markdown to JPG conversion.

{{% alert color="primary" %}} 
Aspose.HTML offers a free online [**Markdown Converter**](https://products.aspose.app/html/conversion/md) for converting Markdown files to a variety of popular formats.  You can easily convert  [Markdown to HTML](https://products.aspose.app/html/conversion/md-to-html), [Markdown to PDF](https://products.aspose.app/html/conversion/md-to-pdf), [Markdown to JPG](https://products.aspose.app/html/conversion/md-to-jpg), or [MHTML to DOCX](https://products.aspose.app/html/conversion/md-to-docx). Just select the file, choose the format to convert, and you're done. It's fast and completely free!
{{% /alert %}} 





